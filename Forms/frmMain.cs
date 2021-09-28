using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MrMohb.Forms
{
    public partial class frmMain : Form
    {
        string State;//1

        MrMohb.PL.CLsMain ob = new PL.CLsMain();//2
        DataTable dt = new DataTable();//2

        Boolean add_update;
        public frmMain()
        {
            InitializeComponent();
            //dt = ob.maxid();
            //txtidEmp.Text = dt.Rows[0][0].ToString();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void cleareTXT()
    {
        txtidEmp.Clear();
        txtEmpName.Clear();
        txtAmount.Text ="500";


    }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_update = true;
            grb1.Enabled = true;
            cleareTXT();
            dt = ob.maxid();
            txtidEmp.Text = dt.Rows[0][0].ToString();

            txtEmpName.Focus();
            btnSave.Enabled = true;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            add_update = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "" || txtAmount.Text == "" || dtpDateState.Text == "") //31 سالم
            {
                MessageBox.Show("لايمكن ادخال قيم فارغه");
                return;
            }
            if (rdMaried.Checked==true)
            {
                State = "زواج";
            }
            else
            {
                State="مولود";
            }
            
            if (add_update == true)
            {
                //insert without image
                if (pic_EMP.Image == null)   
                {
                    MrMohb.PL.CLsMain ob = new PL.CLsMain();
                    ob.insertwhithoutImage(Convert.ToInt32(txtidEmp.Text), txtEmpName.Text, State, Convert.ToDateTime(dtpDateState.Text), Convert.ToDouble(txtAmount.Text), txtCode.Text, txtReciep.Text, txtNote.Text);
                    MessageBox.Show("تمت اضافة الموظف");
                }
                else
                {
                    //Insert with image
                }
            }
            else
            {
                //update
            }


        }

        private void txtidEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateState_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_select_Image_Emp_Click(object sender, EventArgs e)
        {
            opfEMP.Filter = "images files :|*.jpg;*.gif;*BMP;*.PNG";//17salem-----كود اختيار الصورة من الكمبيوتر ووضعها ف فورمة المنتجات --بعد اضافة اوبن فوورم دايلوج
            if (opfEMP.ShowDialog() == DialogResult.OK)
            {
                pic_EMP.Image = Image.FromFile(opfEMP.FileName);//17salem
            }
        }

        
    }
}
