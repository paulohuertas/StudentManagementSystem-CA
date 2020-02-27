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

namespace Student_Management_System
{
    public partial class EditForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand sqlcmd;
        DataTable dt;
        public EditForm()
        {
            InitializeComponent();
            sqlCon.Open();
            this.FetchStudentData();
        }

        private void dg_SearchEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FetchStudentData()
        {
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            dt = new DataTable();
            sqlcmd = new SqlCommand("SELECT StudentNumber, FirstName, LastName, Email, Phone," +
                "AddressLine1, AddressLine2, City, County, GradLevel, Course FROM tb_Student", sqlCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
            dataAdapter.Fill(dt);
            dg_SearchEdit.DataSource = dt;
            dg_SearchEdit.Refresh();

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            dg_SearchEdit.AutoGenerateColumns = false;
            this.FetchStudentData();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            this.Hide();
            addStudent.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteStudent = new DeleteForm();
            this.Hide();
            deleteStudent.Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            this.Hide();
            main.Show();
        }

        private void dg_SearchEdit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {
                try
                {
                    if(sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                    }
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dg_SearchEdit.Rows[index];
                    txt_StudentId.Text = selectedRow.Cells[0].Value.ToString();
                    txt_FirstName.Text = selectedRow.Cells[1].Value.ToString();
                    txt_Surname.Text = selectedRow.Cells[2].Value.ToString();
                    txt_Email.Text = selectedRow.Cells[3].Value.ToString();
                    txt_Phone.Text = selectedRow.Cells[4].Value.ToString();
                    txt_AddressL1.Text = selectedRow.Cells[5].Value.ToString();
                    txt_AddressL2.Text = selectedRow.Cells[6].Value.ToString();
                    txt_City.Text = selectedRow.Cells[7].Value.ToString();
                    cbo_County.Text = selectedRow.Cells[8].Value.ToString();
                    if(selectedRow.Cells[9].Value.Equals("Postgrad"))
                    {
                        rb_Postgrad.Checked = true;
                    }
                    else
                    {
                        rb_Undergrad.Checked = true;
                    }
                    cb_Course.Text = selectedRow.Cells[10].Value.ToString();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Something went wrong", ex.Message);
                }
            }
        }

        private void dg_SearchEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                    }
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dg_SearchEdit.Rows[index];
                    txt_StudentId.Text = selectedRow.Cells[0].Value.ToString();
                    txt_FirstName.Text = selectedRow.Cells[1].Value.ToString();
                    txt_Surname.Text = selectedRow.Cells[2].Value.ToString();
                    txt_Email.Text = selectedRow.Cells[3].Value.ToString();
                    txt_Phone.Text = selectedRow.Cells[4].Value.ToString();
                    txt_AddressL1.Text = selectedRow.Cells[5].Value.ToString();
                    txt_AddressL2.Text = selectedRow.Cells[6].Value.ToString();
                    txt_City.Text = selectedRow.Cells[7].Value.ToString();
                    cbo_County.Text = selectedRow.Cells[8].Value.ToString();
                    if (selectedRow.Cells[9].Value.Equals("Postgrad"))
                    {
                        rb_Postgrad.Checked = true;
                    }
                    else
                    {
                        rb_Undergrad.Checked = true;
                    }
                    cb_Course.Text = selectedRow.Cells[10].Value.ToString();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Something went wrong", ex.Message);
                }
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "Convert(StudentNumber, 'System.String') LIKE '" + txt_Search.Text + "%'";
                dg_SearchEdit.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
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
            else if (txt_StudentId.TextLength > 9)
            {
                MessageBox.Show("Student number must be up to 9 characters length");
                txt_StudentId.Select();
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    SqlCommand sqlCmd = new SqlCommand("spEditStudent", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "Edit");
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
                        sqlCmd.Parameters.AddWithValue("@GradLevel", rb_Undergrad.Text);
                    }
                    sqlCmd.Parameters.AddWithValue("StudentNumber", txt_StudentId.Text.Trim());
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Updated successfully");
                        this.Controls.Clear();
                        this.InitializeComponent();
                        this.Refresh();
                        this.FetchStudentData();
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
                    sqlCon.Close();
                }
            }
        }
    }
}
