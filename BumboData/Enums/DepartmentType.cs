using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData.Enums
{
    public class DepartmentType
    {

        public static DepartmentType CASSIERS = new DepartmentType(1, "Kassa");
        public static DepartmentType FRESH = new DepartmentType(2, "Vers");
        public static DepartmentType FILLERS = new DepartmentType(3, "Vullers");

        public int DepartmentId { get; }
        public string Name { get; }

        public string NormalizedName => Name.ToUpper();

        public DepartmentType(int departmentId, string name)
        {
            DepartmentId = departmentId;
            Name = name;
        }
    }
}
