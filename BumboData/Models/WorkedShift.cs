using BumboData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData.Models
{
    public class WorkedShift
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public virtual Employee Employee { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [Required]
        public Boolean Approved { get; set; }

        [Required]
        public Branch Branch { get; set; }

        [Required]
        public Boolean Sick { get; set; }

    }
}
