using Business.Services;
using Microsoft.Data.SqlClient;
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
        public static NotebookDBContext context = new NotebookDBContext();
        CategoryServices addcategory = new(context);
        CategoryServices categoryServices = new CategoryServices();

        string connectionString = "Server=localhost;Database=NotebookDB;Trusted_Connection=True;";
        public categoriesMenu()
        {
            InitializeComponent();
        }

        private void categoriesCreateButton_Click(object sender, EventArgs e)
        {
            string name = categoryNameTextBox.Text;

            addcategory.CreateNewCategory(name);
            MessageBox.Show("Category created succsesfully");
            categoryNameTextBox.Clear();

            // rodymas gridwiev
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Categories", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataCategoriesGridView.DataSource = dataTable;
            }

        }

        private void categoriesMenu_load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Categories", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataCategoriesGridView.DataSource = dataTable;
            }

        }
    }
}
