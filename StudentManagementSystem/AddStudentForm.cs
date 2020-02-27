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
using System.Net.Mail;

namespace Student_Management_System
{
    public partial class AddStudentForm : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gradLevel;
            if (string.IsNullOrEmpty(txt_FirstName.Text))
            {
                MessageBox.Show("Enter student first name");
                txt_FirstName.Select();
            }
            else if (string.IsNullOrEmpty(txt_Surname.Text))
            {
                MessageBox.Show("Enter student last name");
                txt_Surname.Select();
            }
            else if (string.IsNullOrEmpty(txt_Email.Text))
            {
               MessageBox.Show("Enter student email");
                txt_Email.Select();
            }
            else if (string.IsNullOrEmpty(txt_Phone.Text))
            {
                MessageBox.Show("Enter student telephone number");
                txt_Phone.Select();
            }
            else if (string.IsNullOrEmpty(txt_AddressL1.Text))
            {
                MessageBox.Show("Enter student address");
                txt_AddressL1.Select();
            }
            else if (string.IsNullOrEmpty(txt_City.Text))
            {
                MessageBox.Show("Enter student city");
                txt_City.Select();
            }
            else if (cbo_County.SelectedIndex <= -1)
            {
                MessageBox.Show("Enter student county");
                cbo_County.Select();
            }
            else if (cb_Course.SelectedIndex <= -1)
            {
                MessageBox.Show("Enter student course");
                cb_Course.Select();
            }
            else if(txt_StudentId.TextLength > 9)
            {
                MessageBox.Show("Student number must be up to 9 characters length");
                txt_StudentId.Select();
            }
            else
            {
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                    {
                        sqlcon.Open();
                    }
                    SqlCommand sqlCmd = new SqlCommand("spAddStudent", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "Save");
                    sqlCmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txt_Surname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txt_Email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone", txt_Phone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AddressLine1", txt_AddressL1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AddressLine2", txt_AddressL2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", txt_City.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@County", cbo_County.SelectedItem.ToString());
                    if (rb_Postgrad.Checked)
                    {
                        sqlCmd.Parameters.AddWithValue("@GradLevel", rb_Postgrad.Text);
                    }
                    else if (rb_Undergrad.Checked)
                    {
                        //gradLevel = rb_Undergrad.ToString();
                        sqlCmd.Parameters.AddWithValue("@GradLevel", rb_Undergrad.Text);
                    }
                    sqlCmd.Parameters.AddWithValue("@Course", cb_Course.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("StudentNumber", txt_StudentId.Text.Trim());
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if(numRes > 0)
                    {
                        MessageBox.Show("Saved successfully");
                        this.Controls.Clear();
                        this.InitializeComponent();
                    }
                    else
                    {
                        MessageBox.Show("Please try again");
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Something went wrong");
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            this.Hide();
            main.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            this.Hide();
            delete.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            this.Hide();
            edit.Show();
        }

        private void modifyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            this.Hide();
            delete.Show();
        }
    }
}
