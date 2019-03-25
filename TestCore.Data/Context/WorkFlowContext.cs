using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Entities;

namespace TestCore.Data.Context
{
    public class WorkFlowContext:DbContext
    {
        public WorkFlowContext(DbContextOptions<WorkFlowContext> options) : base(options)
        {
            //Database.Migrate();
        }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
    }
}
