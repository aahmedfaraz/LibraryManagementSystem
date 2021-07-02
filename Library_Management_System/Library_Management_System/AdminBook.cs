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
    public partial class AdminBook : Form
    {
        private string addBook = "Exec AddBook @title,@price,@author,@edition,@copies";
        private string updateBook = "Exec UpdateBook @id,@title,@price,@author,@edition,@copies";
        private string deleteBook = "Exec DeleteBook @id";
        public AdminBook()
        {
            InitializeComponent();
        }

        private void resetAll()
        {
            id.Text = "";
            title.Text = "";
            author.Text = "";
            price.Text = "";
            edition.Text = "";
            copies.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (title.Text != "" && author.Text != "" && price.Text != "" && edition.Text != "" && copies.Text != "" )
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(addBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@title", title.Text);
                            command.Parameters.AddWithValue("@author", author.Text);
                            command.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text));
                            command.Parameters.AddWithValue("@edition", edition.Text);
                            command.Parameters.AddWithValue("@copies", Convert.ToInt32(copies.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                resetAll();
                                MessageBox.Show("Book Added");
                            }
                        } catch
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && title.Text != "" && author.Text != "" && price.Text != "" && edition.Text != "" && copies.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-AHMED\\FARAZSQLSERVER;Initial Catalog=LibraryDatabase;Integrated Security=True"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(updateBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                            command.Parameters.AddWithValue("@title", title.Text);
                            command.Parameters.AddWithValue("@author", author.Text);
                            command.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text));
                            command.Parameters.AddWithValue("@edition", edition.Text);
                            command.Parameters.AddWithValue("@copies", Convert.ToInt32(copies.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Book with ID:" + id.Text + " is Updated");
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
                    using (SqlCommand command = new SqlCommand(deleteBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Book with ID:" + id.Text + " is Deleted");
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
    }
}
