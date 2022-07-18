using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTests
{
    public class UserServicesTests
    {
        [Fact]
        public void CreateNewUser_DataValid_UserCreated()
        {
            string username = "Testinis username";
            string password = "Testinis paswordas";

            User user = new User(username, password);

            Assert.Equal(user.Username, username);
            Assert.Equal(user.Password, password);

        }

        [Fact]
        public void CreateNewUser_DataInvalid_ExceptionThroved()
        {
            string username = "Testinis username";
            string password = "Testinis paswordas";
            

            bool exceptionThrowed = false;

            try
            {
                User user = new User(username, password);
            }
            catch
            {
                exceptionThrowed = true;
            }

            Assert.True(exceptionThrowed);

        }
    }
}
