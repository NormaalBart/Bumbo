namespace Bumbo.Models.EmployeeRoster
{
    public class EmployeeShiftViewModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DepartmentName { get; set; }
        
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }

    }
}
