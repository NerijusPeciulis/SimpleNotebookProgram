using Business.Interfaces;
using Repository.DBContext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserServices //: IUserServices
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

        public User FindUserByLogNameAndPassword(string userName, string userPassword)
        {
            var user = _context.Users.
            FirstOrDefault(user => user.Username == userName && user.Password == userPassword);
            return user;
        }
    }
}
