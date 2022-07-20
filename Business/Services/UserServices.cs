using Repository.DBContext;
using Repository.Models;
using System.Linq;

namespace Business.Services
{
    public class UserServices 
    {
        private NotebookDBContext _context;
        public UserServices(NotebookDBContext context)
        {
            _context = context;
        }
        public void CreateNewUser(string username, string password)
        {
            User user = new(username, password);

            _context.Add(user);
            _context.SaveChanges();
        }

        public User FindUserByLogNameAndPassword(string username, string password)
        {
            User user = new(username, password);
            var result = _context.Users.
            FirstOrDefault(result => result.Username == username && result.Password == password);
            return user;
        }
    }
}
