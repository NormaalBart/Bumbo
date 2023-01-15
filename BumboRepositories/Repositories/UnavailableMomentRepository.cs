using BumboData;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories;

public class UnavailableMomentRepository : Repository<UnavailableMoment>, IUnavailableMomentsRepository
{
    private readonly IPlannedShiftsRepository _plannedShiftsRepository;

    public UnavailableMomentRepository(BumboContext context, IPlannedShiftsRepository plannedShiftsRepository) : base(context)
    {
        _plannedShiftsRepository = plannedShiftsRepository;
    }

    public IEnumerable<UnavailableMoment> GetAll(string employeeId)
    {
        return DbSet.Where(e => e.Employee.Id == employeeId).ToList();
    }

    public IEnumerable<UnavailableMoment> GetOverlappingMoments(UnavailableMoment unavailableMoment)
    {
        return DbSet.Where(u => unavailableMoment.Employee.Id == u.Employee.Id)
            .Where(e => unavailableMoment.StartTime < e.EndTime &&
                        e.StartTime < unavailableMoment.EndTime).ToList();
    }

    public bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime)
    {
        // check if employee is unavailable in unavailable moments 
        var unavailableMoments = DbSet.Where(u => u.Employee.Id == employeeId && u.StartTime.Date == startTime.Date)
            .ToList();
        var plannedShifts = (_plannedShiftsRepository.GetOfEmployeeOnDay(startTime, employeeId));
        return !unavailableMoments.Any(moment => startTime < moment.EndTime &&
                                                 moment.StartTime < endTime)
            || !plannedShifts.Any(shift => startTime < shift.EndTime &&
                            shift.StartTime < endTime);
    }

    /*
     * Returns if the employee has any school planned given week.
     */
    public bool EmployeeSchoolWeek(string employee, int year, int week)
    {
        // Tolist is required, weeknumber function can't be converted to SQL.
        return DbSet.ToList().Any(s =>
            s.EmployeeId == employee && s.StartTime.Year == year && s.StartTime.GetWeekNumber() == week &&
            s.Type == UnavailableMomentType.School);
    }

    public List<UnavailableMoment> GetSchoolUnavailableMomentsByWeek(string employee, int year, int week)
    {
        // Tolist is required, weeknumber function can't be converted to SQL.
        return DbSet.ToList().Where(s =>
            s.EmployeeId == employee && s.StartTime.Year == year && s.StartTime.GetWeekNumber() == week &&
            s.Type == UnavailableMomentType.School).ToList();
    }

    public List<UnavailableMoment> GetSchoolUnavailableMomentsByDay(string employee, DateOnly day)
    {
        return DbSet.Where(s => s.EmployeeId == employee && s.StartTime.Date.DayOfYear == day.DayOfYear
                                                         && s.StartTime.Date.Year == day.Year).ToList();
    }

    // returns next full week of unavailable moments.
    public List<UnavailableMoment> GetWeekOfUnavailableMomentsAfterDateForEmployee(DateTime date, string employeeId)
    {
        return DbSet.Where(u =>
            u.Employee.Id == employeeId && u.StartTime.Date >= date && u.StartTime <= date.AddDays(8)).ToList();
    }

    public void UpdateRange(ReviewStatus newStatus, List<int> momentIds)
    {
        // updates a list of unavailable moments to a new status.
        var trackedMoments = new List<UnavailableMoment>();
        foreach (var moment in from id in momentIds select Get(id) into moment where moment != null where moment.ReviewStatus == ReviewStatus.Pending select moment)
        {
            moment.ReviewStatus = newStatus;
            trackedMoments.Add(moment);
        }

        DbSet.UpdateRange(trackedMoments);
        Context.SaveChanges();
    }

    public int GetTotalMoments(int? defaultBranchId, string searchString, bool includeAccepted)
    {
        return DbSet.Where(u => u.EndTime > DateTime.Now).Include(u => u.Employee)
            .AsEnumerable()
            .Where(u => u.Employee.FullName().ToLower().StartsWith(searchString.ToLower()) && u.Employee.DefaultBranchId == defaultBranchId)
            .Count(u => includeAccepted || u.ReviewStatus == ReviewStatus.Pending);
    }

    public IEnumerable<UnavailableMoment> GetAllMoments(int? defaultBranchId, string searchString, bool includeAccepted,
        UnavailabilitySortingOption sortingOption, int? page, int momentsPerPage)
    {
        var set = DbSet
            .Where(u => u.EndTime > DateTime.Now).Include(u => u.Employee).AsEnumerable()
            .Where(u => u.Employee.FullName().ToLower().StartsWith(searchString.ToLower()) && u.Employee.DefaultBranchId == defaultBranchId)
            .Where(u => includeAccepted || u.ReviewStatus == ReviewStatus.Pending);
        set = sortingOption switch
        {
            UnavailabilitySortingOption.Name_Asc => set.OrderBy(u => u.Employee.FullName()),
            UnavailabilitySortingOption.Name_Desc => set.OrderByDescending(u => u.Employee.FullName()),
            UnavailabilitySortingOption.Date_Desc => set.OrderByDescending(u => u.StartTime),
            UnavailabilitySortingOption.Date_Asc => set.OrderBy(u => u.StartTime),
            UnavailabilitySortingOption.Status_Todo => set.OrderBy(u => u.ReviewStatus),
            UnavailabilitySortingOption.Status_Finished => set.OrderByDescending(u => u.ReviewStatus),
            _ => set = set.OrderBy(u => u.Employee.FullName())
        };
        return set.Skip(momentsPerPage * ((page ?? 1) - 1)).Take(momentsPerPage)
            .ToList();
    }
}