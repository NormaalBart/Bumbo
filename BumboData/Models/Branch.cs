using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class Branch
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    
    public Employee? Manager { get; set; }
    
    [Required]
    public int ShelvingDistance { get; set; }
    
    [Required]
    public String City { get; set; }
    
    [Required]
    public String HouseNumber { get; set; }
    
    [Required]
    public String Street { get; set; }
    
    public virtual ICollection<Employee> DefaultEmployees { get; set; }

    public virtual ICollection<Standard> Standards { get; set; }
    
    public virtual ICollection<Prognosis> Prognoses { get; set; }
    
    public virtual ICollection<StandardOpeningHours> StandardOpeningHours { get; set; }
    
    public virtual ICollection<OpeningHoursOverride> OpeningHoursOverrides { get; set; }
    public bool Inactive { get; set; }
}