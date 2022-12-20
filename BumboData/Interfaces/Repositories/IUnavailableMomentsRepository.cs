using BumboData.Enums;
using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IUnavailableMomentsRepository : IRepository<UnavailableMoment>
    {
        bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
        IEnumerable<UnavailableMoment> GetAll(string employeeId);
        IEnumerable<UnavailableMoment> GetOverlappingMoments(UnavailableMoment unavailableMoment); 
        bool EmployeeSchoolWeek(string employee, int year, int week);
        List<UnavailableMoment> GetSchoolUnavailableMomentsByWeek(string employee, int year, int week);
        List<UnavailableMoment> GetSchoolUnavailableMomentsByDay(string employee, DateOnly day);

        List<UnavailableMoment> GetWeekOfUnavailableMomentsAfterDateForEmployee(DateTime date, string employeeId);

        IEnumerable<UnavailableMoment> GetAllUnavailabilityMomentsByReviewStatus(int branchId, ReviewStatus status, string search);
        IEnumerable<UnavailableMoment> GetAllMomentsFromMonth(int branchId, DateTime date, string search);

        void UpdateRange(ReviewStatus newStatus, List<int> momentIds);

    }
}
