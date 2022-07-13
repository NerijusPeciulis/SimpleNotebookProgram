using Business.Services;
using Repository.DBContext;
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

    public partial class categoriesMenu : Form
    {
        public static NotebookDBContext _context = new NotebookDBContext();
        CategoryServices addcategory = new(_context);

        public categoriesMenu()
        {
            InitializeComponent();
        }

        private void categoriesCreateButton_Click(object sender, EventArgs e)
        {

            string name = categoryNameTextBox.Text;

            addcategory.CreateNewCategory(name);
            categoryNameTextBox.Clear();
            MessageBox.Show("Category created succsesfully");

        }

        private void categoriesListTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
