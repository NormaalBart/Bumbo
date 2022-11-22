using BumboData.Models;
using BumboServices.Utils;

namespace BumboServices.CAO.Rules;

public interface ICAORule
{
    public bool IsValid(List<PlannedShift> plannedShifts);

    // Returns true or false if the CAO rule applies to the given employee, for example if their age matches.
    public bool AppliesTo(Employee employee);

    public string GetErrorMessage();
}

public abstract class CAORuleAppliesToAge: ICAORule
{
    private readonly Range _range;

    // Range is being used with included start and end values
    public CAORuleAppliesToAge(Range ageRange)
    {
        _range = ageRange;
    }
    
    public bool AppliesTo(Employee employee)
    {
        // Check if age matches range
        return _range.Start.Value >= employee.Birthdate.Age() && 
               employee.Birthdate.Age() <= _range.End.Value;
    }

    public abstract bool IsValid(List<PlannedShift> plannedShifts);
    public abstract string GetErrorMessage();
}