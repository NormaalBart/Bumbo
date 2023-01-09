using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;

namespace BumboData.Models;

public class Prognosis : IEntity
{
    [Required] public DateOnly Date { get; set; }

    [Required] public Branch Branch { get; set; }

    [Required] public int ColiCount { get; set; }

    [Required] public int CustomerCount { get; set; }

    public int BranchId { get; set; }

    [Key] public int Id { get; set; }
}