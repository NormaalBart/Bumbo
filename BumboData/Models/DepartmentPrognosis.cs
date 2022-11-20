using System.ComponentModel.DataAnnotations;

namespace BumboData.Models;

public class DepartmentPrognosis
{
    [Key] 
    public int Id { get; set; }
    
    [Required]
    public Department Department { get; set; }
    
    [Required]
    public Prognosis Prognosis { get; set; }

    public int RequiredEmployees { get; set; }

    [Required]
    public int RequiredHours { get; set; }
}