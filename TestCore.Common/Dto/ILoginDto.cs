using System;
using System.Collections.Generic;
using System.Text;

namespace TestCore.Common.Dto
{
    public interface ILoginDto
    {
         bool CanLogin { get; set; }
         string Username { get; set; }
         string UserId { get; set; }
    }
}
