using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class Standard
{
    [Key]
    public Branch Branch { get; set; }

    public int BranchId { get; set; }

    [Key]
    public StandardType Key { get; set; }

    [Required]
    public int Value { get; set; }
}