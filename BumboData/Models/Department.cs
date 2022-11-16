﻿using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class Department
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public String DepartmentName { get; set; }

    public virtual ICollection<Employee> AllowedEmployees { get; set; }
}