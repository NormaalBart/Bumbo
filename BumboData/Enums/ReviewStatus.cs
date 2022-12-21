using System.ComponentModel.DataAnnotations;

namespace BumboData.Enums;

public enum ReviewStatus
{
    [Display(Name = "In afwachting")] Pending,
    [Display(Name = "Goedgekeurd")] Approved,
    [Display(Name = "Afgekeurd")] Rejected
}