﻿using AutoMapper;
using Bumbo.Models.EmployeeManager;
using Bumbo.Models.PrognosisManager;
using Bumbo.Models.RosterManager;
using Bumbo.Utils;
using BumboData.Models;

namespace Bumbo.Models
{
    public class MapperUserProfile : Profile
    {
        public MapperUserProfile()
        {
            // To use auto mapper, register it here for each model you want to use.
            CreateMap<EmployeeCreateViewModel, Employee>().ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateOnly())).ForMember(dest => dest.EmployeeSince, opt => opt.MapFrom(src => src.EmployeeJoinedCompany.ToDateOnly()));
            CreateMap<Employee, EmployeeListItemViewModel>().ForMember(dest => dest.EmployeeJoinedCompany, opt => opt.MapFrom(src => src.EmployeeSince.ToDateTime(new TimeOnly(0,0,0)))).ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.Birthdate.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<Prognosis, PrognosisViewModel>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<PrognosisViewModel, Prognosis>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateOnly()));
            CreateMap<Employee, EmployeeRosterViewModel>();
            CreateMap<PlannedShift, ShiftViewModel>();
            CreateMap<RosterShiftCreateViewModel, PlannedShift>();
            CreateMap<PlannedShift, RosterShiftCreateViewModel>();
        }
    }
}
