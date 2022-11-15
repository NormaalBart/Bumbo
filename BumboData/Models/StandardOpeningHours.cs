using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class StandardOpeningHours
{
    public Branch Branch { get; set; }

    [Key]
    public int BranchId { get; set; }

    [Key]
    public DayOfWeek DayOfWeek { get; set; }

    [Required]
    public TimeOnly OpenTime { get; set; }

    [Required]
    public TimeOnly CloseTime { get; set; }
}