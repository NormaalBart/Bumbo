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

    [Required]
    public Department Department { get; set; }
    
    [Required]
    public Branch Branch { get; set; }

    public int BranchId { get; set; }
}