using AutoMapper;
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
            CreateMap<EmployeeCreateViewModel, Employee>();
            CreateMap<Employee, EmployeeListItemViewModel>();
            CreateMap<Prognosis, PrognosisViewModel>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateTime(new TimeOnly(0, 0, 0))));
            CreateMap<PrognosisViewModel, Prognosis>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToDateOnly()));
            CreateMap<Employee, EmployeeRosterViewModel>();
            CreateMap<PlannedShift, ShiftViewModel>();
            CreateMap<RosterShiftCreateViewModel, PlannedShift>();
            CreateMap<PlannedShift, RosterShiftCreateViewModel>();
        }
    }
}
