using System;
using System.Collections.Generic;
using System.Text;

namespace TestCore.Common.Dto
{
    public interface ITaskDto
    {
         Guid Id { get; set; }
         string TaskTitle { get; set; }
         string TaskDescription { get; set; }
         DateTime TaskDateRescived { get; set; }
         bool? TaskFinshed { get; set; }
         Guid EmployeeId { get; set; }
    }
}
