using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;
using TestCore.Business.IWorkBusiness;
using TestCore.Entities;
using TestCore.Repositories.UnitOfWork;

namespace TestCore.Business.WorkBusiness
{
    public class TaskBusiness : ITaskBusiness
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<Tasks> _task;
        public TaskBusiness(IMapper mapper, IUnitOfWork<Tasks> task)
        {
            _mapper = mapper;
            _task = task;
        }
        public void Create(TaskDto data)
        {
            var task = _mapper.Map<TaskDto, Tasks>(data);
            _task.Repo.Add(task);
            _task.SaveChanges();
        }

        public TaskDto Get(string Id)
        {
            var data = _task.Repo.FirstOrDefault(q => q.Id == Id);
            var dto = _mapper.Map<Tasks, TaskDto>(data);
            return dto;
        }

        public IEnumerable<TaskDto> GetAll()
        {
            var data = _task.Repo.GetAll();
            var dto = _mapper.Map<IEnumerable<Tasks>, IEnumerable<TaskDto>>(data);
            return dto;
        }

        public void Remove(string Id)
        {
            var task = _task.Repo.FirstOrDefault(q => q.Id.Equals(Id));
            _task.Repo.Remove(task);
            _task.SaveChanges();
        }

        public void Update(TaskDto data)
        {
            var task = _mapper.Map<TaskDto, Tasks>(data);
            _task.Repo.Update(task, task.Id);
            _task.SaveChanges();
        }
    }
}
