using BumboData.Models;

namespace BumboServices.Surcharges.SurchargeRules;

interface ISurchargeRule
{
    Dictionary<SurchargeType, TimeSpan> CalculateSurcharges(List<WorkedShift> workedShifts);
}