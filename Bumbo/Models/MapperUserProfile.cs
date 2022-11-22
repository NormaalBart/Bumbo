using AutoMapper;
using Bumbo.Models.BranchController;
using Bumbo.Models.EmployeeManager;
using Bumbo.Models.EmployeeRoster;
using Bumbo.Models.PrognosisManager;
using Bumbo.Models.RosterManager;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Identity;

namespace Bumbo.Models
{
    public class MapperUserProfile : Profile
    {
        public MapperUserProfile()
        {
            var hasher = new PasswordHasher<Employee>();
            // To use auto mapper, register it here for each model you want to use.
            CreateMap<EmployeeCreateViewModel, Employee>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.NormalizedUserName, opt => opt.MapFrom(src => src.FullName.ToUpper()))
                .ForMember(dest => dest.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()))
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => hasher.HashPassword(null, src.Password)))
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateOnly()))
                .ForMember(dest => dest.EmployeeSince, opt => opt.MapFrom(src => src.EmployeeJoinedCompany.ToDateOnly()));
            CreateMap<Employee, EmployeeCreateViewModel>().ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateTime(new TimeOnly(0, 0, 0)))).ForMember(dest => dest.EmployeeJoinedCompany, opt => opt.MapFrom(src => src.EmployeeSince.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<Employee, EmployeeListItemViewModel>().ForMember(dest => dest.EmployeeJoinedCompany, opt => opt.MapFrom(src => src.EmployeeSince.ToDateTime(new TimeOnly(0,0,0)))).ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<Employee, EmployeeRosterViewModel>();
            CreateMap<Prognosis, PrognosisViewModel>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<PrognosisViewModel, Prognosis>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateOnly()));
            CreateMap<PlannedShift, ShiftViewModel>();
            CreateMap<RosterShiftCreateViewModel, PlannedShift>();
            CreateMap<PlannedShift, RosterShiftCreateViewModel>();
            CreateMap<Branch, BranchViewModel>();
            CreateMap<BranchViewModel, Branch>();

            CreateMap<PlannedShift, EmployeeShiftViewModel>().ForMember(dest => dest.HouseNumber, opt => opt.MapFrom(src => src.Branch.HouseNumber)).ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Branch.Street)).ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Branch.City)).ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DepartmentName));

        }
    }
}
