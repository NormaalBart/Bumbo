using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.Standard
{
    public class StandardViewModel
    {

        public int BranchId { get; set; }

        [Required(ErrorMessage = "Dit moet zijn ingevuld")]
        [DisplayName("Hoelang per coli uitladen?")]
        [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
        public int ColiTime{ get; set; }

        [Required(ErrorMessage = "Dit moet zijn ingevuld")]
        [DisplayName("Hoeveel minuten per coli in de vakken zetten?")]
        [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
        public int ShelfStockingTimes { get; set;}

        [Required(ErrorMessage = "Dit moet zijn ingevuld")]
        [DisplayName("1 Kassiere per hoeveel klanten per uur?")]
        [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
        public int CheckoutEmployees { get; set; }

        [Required(ErrorMessage = "Dit moet zijn ingevuld")]
        [DisplayName("1 Medewerker per hoeveel klanten per uur?")]
        [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
        public int FreshEmployees { get; set; }

        [Required(ErrorMessage = "Dit moet zijn ingevuld")]
        [DisplayName("Hoeveel seconde per meter?")]
        [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
        public int ShelfArrangement { get; set; }

    }
}
