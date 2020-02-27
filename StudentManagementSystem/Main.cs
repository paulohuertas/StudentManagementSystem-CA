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
    public partial class formMain : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand sqlCmd;

        public formMain()
        {
            InitializeComponent();
            sqlCon.Open();
            this.FetchStudentDetails();

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            dg_Students.AutoGenerateColumns = false;
            FetchStudentDetails();
            
            int i = 0;
            foreach(DataGridViewColumn dgvc in dg_Students.Columns)
            {
                i = i + dgvc.Width;
            }
            dg_Students.Width = i + dg_Students.RowHeadersWidth + 2;
            dg_Students.Height = dg_Students.GetRowDisplayRectangle(dg_Students.NewRowIndex, true).Bottom + dg_Students.GetRowDisplayRectangle(dg_Students.NewRowIndex, false).Height;
        }

        private void FetchStudentDetails()
        {
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            
            DataTable dataTable = new DataTable();
            sqlCmd = new SqlCommand("SELECT StudentId, FirstName, LastName, StudentNumber, County, Course, GradLevel FROM tb_Student", sqlCon);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
            sqlData.Fill(dataTable);
            dg_Students.DataSource = dataTable;
            dg_Students.Refresh();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm();
            this.Hide();
            studentForm.Show();
        }

        private void dg_Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dg_Students.DataSource = FetchStudentDetails();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DeleteForm delete = new DeleteForm();
                this.Hide();
                delete.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            this.Hide();
            editForm.Show();
        }
    }
}
