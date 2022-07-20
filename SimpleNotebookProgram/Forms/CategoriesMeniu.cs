using Microsoft.Data.SqlClient;
using SimpleNotebookProgram.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleNotebookProgram
{

    public partial class categoriesMenu : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Server=localhost;Database=NotebookDB;Trusted_Connection=True;");
        SqlCommand sqlcomand;
        SqlDataAdapter sqlDataAdapter;
        NotesMenu notesMenu = new NotesMenu();

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
                sqlcomand = new SqlCommand("INSERT into Categories (Name, UserId) values (@name, @userId)", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@name", categoryNameTextBox.Text);
                sqlcomand.Parameters.AddWithValue("@userId", userIdTextBox.Text);
                
                try
                {
                    sqlcomand.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully");
                }
                catch
                {
                    categoriesMenu categoriesMenu = new categoriesMenu();
                    MessageBox.Show("Bad User Id, try again");
                    categoriesMenu.Show();
                    this.Hide();
                }

                sqlConnection.Close();
                DisplayData();
                categoryNameTextBox.Clear();
                userIdTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
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
                userIdTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dataCategoriesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataCategoriesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            categoryNameTextBox.Text = dataCategoriesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            userIdTextBox.Text = dataCategoriesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void editCategoryButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text != "")
            {
                sqlcomand = new SqlCommand("UPDATE Categories SET Name=@name, UserId=@userId WHERE Id=@Id", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@Id", Id);
                sqlcomand.Parameters.AddWithValue("@name", categoryNameTextBox.Text);
                sqlcomand.Parameters.AddWithValue("@userId", userIdTextBox.Text);
                sqlcomand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                sqlConnection.Close();
                DisplayData();
                categoryNameTextBox.Clear();
                userIdTextBox.Clear();
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
