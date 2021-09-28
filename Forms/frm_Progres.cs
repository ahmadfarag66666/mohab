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
    public partial class frm_Progres : Form
    {
        public frm_Progres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int starpoint = 0;// الدقيقة 28 C#_Full_Project_Tutorial(Supermarket_Management_System)With_source_co  
        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 1;
            Myprogress.Value = starpoint;
            if (Myprogress.Value==50)
            {
                Myprogress.Value=0;
                timer1.Stop();
                this.Hide();
                MrMohb.Forms.frm_MDI frm = new Forms.frm_MDI();
                frm.ShowDialog();
            }
        }

        private void frm_Progres_Load(object sender, EventArgs e)
        {
            timer1.Start();  //  الدقيقة28  C#_Full_Project_Tutorial(Supermarket_Management_System)With_source_co
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
