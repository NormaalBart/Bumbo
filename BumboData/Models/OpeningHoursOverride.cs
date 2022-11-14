using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class OpeningHoursOverride
{
    [Key]
    public Branch Branch { get; set; }

    [Key]
    public DateOnly Date { get; set; }

    [Required]
    public TimeOnly OpenTime { get; set; }

    [Required]
    public TimeOnly CloseTime { get; set; }
}