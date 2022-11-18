using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BumboData.Models;

public class Employee: IdentityUser
{
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
    public string Postalcode { get; set; }

    [Required] 
    public string Housenumber { get; set; }

    [Required] 
    public DateOnly EmployeeSince { get; set; }

    [Required] 
    public string Function { get; set; }

    [Required]
    public Branch DefaultBranch { get; set; }

    public virtual ICollection<Branch> ManagedBranches { get; set; }
 
    public virtual ICollection<Department> AllowedDepartments { get; set; }
    
    public virtual ICollection<PlannedShift> PlannedShifts { get; set; }

    public virtual ICollection<WorkedShift> WorkedShifts { get; set; }
    
    public virtual ICollection<UnavailableMoment> UnavailableMoments { get; set; }

    public string FullName()
    {
        return FirstName + (Preposition != null ? " " + Preposition : "") + " " + LastName;
    }
}