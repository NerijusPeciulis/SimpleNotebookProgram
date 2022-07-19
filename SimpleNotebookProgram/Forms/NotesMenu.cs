using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleNotebookProgram.Forms
{
    public partial class NotesMenu : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Server=localhost;Database=NotebookDB;Trusted_Connection=True;");
        SqlCommand sqlcomand;
        SqlDataAdapter sqlDataAdapter;
        
        int Id = 0;
        public NotesMenu()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Notes", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            dataNotesGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void createNoteButton_Click(object sender, EventArgs e)
        {
            if (noteNameTextbox.Text != "" && noteDescription.Text != "")
            {
                sqlcomand = new SqlCommand("INSERT into Notes (Name, Description) values (@name,@description)", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@name", noteNameTextbox.Text);
                sqlcomand.Parameters.AddWithValue("@description", noteDescription.Text);
                sqlcomand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                noteNameTextbox.Clear();
                noteDescription.Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void NotesMenu_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                sqlcomand = new SqlCommand("DELETE Notes WHERE Id=@Id", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@Id", Id);
                sqlcomand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Data deleted");
                DisplayData();
                noteNameTextbox.Clear();
                noteDescription.Clear();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dataNotesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataNotesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            noteNameTextbox.Text = dataNotesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            noteDescription.Text = dataNotesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void editNoteButton_Click(object sender, EventArgs e)
        {
            if (noteNameTextbox.Text != "" && noteDescription.Text != "")
            {
                sqlcomand = new SqlCommand("UPDATE Notes SET Name=@name, Description=@description WHERE Id=@Id", sqlConnection);
                sqlConnection.Open();
                sqlcomand.Parameters.AddWithValue("@Id", Id);
                sqlcomand.Parameters.AddWithValue("@name", noteNameTextbox.Text);
                sqlcomand.Parameters.AddWithValue("@description", noteDescription.Text);
                sqlcomand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                sqlConnection.Close();
                DisplayData();
                noteNameTextbox.Clear();
                noteDescription.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void noteSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            sqlcomand = new SqlCommand("SELECT * FROM Notes WHERE Name LIKE '%" + noteSearchTextBox.Text + "%'", sqlConnection);

            sqlcomand.CommandType = CommandType.Text;
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomand))
            {
                using (DataTable dataTable = new DataTable())
                {
                    sqlDataAdapter.Fill(dataTable);
                    dataNotesGridView.DataSource = dataTable;
                }
            }
        }

        private void backToCategoriesMenu_Click(object sender, EventArgs e)
        {
            categoriesMenu categoriesMenu = new categoriesMenu();
            categoriesMenu.Show();
            this.Hide();
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            // One method
            //pictureBox.Image = Properties.Resources.download;

            // Second method you can choose image yourself from files
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox.Image = Image.FromFile(filePath);
        }
    }
}
