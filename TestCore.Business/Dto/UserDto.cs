using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Common.Dto;

namespace TestCore.Business.Dto
{
    public class UserDto : IUserDto
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsBlock { get; set; }
    }
}
