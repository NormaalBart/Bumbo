using BumboData.Models;
using BumboServices.CAO.Rules;

namespace BumboServices.Interface;

public interface ICAOService
{
    public Dictionary<ICAORule, List<PlannedShift>> VerifyPlannedShifts(List<PlannedShift> plannedShifts,
        DateOnly forDay);
}