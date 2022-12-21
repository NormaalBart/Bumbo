using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;

namespace BumboData.Models;

public class WorkedShift : IEntity<int>
{
    [Required] public Employee Employee { get; set; }

    public string EmployeeId { get; set; }

    [Required] public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    [Required] public bool Approved { get; set; }

    [Required] public Branch Branch { get; set; }

    public int BranchId { get; set; }

    [Required] public bool Sick { get; set; }

    [Key] public int Id { get; set; }
}