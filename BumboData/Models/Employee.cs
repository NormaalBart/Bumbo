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
    /// <summary>
    /// The branch this employee works at.
    /// </summary>
    [Required]
    public Branch DefaultBranch { get; set; }

    [Required]
    public String PostalCode { get; set; }
    [Required]
    public int HouseNumber { get; set; }
    /// <summary>
    /// The date that the employee joined the company.
    /// </summary>
    [Required]
    public DateOnly EmployeeJoinedCompany { get; set; }
    /// <summary>
    /// A very short description on what the employee does.
    /// </summary>
    [Required]
    public String Function { get; set; }


    /// <summary>
    /// The branches that are managed by this employee.
    /// </summary>
    public virtual ICollection<Branch> ManagedBranches { get; set; }
    /// <summary>
    /// The departments that this employee is a part of.
    /// </summary>
    public virtual ICollection<Department> AllowedDepartments { get; set; }
    
    public virtual ICollection<PlannedShift> PlannedShifts { get; set; }

    public virtual ICollection<WorkedShift> WorkedShifts { get; set; }
    
    public virtual ICollection<UnavailableMoment> UnavailableMoments { get; set; }
}