using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IPrognosisRepository: IRepository<Prognosis>
    {
        Prognosis GetByDate(DateOnly date,int branchId);
        IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date);

        int GetIdByDate(DateTime date);

        DateOnly GetNextEmptyPrognosisDate();

        void AddOrUpdateAll(Branch branch, List<Prognosis> list);

        IEnumerable<Prognosis> GetNextWeek(DateOnly firstDayOfWeek, int branchId);

        IEnumerable<DepartmentPrognosis> CalculateDepartmentPrognoses(Prognosis prognosis);
    }
}