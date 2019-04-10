using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestCore.Business.Dto;
using TestCore.Business.IWorkBusiness;

namespace TestCore.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskBusiness _taskBusiness;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskBusiness"></param>
        public TaskController(ITaskBusiness taskBusiness)
        {
            _taskBusiness = taskBusiness;
        }
        /// <summary>
        /// Get all Tasks
        /// </summary>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllTasks()
        {
            var res = _taskBusiness.GetAll();
            return Ok(res);
        }
        /// <summary>
        /// Get Task
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Get/{Id}")]
        public IActionResult GetTask(string Id)
        {
            var res = _taskBusiness.Get(Id);
            return Ok(res);
        }
        /// <summary>
        /// Add Task
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        public IActionResult AddTask(TaskDto dto)
        {
            _taskBusiness.Create(dto);
            return Ok();
        }
        /// <summary>
        /// update Task
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        public IActionResult UpdateTask(TaskDto dto)
        {
            _taskBusiness.Update(dto);
            return Ok();
        }
        /// <summary>
        /// Remove Task
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Remove/{Id}")]
        public IActionResult RemoveTask(string Id)
        {
            _taskBusiness.Remove(Id);
            return Ok();
        }
    }
}