namespace BumboServices.Roster.Models;

// Stores the departments and their prognosis
public class DepartmentPrognoseSummary
{
    // Department id, and workers in that department
    public Dictionary<int, (int Workers, double Hours)> Dict { get; } = new();

    public bool Exceeds(DepartmentPrognoseSummary sum)
    {
        // Check if the prognosis exceeds the given prognosis
        foreach (var (department, (workers, hours)) in Dict)
        {
            if (!sum.Dict.TryGetValue(department, out var sumValue)) continue;
            if (workers < sumValue.Workers || hours < sumValue.Hours) return false;
        }

        return true;
    }

    // With given target prognosis, calculate the difference and check which department has the most difference in hours and workers.
    public int SuggestNextDepartmentId(DepartmentPrognoseSummary target)
    {
        // First check if current and target prognoses have the same departments
        if (Dict.Keys.Count != target.Dict.Keys.Count && !Dict.Keys.All(target.Dict.Keys.Contains))
            throw new Exception("Suggesting next department with invalid target or current prognosis");
        ;

        // Get the difference between the current and target prognosis
        var diff = new DepartmentPrognoseSummary();
        foreach (var (department, (workers, hours)) in Dict)
        {
            var targetValue = target.Dict[department];
            diff.Dict.Add(department,
                (targetValue.Workers == -1 ? 0 : targetValue.Workers - workers, targetValue.Hours - hours));
        }

        return diff.Dict.Select(d => (d.Key, d.Value))
            .OrderByDescending(d => d.Value.Hours)
            .ThenByDescending(d => d.Value.Workers).ToList().First().Key;
    }

    public bool DepartmentStillRequiresWork(int departmentId, DepartmentPrognoseSummary target)
    {
        if (!Dict.ContainsKey(departmentId)) return false;

        return Dict[departmentId].Hours < target.Dict[departmentId].Hours ||
               Dict[departmentId].Workers < target.Dict[departmentId].Workers;
    }
}