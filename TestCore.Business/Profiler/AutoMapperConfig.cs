using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;
using TestCore.Entities;

namespace TestCore.Business.Profiler
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            MappEmployee();
            MappTask();
        }
        private void MappEmployee()
        {
            CreateMap<Employees, EmployeeDto>().ReverseMap();
        }
        private void MappTask()
        {
            CreateMap<Tasks, TaskDto>().ReverseMap();
        }
    }
}
