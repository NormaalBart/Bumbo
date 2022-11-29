using BumboData.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailableMomentsViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Van")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayName("Tot")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime EndTime { get; set; }

        [Required]
        [DisplayName("Reden")]
        public UnavailableMomentType Type { get; set; }
    }
}
