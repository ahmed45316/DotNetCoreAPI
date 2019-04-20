using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Common.Dto;

namespace TestCore.Business.Dto
{
    public class LoginDto : ILoginDto
    {
        public bool CanLogin { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
    }
}
