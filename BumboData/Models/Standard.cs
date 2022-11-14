using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class Standard
{
    [Key]
    public Branch Branch { get; set; }

    [Key]
    public StandardType Key { get; set; }

    [Required]
    public int Value { get; set; }
}