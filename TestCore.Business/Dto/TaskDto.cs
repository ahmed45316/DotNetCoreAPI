using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Common.Dto;

namespace TestCore.Business.Dto
{
    public class TaskDto : ITaskDto
    {
        public Guid Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDateRescived { get; set; }
        public bool? TaskFinshed { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
