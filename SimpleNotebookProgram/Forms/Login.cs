using Business.Services;
using Repository.DBContext;
using SimpleNotebookProgram.Forms;
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
    public partial class Login : Form
    {
        public static NotebookDBContext _context = new NotebookDBContext();
        NotesMenu notesmenu = new NotesMenu();
        categoriesMenu categoriesMenu = new categoriesMenu();
        UserServices findUser = new(_context);
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameLoginTextBox.Text;
            string userPassword = passwordLoginTextBox.Text;

            var user = findUser.FindUserByLogNameAndPassword(userName, userPassword);

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
    }
}
