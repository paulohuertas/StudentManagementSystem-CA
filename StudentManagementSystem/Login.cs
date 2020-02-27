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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataTable tb_Login = new DataTable();
            string query = "Select * From tb_Login WHERE UserName = '" + txtUsername.Text.Trim() + "' and UserPassword = '" + txtPassword.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(tb_Login);
           
            if (tb_Login.Rows.Count == 1)
            {
                formMain objFormMain = new formMain();
                this.Hide();
                objFormMain.Show();
                sqlCon.Close();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
