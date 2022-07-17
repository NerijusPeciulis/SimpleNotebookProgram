using Business.Services;
using Microsoft.Data.SqlClient;
using Repository.DBContext;
using Repository.Models;
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
    public partial class categoriesMenu : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Server=localhost;Database=NotebookDB;Trusted_Connection=True;");
        SqlCommand sqlcomand;
        SqlDataAdapter sqlDataAdapter;
        notesMenu notesMenu = new notesMenu();

        int Id = 0;
        public categoriesMenu()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Categories", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            dataCategoriesGridView.DataSource = dataTable;
            sqlConnection.Close();
        }
        private void categoriesCreateButton_Click(object sender, EventArgs e)
        {

            if (categoryNameTextBox.Text != "")
            {
                sqlcomand = new SqlCommand("INSERT into Categories (Name) values (@name)", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@name", categoryNameTextBox.Text);
                sqlcomand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                categoryNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            {

                if (Id != 0)
                {
                    sqlcomand = new SqlCommand("DELETE Categories WHERE Id=@Id", sqlConnection);
                    sqlConnection.Open();
                    sqlcomand.Parameters.AddWithValue("@Id", Id);
                    sqlcomand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Data deleted");
                    DisplayData();
                    categoryNameTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
        }

        private void dataCategoriesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataCategoriesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            categoryNameTextBox.Text = dataCategoriesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void editCategoryButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text != "")
            {
                sqlcomand = new SqlCommand("UPDATE Categories SET Name=@name WHERE Id=@Id", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@Id", Id);
                sqlcomand.Parameters.AddWithValue("@name", categoryNameTextBox.Text);
                sqlcomand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                sqlConnection.Close();
                DisplayData();
                categoryNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void goToNotesMenu_Click(object sender, EventArgs e)
        {
            notesMenu.Show();
            this.Hide();
        }
    }
}
