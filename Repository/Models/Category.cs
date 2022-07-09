﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes {get; set;}

        public Category(string name)
        {
            Name = name;
        }
    }
}
