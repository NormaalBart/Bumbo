using BumboData.Enums;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.RosterManager
{
    public class RosterShiftCreateViewModel
    {
        public int EmployeeId { get; set; }
        public int PrognosisId { get; set; }
        public DepartmentEnum Department { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Start time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Required]
        [DisplayName("Start time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }


        public List<Departments> DepartmentsList { get; set; }

        public RosterShiftCreateViewModel()
        {
            DepartmentsList = new List<Departments>();
        }
    }
}
