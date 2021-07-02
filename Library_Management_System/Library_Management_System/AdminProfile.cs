using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminProfile : Form
    {
        private string getStudents = "select * from Students";
        private string getAdmins = "select * from Admins";
        private string getLibrarians = "select * from Librarians";
        private string getFaculty = "select * from Faculty";
        private string getBooks = "select * from Books";
        private Admin admin;
        public AdminProfile(int id, string name, string email, string password, string designation, string hiredate, string retiredate)
        {
            InitializeComponent();
            admin = Admin.GetAdmin(id, name, email, password, designation, hiredate, retiredate);
            DisplayProfile();
        }
        private void DisplayProfile()
        {
            idLabel.Text = (admin.id).ToString();
            nameLabel.Text = admin.name;
            emailLabel.Text = admin.email;
            passLabel.Text = admin.password;
            dsgntnLabel.Text = admin.designation;
            hrdateLabel.Text = admin.hiredate;
            rtrdateLabel.Text = admin.retiredate;
        }

        private DataTable getTable(string query)
        {
            var dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getAdmins);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getStudents);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getLibrarians);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getFaculty);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getBooks);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdminBook form = new AdminBook();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.admin = null;
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
    }
}
