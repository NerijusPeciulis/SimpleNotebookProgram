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
    public class UserServices : IUserServices
    {
        private NotebookDBContext _context;
        public UserServices(NotebookDBContext context)
        {
            _context = context;
        }
        public void CreateNewUser(string userName, string password)
        {
            User user = new User(userName, password)
            {
                _context.Add(user);
            _context.SaveChanges();


            }
        }
    }
}
