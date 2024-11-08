using AutoMapper;
using HRISbackend.Dto;
using HRISbackend.Models;

namespace HRISbackend.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();

        }
    }
}
