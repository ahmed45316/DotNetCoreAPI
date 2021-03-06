﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;
using TestCore.Entities;
using TestCore.Entities.Identity;

namespace TestCore.Business.Profiler
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            MappEmployee();
            MappTask();
            MappUser();
        }
        private void MappEmployee()
        {
            CreateMap<Employees, EmployeeDto>().ReverseMap();
            CreateMap<Employees, EmployeeWithTasksDto>().ReverseMap();
        }
        private void MappTask()
        {
            CreateMap<Tasks, TaskDto>().ReverseMap();
        }
        private void MappUser()
        {
            CreateMap<AspNetUser, UserDto>().ReverseMap();
        }
    }
}
