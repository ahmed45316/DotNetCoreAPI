using System;
using System.Collections.Generic;
using System.Text;

namespace TestCore.Common.Dto
{
    public interface IEmployeeDto
    {
         Guid Id { get; set; }
         string EmployeeName { get; set; }
    }
}
