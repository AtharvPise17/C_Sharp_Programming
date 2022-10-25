namespace YC_Student_Management_System_3
{
    partial class frm_View_Student_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Student_List));
            this.btn_Search_Student_List = new System.Windows.Forms.Button();
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentListBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.yC_Student_Management_SystemDataSet6 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet6();
            this.studentListBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.yC_Student_Management_SystemDataSet4 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet4();
            this.studentListBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.yC_Student_Management_SystemDataSet1 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet1();
            this.studentListBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.yC_Student_Management_SystemDataSet = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet();
            this.studentListBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSetTableAdapters.Student_ListTableAdapter();
            this.student_ListTableAdapter1 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet1TableAdapters.Student_ListTableAdapter();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.yC_Student_Management_SystemDataSet3 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet3();
            this.studentListBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter2 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet3TableAdapters.Student_ListTableAdapter();
            this.student_ListTableAdapter3 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet4TableAdapters.Student_ListTableAdapter();
            this.student_ListTableAdapter4 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet6TableAdapters.Student_ListTableAdapter();
            this.yC_Student_Management_SystemDataSet8 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet8();
            this.studentListBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter5 = new YC_Student_Management_System_3.YC_Student_Management_SystemDataSet8TableAdapters.Student_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource9)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search_Student_List
            // 
            this.btn_Search_Student_List.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_List.ForeColor = System.Drawing.Color.Red;
            this.btn_Search_Student_List.Location = new System.Drawing.Point(515, 580);
            this.btn_Search_Student_List.Name = "btn_Search_Student_List";
            this.btn_Search_Student_List.Size = new System.Drawing.Size(403, 55);
            this.btn_Search_Student_List.TabIndex = 2;
            this.btn_Search_Student_List.TabStop = false;
            this.btn_Search_Student_List.Text = "Search Student List";
            this.btn_Search_Student_List.UseVisualStyleBackColor = true;
            this.btn_Search_Student_List.Click += new System.EventHandler(this.btn_Search_Student_List_Click_1);
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.Red;
            this.lbl_View_Student_List.Location = new System.Drawing.Point(99, 70);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(763, 91);
            this.lbl_View_Student_List.TabIndex = 34;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(72, 580);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(369, 55);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.TabStop = false;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(863, 32);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(113, 43);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click_1);
            // 
            // dgv_List
            // 
            this.dgv_List.AllowUserToAddRows = false;
            this.dgv_List.AllowUserToDeleteRows = false;
            this.dgv_List.AutoGenerateColumns = false;
            this.dgv_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_List.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_List.DataSource = this.studentListBindingSource9;
            this.dgv_List.Location = new System.Drawing.Point(37, 182);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_List.RowTemplate.Height = 24;
            this.dgv_List.Size = new System.Drawing.Size(931, 372);
            this.dgv_List.TabIndex = 35;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentListBindingSource8
            // 
            this.studentListBindingSource8.DataMember = "Student_List";
            this.studentListBindingSource8.DataSource = this.yC_Student_Management_SystemDataSet6;
            // 
            // yC_Student_Management_SystemDataSet6
            // 
            this.yC_Student_Management_SystemDataSet6.DataSetName = "YC_Student_Management_SystemDataSet6";
            this.yC_Student_Management_SystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource7
            // 
            this.studentListBindingSource7.DataMember = "Student_List";
            this.studentListBindingSource7.DataSource = this.yC_Student_Management_SystemDataSet4;
            // 
            // yC_Student_Management_SystemDataSet4
            // 
            this.yC_Student_Management_SystemDataSet4.DataSetName = "YC_Student_Management_SystemDataSet4";
            this.yC_Student_Management_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource5
            // 
            this.studentListBindingSource5.DataMember = "Student_List";
            this.studentListBindingSource5.DataSource = this.yC_Student_Management_SystemDataSet1;
            // 
            // yC_Student_Management_SystemDataSet1
            // 
            this.yC_Student_Management_SystemDataSet1.DataSetName = "YC_Student_Management_SystemDataSet1";
            this.yC_Student_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource4
            // 
            this.studentListBindingSource4.DataMember = "Student_List";
            this.studentListBindingSource4.DataSource = this.yC_Student_Management_SystemDataSet;
            // 
            // yC_Student_Management_SystemDataSet
            // 
            this.yC_Student_Management_SystemDataSet.DataSetName = "YC_Student_Management_SystemDataSet";
            this.yC_Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource3
            // 
            this.studentListBindingSource3.DataMember = "Student_List";
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataMember = "Student_List";
            // 
            // studentListBindingSource1
            // 
            this.studentListBindingSource1.DataMember = "Student_List";
            // 
            // studentListBindingSource2
            // 
            this.studentListBindingSource2.DataMember = "Student_List";
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // student_ListTableAdapter1
            // 
            this.student_ListTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.Color.Silver;
            this.lbl_UName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.Black;
            this.lbl_UName.Location = new System.Drawing.Point(12, 9);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(148, 36);
            this.lbl_UName.TabIndex = 78;
            this.lbl_UName.Text = "Welcome ";
            // 
            // yC_Student_Management_SystemDataSet3
            // 
            this.yC_Student_Management_SystemDataSet3.DataSetName = "YC_Student_Management_SystemDataSet3";
            this.yC_Student_Management_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource6
            // 
            this.studentListBindingSource6.DataMember = "Student_List";
            this.studentListBindingSource6.DataSource = this.yC_Student_Management_SystemDataSet3;
            // 
            // student_ListTableAdapter2
            // 
            this.student_ListTableAdapter2.ClearBeforeFill = true;
            // 
            // student_ListTableAdapter3
            // 
            this.student_ListTableAdapter3.ClearBeforeFill = true;
            // 
            // student_ListTableAdapter4
            // 
            this.student_ListTableAdapter4.ClearBeforeFill = true;
            // 
            // yC_Student_Management_SystemDataSet8
            // 
            this.yC_Student_Management_SystemDataSet8.DataSetName = "YC_Student_Management_SystemDataSet8";
            this.yC_Student_Management_SystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource9
            // 
            this.studentListBindingSource9.DataMember = "Student_List";
            this.studentListBindingSource9.DataSource = this.yC_Student_Management_SystemDataSet8;
            // 
            // student_ListTableAdapter5
            // 
            this.student_ListTableAdapter5.ClearBeforeFill = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1026, 666);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_Search_Student_List);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.dgv_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC_Student_Management_SystemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search_Student_List;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private System.Windows.Forms.BindingSource studentListBindingSource1;
        private System.Windows.Forms.BindingSource studentListBindingSource2;
        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.BindingSource studentListBindingSource3;
        private YC_Student_Management_SystemDataSet yC_Student_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource4;
        private YC_Student_Management_SystemDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private YC_Student_Management_SystemDataSet1 yC_Student_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource studentListBindingSource5;
        private YC_Student_Management_SystemDataSet1TableAdapters.Student_ListTableAdapter student_ListTableAdapter1;
        private System.Windows.Forms.Label lbl_UName;
        private YC_Student_Management_SystemDataSet3 yC_Student_Management_SystemDataSet3;
        private System.Windows.Forms.BindingSource studentListBindingSource6;
        private YC_Student_Management_SystemDataSet3TableAdapters.Student_ListTableAdapter student_ListTableAdapter2;
        private YC_Student_Management_SystemDataSet4 yC_Student_Management_SystemDataSet4;
        private System.Windows.Forms.BindingSource studentListBindingSource7;
        private YC_Student_Management_SystemDataSet4TableAdapters.Student_ListTableAdapter student_ListTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private YC_Student_Management_SystemDataSet6 yC_Student_Management_SystemDataSet6;
        private System.Windows.Forms.BindingSource studentListBindingSource8;
        private YC_Student_Management_SystemDataSet6TableAdapters.Student_ListTableAdapter student_ListTableAdapter4;
        private YC_Student_Management_SystemDataSet8 yC_Student_Management_SystemDataSet8;
        private System.Windows.Forms.BindingSource studentListBindingSource9;
        private YC_Student_Management_SystemDataSet8TableAdapters.Student_ListTableAdapter student_ListTableAdapter5;
    }
}