using Microsoft.AspNetCore.Mvc;
using System;
using TestCore.Business.Dto;
using TestCore.Business.IWorkBusiness;

namespace TestCore.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness _employeeBusiness;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeBusiness"></param>
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }
        /// <summary>
        /// Get all Employees
        /// </summary>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllEmloyees()
        {
            var res = _employeeBusiness.GetAll();
            return Ok(res);
        }
        /// <summary>
        /// Get Employee
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Get/{Id}")]
        public IActionResult GetEmloyee(Guid Id)
        {
            var res = _employeeBusiness.Get(Id);
            return Ok(res);
        }
        /// <summary>
        /// Add Employee
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        public IActionResult AddEmloyee(EmployeeDto dto)
        {
            var res = _employeeBusiness.Create(dto);
            return Ok(res);
        }
        /// <summary>
        /// update Employee
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        public IActionResult UpdateEmloyee(EmployeeDto dto)
        {
            _employeeBusiness.Update(dto);
            return Ok();
        }
        /// <summary>
        /// Remove Employee
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Remove")]
        public IActionResult RemoveEmloyee(EmployeeDto dto)
        {
            _employeeBusiness.Remove(dto);
            return Ok();
        }
    }
}