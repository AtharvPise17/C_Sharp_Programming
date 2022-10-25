using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YC_Student_Management_System_3
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
         
            SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=YC_Student_Management_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username =@UName And Password=@Pwd";

            Cmd.Parameters.Add("UName",SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt>0)
            {
                MessageBox.Show("Login Succesfull","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Shared_Class.Username = "Welcome " + tb_Username.Text;
                frm_Add_New_Student obj=new frm_Add_New_Student();
                this.Hide();
                obj.Show();
            }
            else
            {
                lbl_Error.Text=("Invalid Username or Password");
                lbl_Error.ForeColor=Color.Red;
            }
                tb_Password.Clear();
                tb_Username.Clear();

                tb_Password.Enabled = false;
                btn_Submit.Enabled = false;

                tb_Username.Focus();

            Con_Close();
        }
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;
        }
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    } 
}

