using AutoMapper;
using System.Collections.Generic;
using TestCore.Business.Dto;
using TestCore.Business.IWorkBusiness;
using TestCore.Business.WorkFlowContextWork;
using TestCore.Entities;

namespace TestCore.Business.WorkBusiness
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IMapper _mapper;
        private readonly IWorkFlow<Employees> _employee;
        public EmployeeBusiness(IMapper mapper, IWorkFlow<Employees> employee)
        {
            _mapper = mapper;
            _employee = employee;
        }
        public void Create(EmployeeDto data)
        {
            var emp = _mapper.Map<EmployeeDto, Employees>(data);
            _employee.Repo.Add(emp);
            _employee.SaveChanges();
        }

        public EmployeeDto Get(string Id)
        {
            var data = _employee.Repo.FirstOrDefault(q => q.Id == Id);
            var dto = _mapper.Map<Employees, EmployeeDto>(data);
            return dto;
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            var data = _employee.Repo.GetAll();
            var dto = _mapper.Map<IEnumerable<Employees>, IEnumerable<EmployeeDto>>(data);
            return dto;
        }

        public IEnumerable<EmployeeWithTasksDto> GetAllWithTasks()
        {
            var data = _employee.Repo.GetAll(q=>q.Tasks);
            var dto = _mapper.Map<IEnumerable<Employees>, IEnumerable<EmployeeWithTasksDto>>(data);
            return dto;
        }

        public EmployeeWithTasksDto GetWithTasks(string Id)
        {
            var data = _employee.Repo.FirstOrDefault(q => q.Id == Id,q=>q.Tasks);
            var dto = _mapper.Map<Employees, EmployeeWithTasksDto>(data);
            return dto;
        }

        public void Remove(string Id)
        {
            var emp = _employee.Repo.FirstOrDefault(q => q.Id.Equals(Id),q=>q.Tasks);
            _employee.Repo.Remove(emp);
            _employee.SaveChanges();

        }

        public void Update(EmployeeDto data)
        {
            var emp = _mapper.Map<EmployeeDto, Employees>(data);
            _employee.Repo.Update(emp, emp.Id);
            _employee.SaveChanges();
        }
    }
}
