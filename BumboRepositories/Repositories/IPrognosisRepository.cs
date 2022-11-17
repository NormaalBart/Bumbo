﻿using BumboData.Models;

namespace BumboData
{
    public interface IPrognosisRepository
    {
        IEnumerable<Prognosis> GetAll();
        void Add(Prognosis prognosisDay);
        Prognosis GetById(int id);
        Prognosis GetByDate(DateOnly date);
        IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date);

        double GetCassierePrognose(DateTime date);
        double GetFreshPrognose(DateTime date);
        double GetStockersPrognose(DateTime date);
        int GetIdByDate(DateTime date);

        DateOnly GetNextEmptyPrognosisDate();

        void AddOrUpdateAllAsync(Branch defaultBranch, List<Prognosis> list);

        IEnumerable<Prognosis> GetNextWeek(DateOnly firstDayOfWeek);

        IEnumerable<DepartmentPrognosis> CalculateDepartmentPrognosis(Prognosis prognosis);


    }
}
