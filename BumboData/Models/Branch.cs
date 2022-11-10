using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData.Models
{
    public class Branch
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BranchId { get; set; }
        [Required]
        public int ManagerId { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        [Required]
        public string Name { get; set; }
        public string PostalCode { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        public virtual ICollection<PlannedShift> PlannedShifts { get; set; }
    }
}
