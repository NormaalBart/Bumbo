using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class OpeningHouersViewModel
    {

        public int BranchId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        [DisplayName("Openingstijd")]
        public TimeOnly OpenTime { get; set; }

        [Required]
        [DisplayName("Sluitingstijd")]
        public TimeOnly CloseTime { get; set; }
    }
}
