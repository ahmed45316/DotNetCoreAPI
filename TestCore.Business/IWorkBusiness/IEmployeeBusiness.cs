﻿using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;

namespace TestCore.Business.IWorkBusiness
{
    public interface IEmployeeBusiness
    {
        IEnumerable<EmployeeDto> GetAll();
        IEnumerable<EmployeeWithTasksDto> GetAllWithTasks();
        EmployeeDto Get(string Id);
        EmployeeWithTasksDto GetWithTasks(string Id);
        void Create(EmployeeDto data);
        void Update(EmployeeDto data);
        void Remove(string Id);
    }
}
