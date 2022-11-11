using AutoMapper;
using Bumbo.Models.EmployeeManager;
using Bumbo.Models.PrognosisManager;
using Bumbo.Models.RosterManager;
using BumboData.Models;
using System.Collections.Generic;

namespace Bumbo.Models
{
    public class MapperUserProfile : Profile
    {
        public MapperUserProfile()
        {
            // To use auto mapper, register it here for each model you want to use.
            CreateMap<EmployeeCreateViewModel, Employee>();
            CreateMap<Employee, EmployeeListItemViewModel>();
            CreateMap<PrognosisViewModel, PrognosisDay>();
            CreateMap<PrognosisDay, PrognosisViewModel>();
            CreateMap<Employee, EmployeeRosterViewModel>();
            CreateMap<PlannedShift, ShiftViewModel>();
            CreateMap<RosterShiftCreateViewModel, PlannedShift>();
            CreateMap<PlannedShift, RosterShiftCreateViewModel>();


        }
    }
}
