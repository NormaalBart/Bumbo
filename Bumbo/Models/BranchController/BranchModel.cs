using BumboData.Models;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class BranchModel
    {

        public Employee? Manager { get; set; }

        [Required]
        public int ShelvingDistance { get; set; }

        [Required]
        public String City { get; set; }

        [Required]
        public String HouseNumber { get; set; }

        [Required]
        public String Street { get; set; }

    }
}
