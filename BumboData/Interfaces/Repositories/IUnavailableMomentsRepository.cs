using BumboData.Enums;
using BumboData.Models;

namespace BumboData.Interfaces.Repositories;

public interface IUnavailableMomentsRepository : IRepository<UnavailableMoment>
{
    bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
    IEnumerable<UnavailableMoment> GetAll(string employeeId);
    IEnumerable<UnavailableMoment> GetOverlappingMoments(UnavailableMoment unavailableMoment);
    bool EmployeeSchoolWeek(string employee, int year, int week);
    List<UnavailableMoment> GetSchoolUnavailableMomentsByWeek(string employee, int year, int week);
    List<UnavailableMoment> GetSchoolUnavailableMomentsByDay(string employee, DateOnly day);

    List<UnavailableMoment> GetWeekOfUnavailableMomentsAfterDateForEmployee(DateTime date, string employeeId);

    void UpdateRange(ReviewStatus newStatus, List<int> momentIds);

    int GetTotalMoments(int? defaultBranchId, string searchString, bool includeAccepted);

    IEnumerable<UnavailableMoment> GetAllMoments(int? defaultBranchId, string searchString, bool includeAccepted,
        UnavailabilitySortingOption sortingOption, int? page, int momentsPerPage);
}