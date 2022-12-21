using System.ComponentModel.DataAnnotations;

namespace BumboData.Enums;

public enum UnavailabilitySortingOption
{
    [Display(Name = "Voornaam A-Z")] Name_Asc,
    [Display(Name = "Voornaam Z-A")] Name_Desc,

    [Display(Name = "Datum Nieuwste-Oudste")]
    Date_Desc,

    [Display(Name = "Datum Oudste-Nieuwste")]
    Date_Asc,
    [Display(Name = "Status Inkomend")] Status_Todo,
    [Display(Name = "Status Afgewerkt")] Status_Finished
}