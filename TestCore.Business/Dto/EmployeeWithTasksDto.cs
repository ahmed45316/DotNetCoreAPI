using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Common.Dto;

namespace TestCore.Business.Dto
{
    public class EmployeeWithTasksDto : IEmployeeDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string EmployeeName { get; set; }
        public List<TaskDto> Tasks { get; set; }
    }
}
