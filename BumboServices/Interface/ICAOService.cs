using BumboData.Models;
using BumboServices.CAO.Rules;

namespace BumboServices.Interface;

public interface ICAOService
{
    public Dictionary<ICAORule, IEnumerable<PlannedShift>> VerifyPlannedShiftsWeek(List<PlannedShift> plannedShifts);
}