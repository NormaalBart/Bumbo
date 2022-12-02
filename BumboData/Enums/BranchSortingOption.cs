using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BumboData.Enums
{
    public enum BranchSortingOption
    {
        [Display(Name = "Naam A-Z")]
        Name_Asc,
        [Display(Name = "Naam Z-A")]
        Name_Desc,
        [Display(Name = "Bestaat sinds nieuwste-oudste")]
        BranchSince_Desc,
        [Display(Name = "Bestaat sinds Oudste-Nieuwste")]
        BranchSince_Asc,
        [Display(Name = "Aantal medewerkers 1-100")]
        Employees_Desc,
        [Display(Name = "Aantal medewerkers 100-1")]
        Employees_Asc

    }
}
