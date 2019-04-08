using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;
using TestCore.Business.IWorkBusiness;
using TestCore.Business.WorkFlowContextWork;
using TestCore.Entities;
using TestCore.Repositories.UnitOfWork;

namespace TestCore.Business.WorkBusiness
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<Employees> _employee;
        public EmployeeBusiness(IMapper mapper, IUnitOfWork<Employees> employee)
        {
            _mapper = mapper;
            _employee = employee;
        }
        public EmployeeDto Create(EmployeeDto data)
        {
            var emp = _mapper.Map<EmployeeDto, Employees>(data);
            var insert = _employee.Repo.Add(emp);
            _employee.SaveChanges();
            var res= _mapper.Map<Employees, EmployeeDto>(insert);
            return res;
        }

        public EmployeeDto Get(Guid Id)
        {
            var data = _employee.Repo.FirstOrDefault(q=>q.Id==Id);
            var dto = _mapper.Map<Employees, EmployeeDto>(data);
            return dto;
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            var data = _employee.Repo.GetAll();
            var dto = _mapper.Map<IEnumerable<Employees>, IEnumerable<EmployeeDto>>(data);
            return dto;
        }

        public void Remove(EmployeeDto data)
        {
            var emp = _mapper.Map<EmployeeDto, Employees>(data);
             _employee.Repo.Remove(emp);
            _employee.SaveChanges();
        }

        public void Update(EmployeeDto data)
        {
            var emp = _mapper.Map<EmployeeDto, Employees>(data);
            _employee.Repo.Update(emp,emp.Id);
            _employee.SaveChanges();
        }
    }
}
