namespace BumboData.Enums;

public class DepartmentType
{
    public static readonly DepartmentType Cassiers = new(1, "Kassa");
    public static readonly DepartmentType Fresh = new(2, "Vers");
    public static readonly DepartmentType Fillers = new(3, "Vullers");

    private DepartmentType(int departmentId, string name)
    {
        DepartmentId = departmentId;
        Name = name;
    }

    public int DepartmentId { get; }
    public string Name { get; }

    public string NormalizedName => Name.ToUpper();
}