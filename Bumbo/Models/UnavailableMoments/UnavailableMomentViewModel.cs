using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailableMomentsViewModel
    {
        public int Id { get; set; }
        [DisplayName("Van")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime StartTime { get; set; }
        [DisplayName("Tot")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime EndTime { get; set; }
        [DisplayName("Rede")]
        public UnavailableMomentType Type { get; set; }
    }
}
