using System.Collections.Generic;

namespace Repository.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Category> Categories { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
