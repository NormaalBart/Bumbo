using BumboData.Models;

namespace BumboServices.Roster.Models;

// Stores the departments and their prognosis
public class DepartmentPrognoseSummary
{
    public Dictionary<Department, (int Workers, double Hours)> Dict { get; } = new();

    public bool Exceeds(DepartmentPrognoseSummary sum)
    {
        // Check if the prognosis exceeds the given prognosis
        foreach (var (department, (workers, hours)) in Dict)
        {
            if (!sum.Dict.TryGetValue(department, out var sumValue)) continue;
            if (workers < sumValue.Workers || hours < sumValue.Hours)
            {
                return false;
            }
        }

        return true;
    }

    // With given target prognosis, calculate the difference and check which department has the most difference in hours and workers.
    public Department SuggestNextDepartment(DepartmentPrognoseSummary target)
    {
        // First check if current and target prognoses have the same departments
        if (Dict.Keys.Count != target.Dict.Keys.Count && !Dict.Keys.All(target.Dict.Keys.Contains))
        {
            throw new Exception("Suggesting next department with invalid target or current prognosis");
        };

        // Get the difference between the current and target prognosis
        var diff = new DepartmentPrognoseSummary();
        foreach (var (department, (workers, hours)) in Dict)
        {
            var targetValue = target.Dict[department];
            diff.Dict.Add(department, (targetValue.Workers - workers, targetValue.Hours - hours));
        }
        
        
        return null;
    }
}