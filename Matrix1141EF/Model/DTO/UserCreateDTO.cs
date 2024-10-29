﻿using Matrix1141EF.Data.Entity;
using System.Collections.Generic;

namespace Matrix1141EF.Model.DTO
{
    public class UserCreateDTO
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Product Product { get; set; }
    }
}
