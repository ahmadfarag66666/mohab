namespace MrMohb.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtidEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBaby = new System.Windows.Forms.RadioButton();
            this.rdMaried = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDateState = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtReciep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.txtdaypayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_deleteimg = new System.Windows.Forms.Button();
            this.btn_select_Image_Emp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pic_EMP = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.opfEMP = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EMP)).BeginInit();
            //this.SuspendLayout();
            // 
            // txtidEmp
            // 
            this.txtidEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidEmp.Enabled = false;
            this.txtidEmp.Location = new System.Drawing.Point(770, 17);
            this.txtidEmp.MaxLength = 3000;
            this.txtidEmp.Multiline = true;
            this.txtidEmp.Name = "txtidEmp";
            this.txtidEmp.Size = new System.Drawing.Size(83, 35);
            this.txtidEmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(873, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الموظف:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(852, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم الموظف:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Location = new System.Drawing.Point(492, 67);
            this.txtEmpName.Multiline = true;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(354, 35);
            this.txtEmpName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(852, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاريخ الحالة:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdBaby);
            this.groupBox1.Controls.Add(this.rdMaried);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(481, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الحالة:";
            // 
            // rdBaby
            // 
            this.rdBaby.AutoSize = true;
            this.rdBaby.BackColor = System.Drawing.Color.Gray;
            this.rdBaby.Location = new System.Drawing.Point(104, 20);
            this.rdBaby.Name = "rdBaby";
            this.rdBaby.Size = new System.Drawing.Size(69, 23);
            this.rdBaby.TabIndex = 1;
            this.rdBaby.Text = "مولود";
            this.rdBaby.UseVisualStyleBackColor = false;
            this.rdBaby.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdMaried
            // 
            this.rdMaried.AutoSize = true;
            this.rdMaried.BackColor = System.Drawing.Color.Gray;
            this.rdMaried.Location = new System.Drawing.Point(291, 20);
            this.rdMaried.Name = "rdMaried";
            this.rdMaried.Size = new System.Drawing.Size(57, 23);
            this.rdMaried.TabIndex = 0;
            this.rdMaried.Text = "زواج";
            this.rdMaried.UseVisualStyleBackColor = false;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(718, 238);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(111, 35);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TabStop = false;
            this.txtAmount.Text = "500";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpDateState
            // 
            this.dtpDateState.Location = new System.Drawing.Point(512, 195);
            this.dtpDateState.Name = "dtpDateState";
            this.dtpDateState.Size = new System.Drawing.Size(334, 27);
            this.dtpDateState.TabIndex = 7;
            this.dtpDateState.TabStop = false;
            this.dtpDateState.ValueChanged += new System.EventHandler(this.dtpDateState_ValueChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(852, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "المبلغ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtReciep);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 247);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(12, 135);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(155, 96);
            this.txtNote.TabIndex = 14;
            this.txtNote.TabStop = false;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReciep
            // 
            this.txtReciep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReciep.Location = new System.Drawing.Point(52, 82);
            this.txtReciep.Multiline = true;
            this.txtReciep.Name = "txtReciep";
            this.txtReciep.Size = new System.Drawing.Size(90, 35);
            this.txtReciep.TabIndex = 13;
            this.txtReciep.TabStop = false;
            this.txtReciep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(173, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "ملاحظات:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(167, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "سند قبض:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(52, 29);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(90, 35);
            this.txtCode.TabIndex = 10;
            this.txtCode.TabStop = false;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(167, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "كود الموظف:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txtdaypayment);
            this.grb1.Controls.Add(this.label8);
            this.grb1.Controls.Add(this.btn_deleteimg);
            this.grb1.Controls.Add(this.btn_select_Image_Emp);
            this.grb1.Controls.Add(this.label9);
            this.grb1.Controls.Add(this.pic_EMP);
            this.grb1.Controls.Add(this.groupBox2);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.txtidEmp);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.dtpDateState);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.txtEmpName);
            this.grb1.Controls.Add(this.groupBox1);
            this.grb1.Controls.Add(this.txtAmount);
            this.grb1.Enabled = false;
            this.grb1.Location = new System.Drawing.Point(12, 23);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(1012, 387);
            this.grb1.TabIndex = 11;
            this.grb1.TabStop = false;
            // 
            // txtdaypayment
            // 
            this.txtdaypayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtdaypayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdaypayment.Enabled = false;
            this.txtdaypayment.Location = new System.Drawing.Point(481, 293);
            this.txtdaypayment.Multiline = true;
            this.txtdaypayment.Name = "txtdaypayment";
            this.txtdaypayment.Size = new System.Drawing.Size(354, 35);
            this.txtdaypayment.TabIndex = 59;
            this.txtdaypayment.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(852, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 35);
            this.label8.TabIndex = 58;
            this.label8.Text = "تاريخ السداد:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // btn_deleteimg
            // 
            this.btn_deleteimg.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteimg.ForeColor = System.Drawing.Color.Red;
            this.btn_deleteimg.Location = new System.Drawing.Point(310, 197);
            this.btn_deleteimg.Name = "btn_deleteimg";
            this.btn_deleteimg.Size = new System.Drawing.Size(72, 34);
            this.btn_deleteimg.TabIndex = 57;
            this.btn_deleteimg.Text = "x";
            this.btn_deleteimg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deleteimg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_deleteimg.UseVisualStyleBackColor = true;
            // 
            // btn_select_Image_Emp
            // 
            this.btn_select_Image_Emp.ForeColor = System.Drawing.Color.Black;
            this.btn_select_Image_Emp.Location = new System.Drawing.Point(402, 198);
            this.btn_select_Image_Emp.Name = "btn_select_Image_Emp";
            this.btn_select_Image_Emp.Size = new System.Drawing.Size(54, 34);
            this.btn_select_Image_Emp.TabIndex = 56;
            this.btn_select_Image_Emp.Text = "...";
            this.btn_select_Image_Emp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_select_Image_Emp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_select_Image_Emp.UseVisualStyleBackColor = true;
            this.btn_select_Image_Emp.Click += new System.EventHandler(this.btn_select_Image_Emp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 54;
            this.label9.Text = "صورة الموظف:";
            // 
            // pic_EMP
            // 
            this.pic_EMP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_EMP.Location = new System.Drawing.Point(310, 58);
            this.pic_EMP.Name = "pic_EMP";
            this.pic_EMP.Size = new System.Drawing.Size(146, 133);
            this.pic_EMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EMP.TabIndex = 55;
            this.pic_EMP.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(398, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 42);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "حذف";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(524, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 42);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(650, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 42);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(272, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // opfEMP
            // 
            this.opfEMP.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1029, 505);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grb1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtidEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBaby;
        private System.Windows.Forms.RadioButton rdMaried;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDateState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtReciep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_deleteimg;
        private System.Windows.Forms.Button btn_select_Image_Emp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pic_EMP;
        private System.Windows.Forms.TextBox txtdaypayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog opfEMP;
    }
}

