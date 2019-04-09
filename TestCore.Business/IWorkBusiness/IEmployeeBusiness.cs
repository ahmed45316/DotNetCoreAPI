using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;

namespace TestCore.Business.IWorkBusiness
{
    public interface IEmployeeBusiness
    {
        IEnumerable<EmployeeDto> GetAll();
        EmployeeDto Get(string Id);
        EmployeeDto Create(EmployeeDto data);
        void Update(EmployeeDto data);
        void Remove(EmployeeDto data);
    }
}
