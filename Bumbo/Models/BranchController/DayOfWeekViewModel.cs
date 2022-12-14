using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public enum DayOfWeekViewModel
    {
        [Display(Name = "Zondag")]
        Sunday,
        [Display(Name = "Maandag")]
        Monday,
        [Display(Name = "Dinsdag")]
        Tuesday,
        [Display(Name = "Woensdag")]
        Wednesday,
        [Display(Name = "Donderdag")]
        Thursday,
        [Display(Name = "Vrijdag")]
        Friday,
        [Display(Name = "Zaterdag")]
        Saturday

    }
}
