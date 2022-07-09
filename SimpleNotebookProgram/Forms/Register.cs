using Business.Interfaces;
using Business.Services;
using Repository.DBContext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotebookProgram
{
    public partial class registerForm : Form
    {
        private IUserServices _userServices { get; }
        
        public registerForm()
        {
            NotebookDBContext notebookDBContext = new NotebookDBContext();
            _userServices = new UserServices(notebookDBContext);

            InitializeComponent();
        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            User user = new User(userName, password);
            _userServices.CreateNewUser(userName, password);
        }
    }
}
