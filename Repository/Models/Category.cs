using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes {get; set;}
        [ForeignKey("User")]
        public User UserId { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
