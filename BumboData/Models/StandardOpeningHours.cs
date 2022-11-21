using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboData.Models;

public class StandardOpeningHours
{
    public Branch Branch { get; set; }

    public int BranchId { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    [Required]
    public TimeOnly OpenTime { get; set; }

    [Required]
    public TimeOnly CloseTime { get; set; }
}