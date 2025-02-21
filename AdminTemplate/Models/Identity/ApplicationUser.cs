﻿using Microsoft.AspNetCore.Identity;

namespace AdminTemplate.Models.Identity
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime RegisterDate { get; set; }=DateTime.UtcNow;

    }

}

