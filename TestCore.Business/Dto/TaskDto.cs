using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Common.Dto;

namespace TestCore.Business.Dto
{
    public class TaskDto : ITaskDto
    {
        public string Id { get; set; }= Guid.NewGuid().ToString();
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDateRescived { get; set; }
        public bool? TaskFinshed { get; set; }
        public string EmployeeId { get; set; }
    }
}
