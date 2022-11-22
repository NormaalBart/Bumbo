using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class WorkedShiftRepository : Repository<WorkedShift>, IWorkedShiftRepository
    {
        public WorkedShiftRepository(BumboContext context) : base(context)
        {
        }
        
        public IEnumerable<WorkedShift> GetAllApproved(int branchId)
        {
            return DbSet.Where(s => s.Approved && s.BranchId == branchId).ToList();
        }

        public WorkedShift LastWorkedShiftWithNoEndTime(Employee employee)
        {
            return DbSet.Where(o => o.Employee == employee && o.EndTime == null)
                .OrderByDescending(o => o.StartTime)
                .FirstOrDefault();
        }

        public List<WorkedShift> GetWorkedShiftsInMonth(int branchId, string employeeId, int year, int month)
        {
            return DbSet.Include(i => i.Employee).Where(s =>
                s.BranchId == branchId && employeeId == s.EmployeeId && s.StartTime.Year == year && s.StartTime.Month == month).ToList();
        }

        public List<WorkedShift> GetWorkedShiftsInMonth(int branchId, int year, int month)
        {
            return DbSet.Include(i => i.Employee).Where(s =>
                s.BranchId == branchId && s.StartTime.Year == year && s.StartTime.Month == month).ToList();
        }
    }
}