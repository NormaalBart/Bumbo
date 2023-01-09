using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboData.Models;

public class Standard
{
    [Key, Column(Order=0) ]
    public Branch Branch { get; set; }
    public int BranchId { get; set; }

    [Key, Column(Order=1) ] 
    public StandardType Key { get; set; }

    [Required] public int Value { get; set; }
}