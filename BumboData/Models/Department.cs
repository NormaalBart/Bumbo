using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;

namespace BumboData.Models;

public class Department : IEntity
{
    [Required] public string DepartmentName { get; set; }

    public virtual ICollection<Employee> AllowedEmployees { get; set; }

    [Key] public int Id { get; set; }
}