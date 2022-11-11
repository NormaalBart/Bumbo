using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IPrognosis
    {
        IEnumerable<PrognosisDay> GetAll();
        void Add(PrognosisDay prognosisDay);
        PrognosisDay GetByDate(DateTime date);
        IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date);

        double GetCassierePrognose(DateTime date);
        double GetFreshPrognose(DateTime date);
        double GetStockersPrognose(DateTime date);
        int GetIdByDate(DateTime date);

        DateTime GetNextEmptyPrognosisDate();

        void AddOrUpdateAll(List<PrognosisDay> list);

        IEnumerable<PrognosisDay> GetNextWeek(DateTime firstDayOfWeek);

    }
}
