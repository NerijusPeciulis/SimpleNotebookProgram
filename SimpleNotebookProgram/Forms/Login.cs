using Business.Services;
using Repository.DBContext;
using SimpleNotebookProgram.Forms;
using System;
using System.Windows.Forms;

namespace SimpleNotebookProgram
{
    public partial class Login : Form
    {
        public static NotebookDBContext _context = new NotebookDBContext();
        NotesMenu notesmenu = new NotesMenu();
        categoriesMenu categoriesMenu = new categoriesMenu();
        registerForm registerForm = new registerForm();
        UserServices findUser = new(_context);
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameLoginTextBox.Text;
            string password = passwordLoginTextBox.Text;

            var user = findUser.FindUserByLogNameAndPassword(username, password);

            if (user == null)
            {
                MessageBox.Show("User name or password is incorrect, please try again.");
                userNameLoginTextBox.Clear();
                passwordLoginTextBox.Clear();
            }
            else
            {
                categoriesMenu.Show();
                this.Hide();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameLoginTextBox.Clear();
            passwordLoginTextBox.Clear();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            this.Hide();
        }
    }
}
