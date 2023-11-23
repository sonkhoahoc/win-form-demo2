using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng ứng dụng không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void qLNgườiKhaiBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuman frm = new frmHuman();
            this.Hide();
            frm.Show();
        }

        private void qLNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManager frm = new frmManager();
            this.Hide();
            frm.Show();
        }

        private void qLPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoom frm = new frmRoom();
            this.Hide();
            frm.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
