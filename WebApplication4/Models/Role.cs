﻿using System.Collections.Generic;

namespace WebApplication4.Models
{
    public class Role
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public List<Users> Users { get; set; }
    }
}