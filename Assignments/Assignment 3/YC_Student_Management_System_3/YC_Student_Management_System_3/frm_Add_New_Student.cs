using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YC_Student_Management_System_3
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
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
        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            dtp_DOB.Text = "";
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
        }
        int Auto_Incr()
        {
            int cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Student_List";

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No) From Student_List";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 1;
            }

            Con_Close();
            return cnt;
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Student_List(Roll_No,Name,DOB,Mobile_No,Course) Values(@Rn,@Nm,@Dob,@Mn,@Course) ";

                Cmd.Parameters.Add("Rn", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mn", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successful", "Succcessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First fill all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Roll_No.Clear();
            }

            Con_Close();
        }
        private void frm_Add_New_Student_Load_1(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Class.Username;
            Clear_Controls();
            tb_Roll_No.Focus();
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
    }
}
       