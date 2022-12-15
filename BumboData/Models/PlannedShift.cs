using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;

namespace BumboData.Models;

public class PlannedShift: IEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    [Required]
    public Employee Employee { get; set; }
    
    public string EmployeeId { get; set; }

    [Required]
    public Department Department { get; set; }
    
    public int DepartmentId { get; set; }

    [Required]
    public Branch Branch { get; set; }

    [Required] 
    public bool Sick { get; set; }

    public int BranchId { get; set; }
}