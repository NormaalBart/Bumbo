using System.ComponentModel.DataAnnotations;

namespace BumboData.Enums;

public enum UnavailableMomentType
{
    [Display(Name = "School")] School,
    [Display(Name = "Anders")] Other
}