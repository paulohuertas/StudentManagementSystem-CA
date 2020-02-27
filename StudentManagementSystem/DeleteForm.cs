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
using System.Configuration;

namespace Student_Management_System
{
    public partial class DeleteForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand sqlCmd;
        DataTable dataTable;

        public DeleteForm()
        {
            InitializeComponent();
            sqlCon.Open();
            this.FetchStudentData();

        }

        private void dg_Delete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FetchStudentData()
        {
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            dataTable = new DataTable();
            sqlCmd = new SqlCommand("SELECT StudentNumber, FirstName, LastName, Email, Phone," +
                "GradLevel, Course FROM tb_Student", sqlCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);
            dataAdapter.Fill(dataTable);
            dg_Delete.DataSource = dataTable;
            dg_Delete.Refresh();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            dg_Delete.AutoGenerateColumns = false;
            this.FetchStudentData();
            int i = 0;
            foreach (DataGridViewColumn dgvc in dg_Delete.Columns)
            {
                i = i + dgvc.Width;
            }
            dg_Delete.Width = i + dg_Delete.RowHeadersWidth + 2;
            dg_Delete.Height = dg_Delete.GetRowDisplayRectangle(dg_Delete.NewRowIndex, true).Bottom + dg_Delete.GetRowDisplayRectangle(dg_Delete.NewRowIndex, false).Height;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int studentNumber;
            
            if(int.TryParse(txt_DeleteStudent.Text, out studentNumber))
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    dataTable = new DataTable();
                    sqlCmd = new SqlCommand("spDeleteRecord", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "Delete");
                    sqlCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if(numRes > 0)
                    {
                        MessageBox.Show("Deleted successfully");
                        this.Refresh();
                        txt_DeleteStudent.Clear();
                        this.FetchStudentData();
                    }
                    else
                    {
                        MessageBox.Show("Please, try again!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error...", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select a record");
            }
            
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            this.Hide();
            addStudent.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editStudent = new EditForm();
            this.Hide();
            editStudent.Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMain formMain = new formMain();
            this.Hide();
            formMain.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_DeleteStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_DeleteStudent_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txt_DeleteStudent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = "Convert(StudentNumber, 'System.String') LIKE '" + txt_DeleteStudent.Text + "%'";
                dg_Delete.DataSource = dv;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}
