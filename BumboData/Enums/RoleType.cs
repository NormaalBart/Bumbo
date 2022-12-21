namespace BumboData.Enums;

public class RoleType
{
    public static RoleType ADMINISTRATOR = new("administrator", "Administrator");
    public static RoleType MANAGER = new("manager", "Manager");
    public static RoleType EMPLOYEE = new("employee", "Employee");

    public RoleType(string roleId, string name)
    {
        RoleId = roleId;
        Name = name;
    }

    public string RoleId { get; }
    public string Name { get; }

    public string NormalizedName => Name.ToUpper();
}