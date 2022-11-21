using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData.Enums
{
    public class RoleType
    {

        public static RoleType ADMINISTRATOR = new RoleType("administrator", "Administrator");
        public static RoleType MANAGER = new RoleType("manager", "Manager");
        public static RoleType EMPLOYEE = new RoleType("employee", "Employee");


        public string RoleId { get; }
        public string Name { get; }

        public string NormalizedName => Name.ToUpper();

        public RoleType(string roleId, string name)
        {
            RoleId = roleId;
            Name = name;
        }
    }
}
