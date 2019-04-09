using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestCore.Entities
{
    public class Employees
    {
        //private readonly ILazyLoader _lazyLoader;
        public Employees()
        {

        }
        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tasks> Tasks { get; set; }
        //private List<Tasks> _tasks;
        //public  List<Tasks> Tasks { get=> _lazyLoader.Load(this, ref _tasks);  set=> _tasks = value;  }
    }
}
