using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class OpeningHoursOverrideViewModel : IValidatableObject
    {

        public int BranchId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Openingstijd")]
        public TimeSpan OpenTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Sluitingstijd")]
        public TimeSpan CloseTime { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (OpenTime >= CloseTime)
            {
                yield return new ValidationResult("Openingstijd is later of gelijk aan de sluitingstijd", new string[] { "OpenTime" });
            }
            if (Date.CompareTo(new DateTime()) <= 0)
            {
                yield return new ValidationResult("Datum kan niet in het verleden of vandaag zijn", new string[] { "Date" });
            }
        }

    }
}