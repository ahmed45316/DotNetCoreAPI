using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Common.Dto;

namespace TestCore.Business.Dto
{
    public class EmployeeDto : IEmployeeDto
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
    }
}
