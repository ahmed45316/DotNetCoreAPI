using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;

namespace TestCore.Business.IWorkBusiness
{
    public interface ITaskBusiness
    {
        IEnumerable<TaskDto> GetAll();
        TaskDto Get(string Id);
        void Create(TaskDto data);
        void Update(TaskDto data);
        void Remove(string Id);
    }
}
