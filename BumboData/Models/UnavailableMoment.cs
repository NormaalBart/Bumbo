using BumboData.Enums;
using BumboData.Interfaces;

namespace BumboData.Models;

public class UnavailableMoment : IEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public Employee Employee { get; set; }
    
    public string EmployeeId { get; set; }

    [Required]
    public DateTime StartTime { get; set; }
    
    [Required]
    public DateTime EndTime { get; set; }

    [Required]
    public UnavailableMomentType Type { get; set; }
}