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

        //private IUserServices _userServices { get; }

        //private NotebookDBContext _context;
        //public UserServices(NotebookDBContext context)
        //{
        //    _context = context;
        //}
        

        public static NotebookDBContext _context = new NotebookDBContext();
        UserServices addUser = new(_context);
        public registerForm()
        {
            //NotebookDBContext notebookDBContext = new NotebookDBContext();
            //_userServices = new UserServices(notebookDBContext);

            InitializeComponent();
        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;



            addUser.CreateNewUser(username, password);
            MessageBox.Show("Account created succsesfully");
            this.Hide();
           // _context.SaveChanges();

           /* string name = nameTextBox.Text;
            string surName = surNameTextBox.Text;
            string enteredLogName = logInNameTextBox.Text;
            List<User> userLogInNames = findData.FindUserByLogInName(enteredLogName);
            string logInName = "";
            if (userLogInNames.Count == 0)
            {
                logInName = logInNameTextBox.Text;
                string logInPassword = passwordTextBox.Text;
                addData.AddNewUser(name, surName, logInName, logInPassword);
                MessageBox.Show("Account created succsesfully");
                nameTextBox.Clear();
                surNameTextBox.Clear();
                logInNameTextBox.Clear();
                passwordTextBox.Clear();
            }
            else
            {
                logInNameTextBox.Clear();
                MessageBox.Show("This user name is taken, please enter new one and try again.");
            }*/
        }

        private void clearRegisterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
