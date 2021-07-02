using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        private const string FindStudent = "EXEC GetStudent @email,@password";
        private const string FindAdmin = "EXEC GetAdmin @email,@password";
        private const string FindLibrarian = "EXEC GetLibrarian @email,@password";
        private const string FindFaculty = "EXEC GetFaculty @email,@password";
        public Login()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '*';
        }

        // Event listener to verify User on click Login Button
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameInput.Text.Trim() != "" && passwordInput.Text.Trim() != "")
            {
                string expectedPerson = studentRadio.Checked ? "student" : adminRadio.Checked ? "admin" : librarianRadio.Checked ? "librarian" : "faculty";
                string query = "";
                switch (expectedPerson)
                {
                    case "student":
                        query = FindStudent;
                        break;
                    case "admin":
                        query = FindAdmin;
                        break;
                    case "librarian":
                        query = FindLibrarian;
                        break;
                    case "faculty":
                        query = FindFaculty;
                        break;
                }
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@email", usernameInput.Text);
                        command.Parameters.AddWithValue("@password", passwordInput.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                            if(dataTable.Rows.Count > 0)
                            {
                                DataRow row = dataTable.Rows[0];
                                this.Hide();
                                switch (expectedPerson)
                                {
                                    case "student":
                                        StudentProfile studentProf = new StudentProfile(Convert.ToInt32(row["StudentID"]), row["StudentName"].ToString(), row["StudentEmail"].ToString(), row["StudentPassword"].ToString(), row["StudentDepartment"].ToString(), row["StudentSemester"].ToString(), row["StudentCity"].ToString());
                                        studentProf.ShowDialog();
                                        break;
                                    case "admin":
                                        AdminProfile adminProf = new AdminProfile(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString(), row["AdminEmail"].ToString(), row["AdminPassword"].ToString(), row["AdminDesignation"].ToString(), row["AdminHiredate"].ToString(), row["AdminRetiredate"].ToString());
                                        adminProf.ShowDialog();
                                        break;
                                    case "librarian":
                                        LibrarianProfile libProf = new LibrarianProfile(Convert.ToInt32(row["LibrarianID"]), row["LibrarianName"].ToString(), row["LibrarianEmail"].ToString(), row["LibrarianPassword"].ToString(), row["LibrarianCity"].ToString(), Convert.ToInt32(row["LibrarianSalary"]));
                                        libProf.ShowDialog();
                                        break;
                                    case "faculty":
                                        FacultyProfile facultyProf = new FacultyProfile(Convert.ToInt32(row["FacultyID"]), row["FacultyName"].ToString(), row["FacultyEmail"].ToString(), row["FacultyPassword"].ToString(), row["FacultyQualification"].ToString(), row["FacultyHiredate"].ToString(), row["FacultyType"].ToString());
                                        facultyProf.ShowDialog();
                                        break;
                                    default:
                                        // do nothing
                                        MessageBox.Show("Person Not found");
                                        break;
                                }
                                this.Close();
                            } else
                            {
                                MessageBox.Show("Incorrect Username or Password.");
                            }
                        }
                    }
                }

            } else
            {
                MessageBox.Show("Some credentials are missing.");
            }

        }
    }
}
