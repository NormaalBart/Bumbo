﻿namespace Bumbo.Models.EmployeeManager
{
    public class EmployeeListIndexViewModel
    {
        public List<EmployeeListItemViewModel> Employees { get; set; }
        public string CurrentSort { get; set; }
        public string NameSortParm { get; set; }
        public string FunctionSortParm { get; set; }
        public string RegionSortParm { get; set; }
        public string StatusSortParm { get; set; }
        public string CurrentFilter { get; set; }
        public string SearchString { get; set; }
        public int? PageNumber { get; set; }


        public EmployeeListIndexViewModel()
        {
            Employees = new List<EmployeeListItemViewModel>();
        }
            
    }
}
