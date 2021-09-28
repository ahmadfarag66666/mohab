using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrMohb.Forms
{
    public partial class frmManageEmp : Form
    {
        MrMohb.PL.CLsMain ob = new PL.CLsMain();
        DataTable dt = new DataTable();
        public frmManageEmp()
        {
            InitializeComponent();

           dt= ob.displyEmpOn_dgv();  //عرض الموظفبن على الداتا جريد فيو
           dgvEmpManage.DataSource = dt;//عرض الموظفبن على الداتا جريد فيو

           //dgvEmpManage.Columns[0].HeaderText = "رقم الصنف";
           //dgvEmpManage.Columns[1].HeaderText = "اسم الصنف";
           dgvEmpManage.Columns[2].HeaderText = "حالة الموظف";//تسمية العامود
           //dgvEmpManage.Columns[2].Width = 110;  //توسيع وتضييق عرض العامود فى الداتا جريد فيو  ولكن اذا اخترت اوتو كولم مود فيل فمينفعش اعمل الكود ده

           dgvEmpManage.Columns[3].HeaderText = "تاريخ الحالة";//تسمية العامود
            // dgvEmpManage.Columns[3].Width = 110;  //توسيع وتضييق عرض العامود فى الداتا جريد فيو  ولكن اذا اخترت اوتو كولم مود فيل فمينفعش اعمل الكود ده
        
        }

        private void frmManageEmp_Load(object sender, EventArgs e)
        {

        }

        private void dgvEmpManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
