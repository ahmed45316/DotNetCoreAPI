using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Business.Dto;
using TestCore.Common.Parameters;

namespace TestCore.Business.IWorkBusiness
{
    public interface IUserBusiness
    {
        LoginDto Login(LoginParameters parameters);
        void RegisterUser(UserDto user);
    }
}
