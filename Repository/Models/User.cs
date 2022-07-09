﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Category> Categories { get; set; }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
