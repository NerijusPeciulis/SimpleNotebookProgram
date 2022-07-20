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

            var users = _context.Users.
               FirstOrDefault(users => users.Username == username && users.Password == password);
        }

        public User FindUserByLogNameAndPassword(string username, string password)
        {
            var users = _context.Users.
            FirstOrDefault(users => users.Username == username && users.Password == password);
            return users;
        }
    }
}
