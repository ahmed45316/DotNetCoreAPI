﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestCore.Common.Dto
{
    public interface IUserDto
    {
        string Id { get; set; }
        string EmployeeId { get; set; }
        string UserName { get; set; }
        string NormalizedUserName { get; set; }
        string Email { get; set; }
        string NormalizedEmail { get; set; }
        bool EmailConfirmed { get; set; }
        string PasswordHash { get; set; }
        string SecurityStamp { get; set; }
        string ConcurrencyStamp { get; set; }
        string PhoneNumber { get; set; }
        bool PhoneNumberConfirmed { get; set; }
        bool TwoFactorEnabled { get; set; }
        DateTimeOffset? LockoutEnd { get; set; }
        bool LockoutEnabled { get; set; }
        int AccessFailedCount { get; set; }
        bool IsDeleted { get; set; } 
        bool IsBlock { get; set; } 
    }
}
