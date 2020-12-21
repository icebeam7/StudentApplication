using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StudentApplication
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection dbConnection;

        bool IsConnected => (dbConnection != null && dbConnection.State == ConnectionState.Open); 

        void LoadStudents(string search = "")
        {
            if (IsConnected)
            {
                string sql = "Select * From Student ";
                sql += search;

                SqlCommand command = new SqlCommand(sql, dbConnection);
                SqlDataReader reader = command.ExecuteReader();

                //if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvStudents.DataSource = dt;
                }

                reader.Close();
                command.Dispose();
            }
        }

        public Form1()
        {
            InitializeComponent();

            connectionString = "Server=devvm1701\\SQLEXPRESS;Database=UTB_DB;User Id=utbus3r;Password=myP@$$w0rd;";
            LoadFilters();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            MessageBox.Show("Connection was successful", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudents();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                dbConnection.Close();
                dgvStudents.DataSource = null;
                MessageBox.Show("Disconnected");
            }
            else
            {
                MessageBox.Show("There is no connection to the database");
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudents.SelectedRows[0];

                EntryID.Text = row.Cells[0].Value.ToString();
                EntryFirstName.Text = row.Cells[1].Value.ToString();
                EntryLastName.Text = row.Cells[2].Value.ToString();
                EntryAge.Value = int.Parse(row.Cells[3].Value.ToString());
                EntryBirthNumber.Text = row.Cells[4].Value.ToString();
                EntryGrade.Value = decimal.Parse(row.Cells[5].Value.ToString());
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                string id = EntryID.Text;
                string firstName = EntryFirstName.Text;
                string lastName = EntryLastName.Text;
                string birthNumber = EntryBirthNumber.Text;
                int age = (int)EntryAge.Value;
                float grade = (float)EntryGrade.Value;

                string sql = $"insert into Student values ('{id}', '{firstName}', '{lastName}', {age}, '{birthNumber}', {grade}, NULL)";
                SqlCommand command = new SqlCommand(sql, dbConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                adapter.Dispose();
                command.Dispose();

                LoadStudents();

                MessageBox.Show("Student was added into the database", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            if (IsConnected && dgvStudents.SelectedRows.Count > 0)
            {
                string id = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();
                string firstName = EntryFirstName.Text;
                string lastName = EntryLastName.Text;
                string birthNumber = EntryBirthNumber.Text;
                int age = (int)EntryAge.Value;
                float grade = (float)EntryGrade.Value;

                string sql = $"update student set FirstName = '{firstName}', LastName = '{lastName}', Age = {age}, BirthNumber = '{birthNumber}', AvgGrade = {grade} where StudentID = '{id}'";
                SqlCommand command = new SqlCommand(sql, dbConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();

                adapter.Dispose();
                command.Dispose();

                LoadStudents();

                MessageBox.Show("Student was updated in the database", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (IsConnected && dgvStudents.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you really want to delete the student information?", 
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();

                    string sql = $"delete from student where StudentID = '{id}'";
                    SqlCommand command = new SqlCommand(sql, dbConnection);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    adapter.Dispose();
                    command.Dispose();

                    LoadStudents();

                    MessageBox.Show("Student was removed from the database", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void LoadFilters()
        {
            FilterComboBox.Items.Add("ID");
            FilterComboBox.Items.Add("Last Name");
            FilterComboBox.Items.Add("Grade");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string filter = FilterComboBox.Text;
            string query = string.Empty; // WHERE ???? = ????
            string searchTerm = EntrySearchTerm.Text;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                switch (filter)
                {
                    case "ID":
                        query = $"where StudentID = '{searchTerm}'";
                        break;
                    case "Last Name":
                        query = $"where LastName = '{searchTerm}'";
                        break;
                    case "Grade":
                        query = $"where AvgGrade = {searchTerm}";
                        break;
                }
            }

            LoadStudents(query);
        }
    }
}
