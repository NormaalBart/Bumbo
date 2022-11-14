
using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class WorkedShift
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public Employee Employee { get; set; }

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