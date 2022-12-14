using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class OpeningHoursViewModel : IValidatableObject
    {

        public int BranchId { get; set; }

        public DayOfWeekViewModel DayOfWeek { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Openingstijd")]
        public TimeSpan? OpenTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Sluitingstijd")]
        public TimeSpan? CloseTime { get; set; }

        [DisplayName("Gesloten")]
        public bool IsClosed { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (IsClosed)
            {
                yield break;
            }
            if (OpenTime == null)
            {
                yield return new ValidationResult("Openingstijd mag niet leeg zijn als de winkel open is", new string[] { "OpenTime" });
            }

            if (CloseTime == null)
            {
                yield return new ValidationResult("Sluitingstijd mag niet leeg zijn als de winkel open is", new string[] { "CloseTime" });
            }

            if (OpenTime >= CloseTime)
            {
                yield return new ValidationResult("Openingstijd is later of gelijk aan de sluitingstijd", new string[] { "OpenTime" });
            }
        }
    }
}
