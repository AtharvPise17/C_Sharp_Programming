using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YC_Student_Management_System_3
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            this.Hide();
            obj.Show();
        }
        private void btn_Search_Student_List_Click_1(object sender, EventArgs e)
        {
            frm_Search_Student_List obj = new frm_Search_Student_List();
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
        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yC_Student_Management_SystemDataSet8.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter5.Fill(this.yC_Student_Management_SystemDataSet8.Student_List);
            lbl_UName.Text = Shared_Class.Username;
        }
    } 
}

    


