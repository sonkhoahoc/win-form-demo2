using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclareDAO.DAO;
using DeclareDAO;
using DeclareBUS;

namespace Project2
{
    public partial class Form1 : Form
    {
        AccountBUS accountBUS = new AccountBUS();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng ứng dụng không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if (username == "admin" && password == "123")
            {
                frmManager frmmanager = new frmManager();
                this.Hide();
                frmmanager.ShowDialog();
                this.Show();
            }
            else
            {
                txtUserName.Focus();
                txtPassWord.SelectAll();
                MessageBox.Show("Mời bạn nhập lại");
            }
        }
    }
}
