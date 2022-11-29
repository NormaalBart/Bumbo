using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.Standard
{
    public class StandardViewModel
    {

        public int BranchId { get; set; }

        [Required]
        [DisplayName("Activiteit")]
        public StandardType Key { get; set; }

        [Required]
        [DisplayName("Normering")]
        [Range(0, int.MaxValue, ErrorMessage = "Dit getal moet positief zijn")]
        public int Value { get; set; }

    }
}
