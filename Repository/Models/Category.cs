using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes {get; set;}
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        public Category(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }
    }
}
