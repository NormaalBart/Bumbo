namespace Bumbo.Models.EmployeeManager
{
    public class EmployeeDepartmentViewModel
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public bool IsSelected { get; set; }
        
        public EmployeeDepartmentViewModel()
        {
        }
    }
}
