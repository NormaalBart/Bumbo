using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;

namespace BumboData.Models;

public class Branch : IEntity
{
    [Required] public string Name { get; set; }

    [Required] public int ShelvingDistance { get; set; }

    [Required] public string City { get; set; }

    [Required] public string HouseNumber { get; set; }

    [Required] public string Street { get; set; }

    public virtual ICollection<Employee> Managers { get; set; }
    public virtual ICollection<Employee> DefaultEmployees { get; set; }

    public virtual ICollection<Standard> Standards { get; set; }

    public virtual ICollection<Prognosis> Prognoses { get; set; }

    public virtual ICollection<StandardOpeningHours> StandardOpeningHours { get; set; }

    public virtual ICollection<OpeningHoursOverride> OpeningHoursOverrides { get; set; }
    public bool Inactive { get; set; }

    [Key] public int Id { get; set; }
}