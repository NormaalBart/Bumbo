using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.RosterManager
{
    public class RosterShiftCreateViewModel
    {
        public string EmployeeId { get; set; }
        public int PrognosisId { get; set; }
        public Department Department { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Start tijd")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Required]
        [DisplayName("Eind tijd")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }


        public List<Department> DepartmentsList { get; set; }

        public RosterShiftCreateViewModel()
        {
            DepartmentsList = new List<Department>();
        }
    }
}
