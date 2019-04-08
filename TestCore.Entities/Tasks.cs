﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestCore.Entities
{
    public class Tasks
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string TaskTitle { get; set; }
        [StringLength(500)]
        public string TaskDescription { get; set; }
        public DateTime TaskDateRescived { get; set; }
        public bool? TaskFinshed { get; set; }
        [StringLength(256)]
        public Guid EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employees Employee { get; set; }
    }
}
