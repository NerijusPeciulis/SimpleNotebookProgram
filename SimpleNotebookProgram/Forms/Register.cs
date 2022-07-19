using Business.Services;
using Repository.DBContext;
using System;
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
            Login login = new Login();
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            addUser.CreateNewUser(username, password);
            MessageBox.Show("Account created succsesfully");
            login.Show();
            this.Hide();
        }

        private void clearRegisterButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
