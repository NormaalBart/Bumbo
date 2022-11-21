using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IPrognosisRepository: IRepository<Prognosis>
    {
        Prognosis GetByDate(DateOnly date);
        IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date);

        double GetCassierePrognose(DateTime date);
        double GetFreshPrognose(DateTime date);
        double GetStockersPrognose(DateTime date);
        int GetIdByDate(DateTime date);

        DateOnly GetNextEmptyPrognosisDate();

        void AddOrUpdateAll(Branch branch, List<Prognosis> list);

        IEnumerable<Prognosis> GetNextWeek(DateOnly firstDayOfWeek);

        IEnumerable<DepartmentPrognosis> CalculateDepartmentPrognoses(Prognosis prognosis);
    }
}