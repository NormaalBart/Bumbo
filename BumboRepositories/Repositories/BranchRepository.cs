using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {

        public BranchRepository(BumboContext context)
            : base(context)
        {

        }

        public IEnumerable<Branch> GetAllActiveBranches()
        {
            return DbSet.Where(branch => !branch.Inactive).ToList();
        }

        public List<Branch> GetUnmanagedBranches()
        {
            return DbSet.Where(branch => branch.Managers.Count == 0).ToList();
        }

        public (TimeOnly, TimeOnly) GetOpenAndCloseTimes(int branchId, DateOnly day)
        {
            // First check if any overrides are placed on given day
            var over = Context.OpeningHoursOverride.FirstOrDefault(s => s.Date == day && s.BranchId == branchId);
            if (over != null)
            {
                return over.IsClosed ? (TimeOnly.MinValue, TimeOnly.MinValue) : (over.OpenTime, over.CloseTime);
            }

            // Check regular opening times
            var regular =
                Context.StandardOpeningHours.FirstOrDefault(o =>
                    o.DayOfWeek == day.DayOfWeek && o.BranchId == branchId);

            if (regular is { IsClosed: false })
            {
                return (regular.OpenTime ?? TimeOnly.MinValue, regular.CloseTime ?? TimeOnly.MinValue);
            }

            // Closed
            return (TimeOnly.MinValue, TimeOnly.MinValue);
        }

        public override Branch? Get(int id)
        {
            var branch = DbSet.Include(branch => branch.StandardOpeningHours)
                .Include(branch => branch.OpeningHoursOverrides)
                .Include(branch => branch.Standards)
                .FirstOrDefault(branch => branch.Id == id);
            if (branch == null)
            {
                return null;
            }
            branch.OpeningHoursOverrides = branch.OpeningHoursOverrides.Where(model => model.Date.CompareTo(new DateOnly()) >= 0).ToList();
            return branch;
        }

        public override IEnumerable<Branch> GetList()
        {
            return DbSet.Include(branch => branch.DefaultEmployees).ToList();
        }

        public void SetInactive(int id)
        {
            var branch = Get(id);
            if (branch != null)
            {
                branch.Inactive = true;
                Update(branch);
            }
        }

        public void SetActive(int id)
        {
            var branch = Get(id);
            if (branch != null)
            {
                branch.Inactive = false;
                Update(branch);
            }
        }

        public void RemoveSpecialOpeningHour(int id, DateOnly date)
        {
            var branch = Get(id);
            if (branch == null)
            {
                return;
            }
            var model = branch.OpeningHoursOverrides.Where(openingHour => openingHour.Date == date).FirstOrDefault();
            if (model == null)
            {
                return;
            }
            branch.OpeningHoursOverrides.Remove(model);
            Update(branch);
        }

        public bool HasSpecialOpeningTimeOnDay(int branch, DateOnly day)
        {
            return Context.OpeningHoursOverride.Any(o => o.BranchId == branch && o.Date == day);
        }
    }
}
