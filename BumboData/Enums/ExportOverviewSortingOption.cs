using System.ComponentModel.DataAnnotations;

namespace BumboData.Enums;

public enum ExportOverviewSortingOption
{
    [Display(Name = "Gewerkte uren aflopend")]
    HoursAsc,
    [Display(Name = "Gewerkte uren oplopend")]
    HoursDesc,
    [Display(Name = "Uren ziek aflopend")]
    SickAsc,
    [Display(Name = "Uren ziek oplopend")]
    SickDesc,
    [Display(Name = "Verschil aflopend")]
    DifferenceAsc,
    [Display(Name = "Verschil oplopend")]
    DifferenceDesc,
}