﻿using AutoMapper;
using Bumbo.Models.BranchController;
using Bumbo.Models.EmployeeManager.Employee;
using Bumbo.Models.EmployeeManager.Index;
using Bumbo.Models.EmployeeManager.Manager;
using Bumbo.Models.EmployeeRoster;
using Bumbo.Models.PrognosisManager;
using Bumbo.Models.RosterManager;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Import;
using Microsoft.AspNetCore.Identity;

namespace Bumbo.Models
{
    public class MapperUserProfile : Profile
    {
        public MapperUserProfile()
        {
            var hasher = new PasswordHasher<Employee>();
            // To use auto mapper, register it here for each model you want to use.
            CreateMap<EmployeeEditViewModel, Employee>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.EmployeeKey))
                .ForMember(dest => dest.NormalizedUserName, opt => opt.MapFrom(src => src.FullName.ToUpper()))
                .ForMember(dest => dest.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()))
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateOnly()))
                .ForMember(dest => dest.EmployeeSince, opt => opt.MapFrom(src => src.EmployeeJoinedCompany.ToDateOnly()))
                .ForMember(dest => dest.AllowedDepartments, opt => opt.MapFrom(src => src.EmployeeSelectedDepartments));
            CreateMap<Employee, EmployeeEditViewModel>()
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateTime(new TimeOnly(0, 0, 0))))
                .ForMember(dest => dest.EmployeeJoinedCompany, opt => opt.MapFrom(src => src.EmployeeSince.ToDateTime(new TimeOnly(0, 0, 0))))
                .ForMember(dest => dest.EmployeeKey, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.EmployeeSelectedDepartments, opt => opt.MapFrom(src => src.AllowedDepartments));
            CreateMap<ManagerEditViewModel, Employee>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.EmployeeKey))
                .ForMember(dest => dest.NormalizedUserName, opt => opt.MapFrom(src => src.FullName.ToUpper()))
                .ForMember(dest => dest.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()))
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateOnly()))
                .ForMember(dest => dest.ManagesBranchId, opt => opt.MapFrom(src => src.SelectedBranch))
                .ForMember(dest => dest.EmployeeSince, opt => opt.MapFrom(src => src.EmployeeJoinedCompany.ToDateOnly()));
            CreateMap<Employee, ManagerEditViewModel>()
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateTime(new TimeOnly(0, 0, 0))))
                .ForMember(dest => dest.EmployeeJoinedCompany, opt => opt.MapFrom(src => src.EmployeeSince.ToDateTime(new TimeOnly(0, 0, 0))))
                .ForMember(dest => dest.EmployeeKey, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.SelectedBranch, opt => opt.MapFrom(src => src.ManagesBranchId))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));
            CreateMap<Employee, EmployeeListItemViewModel>().ForMember(dest => dest.EmployeeJoinedCompany, opt => opt.MapFrom(src => src.EmployeeSince.ToDateTime(new TimeOnly(0, 0, 0)))).ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<Employee, EmployeeRosterViewModel>();
            CreateMap<Prognosis, PrognosisViewModel>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<PrognosisViewModel, Prognosis>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateOnly()));
            CreateMap<Department, EmployeeDepartmentViewModel>()
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.DepartmentName));
            CreateMap<EmployeeDepartmentViewModel, Department>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.DepartmentName));
            CreateMap<PlannedShift, ShiftViewModel>();
            CreateMap<PlannedShift, RosterShiftCreateViewModel>();
            CreateMap<RosterShiftCreateViewModel, PlannedShift>();
            CreateMap<ListIndexBranchViewModel, Branch>();
            CreateMap<Branch, ListIndexBranchViewModel>()
                .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.DefaultEmployees.Count))
                .ForMember(dest => dest.Managers, opt => opt.MapFrom(src => string.Join(", ", src.Managers.Select(model => model.FullName()).OrderBy(str => str).ToList())));

            CreateMap<PlannedShift, EmployeeShiftViewModel>()
                .ForMember(dest => dest.HouseNumber, opt => opt.MapFrom(src => src.Branch.HouseNumber))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Branch.Street))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Branch.City))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DepartmentName));
        }
    }
}
