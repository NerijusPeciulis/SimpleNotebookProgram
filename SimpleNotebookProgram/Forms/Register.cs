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

        public static NotebookDBContext _context = new NotebookDBContext();
        UserServices addUser = new(_context);
        public registerForm()
        {
            InitializeComponent();
        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            addUser.CreateNewUser(username, password);
            MessageBox.Show("Account created succsesfully");
            this.Hide();
           
        }

        private void clearRegisterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
