﻿using System;

namespace ASPNetDocker.Models
{
    public class User
    {
        public Guid? Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
