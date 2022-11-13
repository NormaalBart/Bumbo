using BumboData.Models;

namespace BumboData
{
    public interface IPrognosis
    {
        IEnumerable<Prognosis> GetAll();
        void Add(Prognosis prognosisDay);
        Prognosis GetById(int id);
        Prognosis GetByDate(DateTime date);
        void Update(Prognosis prognosisDay);
        IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date);

        double GetCassierePrognose(DateTime date);
        double GetFreshPrognose(DateTime date);
        double GetStockersPrognose(DateTime date);
        int GetIdByDate(DateTime date);

        DateOnly GetNextEmptyPrognosisDate();

        void AddOrUpdateAll(List<PrognosisDay> list);

        IEnumerable<PrognosisDay> GetNextWeek(DateTime firstDayOfWeek);

    }
}
