using System;
using System.Collections.Generic;
using System.Text;

namespace TestCore.Common.Parameters
{
    public class LoginParameters
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberLogin { get; set; }
    }
}
