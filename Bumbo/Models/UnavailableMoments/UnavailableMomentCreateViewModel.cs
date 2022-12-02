using BumboData.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailableMomentCreateViewModel
    {
        public int Id { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        public string StartHour { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string EndHour { get; set; }


        [Required]
        [DisplayName("Reden")]
        public UnavailableMomentType Type { get; set; }
    }
}
