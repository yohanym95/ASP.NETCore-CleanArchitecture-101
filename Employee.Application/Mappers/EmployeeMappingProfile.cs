﻿using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;

namespace Employee.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee.Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
            CreateMap<Employee.Core.Entities.Employee, UpdateEmployeeCommand>().ReverseMap();
        }
    }
}
