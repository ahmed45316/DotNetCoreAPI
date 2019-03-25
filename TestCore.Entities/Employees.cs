using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestCore.Entities
{
    public class Employees
    {
        private readonly ILazyLoader _lazyLoader;
        public Employees()
        {

        }
        [Key]
        [StringLength(256)]
        public string Id { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        private  List<Tasks> _tasks;
        public  List<Tasks> Tasks { get=> _lazyLoader.Load(this, ref _tasks);  set=> _tasks = value;  }
    }
}
