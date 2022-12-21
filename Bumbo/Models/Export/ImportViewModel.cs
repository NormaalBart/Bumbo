using System.ComponentModel;
using Bumbo.Models.Validations;

namespace Bumbo.Models.ExportManager;

public class ImportViewModel
{
    [DisplayName("Importeer medewerkers")]
    [AllowExtensions(Extensions = "csv", ErrorMessage = "Bestand mag alleen een .csv bestand zijn.")]
    public IFormFile? ImportEmployees { get; set; }

    [DisplayName("Importeer klok systeem events")]
    [AllowExtensions(Extensions = "csv", ErrorMessage = "Bestand mag alleen een .csv bestand zijn.")]
    public IFormFile? ImportClockEvents { get; set; }

    public bool ImportAsPlanned { get; set; }
}