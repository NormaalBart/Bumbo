﻿using System.ComponentModel.DataAnnotations;
using BumboData.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BumboData.Models;

public class Employee : IdentityUser, IEntity<string>
{
    [Required] public string FirstName { get; set; }

    public string? Preposition { get; set; }

    [Required] public string LastName { get; set; }

    [Required] public DateOnly Birthdate { get; set; }

    [Required] public bool Active { get; set; }

    [Required] public string Postalcode { get; set; }

    [Required] public string Housenumber { get; set; }

    public string? Street { get; set; }

    [Required] public DateOnly EmployeeSince { get; set; }

    public string? Function { get; set; }

    public Branch? DefaultBranch { get; set; }

    public int? DefaultBranchId { get; set; }

    public virtual ICollection<Department> AllowedDepartments { get; set; }

    public virtual ICollection<PlannedShift> PlannedShifts { get; set; }

    public virtual ICollection<WorkedShift> WorkedShifts { get; set; }

    public virtual ICollection<UnavailableMoment> UnavailableMoments { get; set; }

    public string FullName()
    {
        return FirstName + (Preposition != null ? " " + Preposition : "") + " " + LastName;
    }
}