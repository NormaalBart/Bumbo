using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.Standard;

public class StandardViewModel
{
    public int BranchId { get; set; }

    [Required(ErrorMessage = "Dit moet zijn ingevuld")]
    [DisplayName("Coli uitladen")]
    [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
    public int ColiTime { get; set; }

    [Required(ErrorMessage = "Dit moet zijn ingevuld")]
    [DisplayName("Coli inruimen")]
    [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
    public int ShelfStockingTimes { get; set; }

    [Required(ErrorMessage = "Dit moet zijn ingevuld")]
    [DisplayName("Kassa draaien")]
    [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
    public int CheckoutEmployees { get; set; }

    [Required(ErrorMessage = "Dit moet zijn ingevuld")]
    [DisplayName("Klanten helpen bij vers afdeling")]
    [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
    public int FreshEmployees { get; set; }

    [Required(ErrorMessage = "Dit moet zijn ingevuld")]
    [DisplayName("Spiegelen")]
    [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
    public int ShelfArrangement { get; set; }
}