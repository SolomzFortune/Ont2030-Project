using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ont2030_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStdLogin f2 = new FrmStdLogin();
            f2.ShowDialog();

        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturer f3 = new frmLecturer();
            f3.ShowDialog();

        }
    }
}
