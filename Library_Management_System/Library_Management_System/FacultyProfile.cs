using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FacultyProfile : Form
    {
        private Faculty faculty;
        public FacultyProfile(int FacultyID, string FacultyName, string FacultyEmail, string FacultyPassword, string FacultyQualification, string FacultyHiredate, string FacultyType)
        {
            InitializeComponent();
            faculty = Faculty.GetFaculty( FacultyID, FacultyName, FacultyEmail, FacultyPassword, FacultyQualification, FacultyHiredate, FacultyType);
            DisplayProfile();
        }
        private void DisplayProfile()
        {
            idLabel.Text = (faculty.FacultyID).ToString();
            nameLabel.Text = faculty.FacultyName;
            emailLabel.Text = faculty.FacultyEmail;
            passLabel.Text = faculty.FacultyPassword;
            qualfctnLabel.Text = faculty.FacultyQualification;
            hrdateLabel.Text = faculty.FacultyHiredate;
            typeLabel.Text = faculty.FacultyType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.faculty = null;
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
