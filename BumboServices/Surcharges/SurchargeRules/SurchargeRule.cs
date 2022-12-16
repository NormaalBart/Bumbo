using BumboData.Models;

namespace BumboServices.Surcharges.SurchargeRules;

public interface ISurchargeRule
{
    Dictionary<SurchargeType, TimeSpan> CalculateSurcharges(List<WorkedShift> workedShifts);
}