using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IUnavailableMomentsRepository : IRepository<UnavailableMoment>
    {
        bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
        IEnumerable<UnavailableMoment> GetAll(string employeeId);
        IEnumerable<UnavailableMoment> GetOverlappingMoments(UnavailableMoment unavailableMoment);
        public bool EmployeeSchoolWeek(string employee, int year, int week);
        public List<UnavailableMoment> GetSchoolUnavailableMomentsByWeek(string employee, int year, int week);
        public List<UnavailableMoment> GetSchoolUnavailableMomentsByDay(string employee, DateOnly day);
    }
}
