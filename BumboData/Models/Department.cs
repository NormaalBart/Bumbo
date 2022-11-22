using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;

namespace BumboData.Models;

public class Department: IEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public String DepartmentName { get; set; }

    public virtual ICollection<Employee> AllowedEmployees { get; set; }
}