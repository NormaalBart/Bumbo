using AutoMapper;
using BumboData.Models;
using BumboServices.Import;

namespace BumboServices.Utils;

public class MapperServiceProfile : Profile
{
    public MapperServiceProfile()
    {
        CreateMap<EmployeeCsvModel, Employee>();
        CreateMap<WorkedShiftCsvModel, WorkedShift>()
            .ForMember(dest => dest.StartTime,
                opt => opt.MapFrom(src => new DateTime(src.Date.Year, src.Date.Month, src.Date.Day,
                    src.StartTime.Hour, src.StartTime.Minute, 0)))
            .ForMember(dest => dest.EndTime,
                opt => opt.MapFrom(src => new DateTime(src.Date.Year, src.Date.Month, src.Date.Day,
                    src.EndTime.Hour, src.EndTime.Minute, 0)));
    }
}