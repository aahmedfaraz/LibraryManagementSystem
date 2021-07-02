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
    public partial class LibrarianProfile : Form
    {
        private string generateReport = "Exec GenerateReport @BookID,@StudentiD,@LibrarianID";
        private Librarian librarian;
        public LibrarianProfile(int id, string name, string email, string password, string city, int salary)
        {
            InitializeComponent();
            librarian = Librarian.GetLibrarian(id, name, email, password, city, salary);
            DisplayProfile();
        }
        private DataTable GenerateReport()
        {
            var dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(generateReport, sqlCon))
                {
                    command.Parameters.AddWithValue("@BookID", book_id.Text);
                    command.Parameters.AddWithValue("@StudentiD", std_id.Text);
                    command.Parameters.AddWithValue("@LibrarianID", librarian.id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        try
                        {
                            adapter.Fill(dataTable);
                            MessageBox.Show("Book of ID:" + book_id.Text + " has been issued to student with ID:" + std_id.Text + ".");
                            std_id.Text = "";
                            book_id.Text = "";
                            return dataTable;
                        }
                        catch
                        {
                            MessageBox.Show("Invalid Credentials");
                            std_id.Text = "";
                            book_id.Text = "";
                            return dataTable;
                        }
                    }
                }
            }
        }
        private void DisplayProfile()
        {
            id.Text = (librarian.id).ToString();
            name.Text = librarian.name;
            email.Text = librarian.email;
            pass.Text = librarian.password;
            city.Text = librarian.city;
            salary.Text = (librarian.salary).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.librarian = null;
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(std_id.Text != "" && book_id.Text != "")
            {
                GenerateReport();
            } else
            {
                MessageBox.Show("Some Credentials are missing");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.ShowDialog();
        }
    }
}
