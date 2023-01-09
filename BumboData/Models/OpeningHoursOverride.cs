using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class OpeningHoursOverride
{
    [Key] public Branch Branch { get; set; }

    public int BranchId { get; set; }

    [Key] public DateOnly Date { get; set; }

    [Required] public TimeOnly OpenTime { get; set; }

    [Required] public TimeOnly CloseTime { get; set; }

    [Required] public bool IsClosed { get; set; }
}