using AutoMapper;
using System;
using TestCore.Business.Dto;
using TestCore.Business.Identity;
using TestCore.Business.IWorkBusiness;
using TestCore.Common.Hasher;
using TestCore.Common.Parameters;
using TestCore.Entities.Identity;

namespace TestCore.Business.WorkBusiness
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IMapper _mapper;
        private readonly IIdentityWork<AspNetUser> _user;
        public UserBusiness(IMapper mapper, IIdentityWork<AspNetUser> user)
        {
            _mapper = mapper;
            _user = user;
        }

        public LoginDto Login(LoginParameters parameters)
        {
            var res = new LoginDto();
            var user = _user.Repo.FirstOrDefault(q => q.UserName == parameters.Username);
            if(user==null) { res.CanLogin = false; return res; }
            var isPasswordRight = CreptoHasher.VerifyHashedPassword(user.PasswordHash, parameters.Password);            
            if (!isPasswordRight) { res.CanLogin = false; return res; }
            res.CanLogin = true;
            res.UserId = user.Id;
            res.Username = user.UserName;
            return res;
        }

        public void RegisterUser(UserDto user)
        {
            var userData = _mapper.Map<UserDto,AspNetUser>(user);
            userData.Id = Guid.NewGuid().ToString();
            userData.PasswordHash = CreptoHasher.HashPassword(userData.PasswordHash);
            _user.Repo.Add(userData);
            _user.SaveChanges();
        }
    }
}
