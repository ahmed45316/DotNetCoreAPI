using IdentityServer4.Events;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCore.Business.Dto;
using TestCore.Business.IWorkBusiness;
using TestCore.Common.Parameters;

namespace TestCore.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userBusiness"></param>
        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public IActionResult AddUser(UserDto dto)
        {
            _userBusiness.RegisterUser(dto);
            return Created("",true);
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("Login")]
        public IActionResult Login(LoginParameters parameters)
        {
             return Ok(_userBusiness.Login(parameters));      
        }
    }
}