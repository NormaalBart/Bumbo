using BumboData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData.Models
{
    public  class Departments
    {
        [Key]
        public int EmployeeId { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        [EnumDataType(typeof(DepartmentEnum))]
        public DepartmentEnum Department { get; set; }

        public Departments()
        {

        }

        public Departments(int employeeId, DepartmentEnum department)
        {
            EmployeeId = employeeId;
            Department = department;
        }

    }
}
