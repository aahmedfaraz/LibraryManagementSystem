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
    public partial class AdminStudent : Form
    {
        public int adminID;
        private string insertStudent = "EXEC InsertStudentsRecord @name,@email,@password,@dept,@sem,@city, @adminID";
        private string updateStudent = "EXEC UpdateStudentRecord @id,@name,@email,@password,@dept,@sem,@city";
        private string deleteStudent = "EXEC DeleteStudentRecord @id";
        public AdminStudent(int adminID)
        {
            InitializeComponent();
            this.adminID = adminID;
        }

        private void resetAll()
        {
            id.Text = "";
            name.Text = "";
            email.Text = "";
            pass.Text = "";
            dept.Text = "";
            smstr.Text = "";
            city.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && email.Text != "" && pass.Text != "" && dept.Text != "" && smstr.Text != "" && city.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(insertStudent, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@name", name.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", pass.Text);
                            command.Parameters.AddWithValue("@dept", dept.Text);
                            command.Parameters.AddWithValue("@sem", Convert.ToInt32(smstr.Text));
                            command.Parameters.AddWithValue("@city", city.Text);
                            command.Parameters.AddWithValue("@adminID", adminID.ToString());
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                resetAll();
                                MessageBox.Show("Student Added");
                            }
                        } catch
                        {
                            MessageBox.Show("Enter data with correct Data type");
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Some credentials are missing");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && name.Text != "" && email.Text != "" && pass.Text != "" && dept.Text != "" && smstr.Text != "" && city.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(updateStudent, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                            command.Parameters.AddWithValue("@name", name.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", pass.Text);
                            command.Parameters.AddWithValue("dept", dept.Text);
                            command.Parameters.AddWithValue("sem", Convert.ToInt32(smstr.Text));
                            command.Parameters.AddWithValue("city", city.Text);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Student with ID:" + id.Text + " is Updated");
                                resetAll();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Enter data with correct Data type");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Some credentials are missing");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(deleteStudent, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Student with ID:" + id.Text + " is Deleted");
                                resetAll();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Enter data with correct Data type");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ID is missing");
            }
        }
    }
}
