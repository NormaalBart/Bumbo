using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BumboData.Models;

public class Employee: IdentityUser
{

    [Key]
    public int Key { get; set; }
    
    [Required]
    public String FirstName { get; set; }
    
    public String? Preposition { get; set; }
    
    [Required]
    public String LastName { get; set; }
    
    [Required]
    public DateOnly Birthdate { get; set; }

    [Required]
    public Boolean Active { get; set; }

    [Required]
    public Branch DefaultBranch { get; set; }

    public virtual ICollection<Branch> ManagedBranches { get; set; }
 
    public virtual ICollection<Department> AllowedDepartments { get; set; }
    
    public virtual ICollection<PlannedShift> PlannedShifts { get; set; }

    public virtual ICollection<WorkedShift> WorkedShifts { get; set; }
    
    public virtual ICollection<UnavailableMoment> UnavailableMoments { get; set; }
}