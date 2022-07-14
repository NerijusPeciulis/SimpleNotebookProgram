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

    public partial class categoriesMenu : Form
    {
        public static NotebookDBContext _context = new NotebookDBContext();
        // CategoryServices addcategory = new(_context);
        CategoryServices categoryServices = new CategoryServices();
        DataTable table = new DataTable("table");
        public categoriesMenu()
        {
            InitializeComponent();
        }

        private void categoriesCreateButton_Click(object sender, EventArgs e)
        {

            string name = categoryNameTextBox.Text;

            categoryServices.CreateNewCategory(name);
            categoryNameTextBox.Clear(); 
            table.Rows.Add(categoryNameTextBox.Text);
            MessageBox.Show("Category created succsesfully");

        }

        private void categoriesMenu_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", Type.GetType("System.String"));
            table.Columns.Add("Name", Type.GetType("System.String"));
            dataCategoriesGridView.DataSource = table;
            CategoryServices categoryServices = new CategoryServices();
            categoryServices.GetAllCategories();
        }
    }
}
