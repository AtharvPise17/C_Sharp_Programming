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
    public partial class frm_Search_Student_List : Form
    {
        public frm_Search_Student_List()
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand Cmd = new SqlCommand("Select * From Student_List Where Roll_No = @Rn", Con);
            Cmd.Parameters.Add("@Rn", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader DR = Cmd.ExecuteReader();
           
            if(DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                tb_Mobile_No.Text=DR["Mobile_No"].ToString();
                dtp_DOB.Text=(DR["DOB"].ToString());
                cmb_Course.Text=DR.GetString(DR.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("No Record Found","Invalid Roll Number",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_Roll_No.Clear();
            }
            Con.Close();
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Text = "";
            dtp_DOB.Text = "";
            tb_Mobile_No.Text = "";
            cmb_Course.SelectedIndex = -1;
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Add_New_Student_Click_1(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            this.Hide();
            obj.Show();
        }
        private void btn_View_Student_List_Click_1(object sender, EventArgs e)
        {
            frm_View_Student_List obj = new frm_View_Student_List();
            this.Hide();
            obj.Show();
        }
        private void btn_Log_Out_Click_1(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you sure want to logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                this.Hide();
                obj.Show();
            }
        }
        private void frm_Search_Student_List_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Class.Username;
            tb_Roll_No.Focus();
        }
    }
}

        