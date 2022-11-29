using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class OpeningHoursOverrideViewModel
    {

        public int BranchId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum")]
        public DateOnly Date{ get; set; }

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
            if (OpenTime > CloseTime)
            {
                yield return new ValidationResult("Openingstijd is later dan de sluitingstijd", new string[] { "OpenTime" });
            }
        }

    }
}