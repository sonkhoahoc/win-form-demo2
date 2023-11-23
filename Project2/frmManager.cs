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
    public partial class frmManager : Form
    {
        ManagerBUS managerbus = new ManagerBUS();
        List<Manager> managers;

        public frmManager()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            dgvManager.DataSource = null;
            dgvManager.DataSource = managers;
            dgvManager.Columns[0].HeaderText = "Mã QL";
            dgvManager.Columns[1].HeaderText = "Mã phòng";
            dgvManager.Columns[2].HeaderText = "Họ tên";
            dgvManager.Columns[3].HeaderText = "Giới tính";
            dgvManager.Columns[4].HeaderText = "Ngày sinh";
            dgvManager.Columns[5].HeaderText = "SDT";
            dgvManager.Columns[6].HeaderText = "Email";
            dgvManager.Columns[7].HeaderText = "Địa chỉ";

            if (dgvManager.Rows.Count > 1)
            {
                dgvManager.CurrentCell = dgvManager.Rows[dgvManager.Rows.Count - 1].Cells[0];
            }
        }

        private void resetValue()
        {
            txtMaPhongQL.Text = "";
            txtMaQL.Text = "";
            txtGioiTinh.Text = "";
            txtHoTenQL.Text = "";
            dtpNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            mtbSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhongQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã Phòng QL");
                txtMaPhongQL.Focus();
            }
            else if (txtHoTenQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên");
                txtHoTenQL.Focus();
            }
            else if (txtGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giới tính");
                txtGioiTinh.Focus();
            }
            else if (txtMaQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập CMT");
                txtMaQL.Focus();
            }
            else if (mtbSDT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại");
                mtbSDT.Focus();
            }
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập Email");
                txtEmail.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                txtDiaChi.Focus();
            }
            else if (dtpNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên Vaccin");
                dtpNgaySinh.Focus();
            }
            else
            {
                Manager manager = new Manager();
                manager.maphong = txtMaPhongQL.Text.Trim();
                manager.maql = txtMaQL.Text.Trim();
                manager.hotenql = txtHoTenQL.Text.Trim();
                manager.gioitinh = txtGioiTinh.Text.Trim();
                manager.ngaysinh = dtpNgaySinh.Value.Date;
                manager.email = txtEmail.Text.Trim();
                manager.sdt = Tool.fillNumber(mtbSDT.Text.Trim());
                manager.diachi = txtDiaChi.Text.Trim();

                if (managerbus.Add(manager) == false)
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
                else
                {
                    loadDataGridView();
                    resetValue();
                    btnXoa.Enabled = true;
                    btnLamMoi.Enabled = true;
                    btnSua.Enabled = true;
                    btnThem.Enabled = false;
                    txtMaPhongQL.Enabled = true;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhongQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã Phòng QL");
                txtMaPhongQL.Focus();
            }
            else if (txtHoTenQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên");
                txtHoTenQL.Focus();
            }
            else if (txtGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giới tính");
                txtGioiTinh.Focus();
            }
            else if (txtMaQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập CMT");
                txtMaQL.Focus();
            }
            else if (mtbSDT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại");
                mtbSDT.Focus();
            }
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập Email");
                txtEmail.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                txtDiaChi.Focus();
            }
            else if (dtpNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên Vaccin");
                dtpNgaySinh.Focus();
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Manager p = new Manager();
                    p.maphong = txtMaPhongQL.Text.Trim();
                    p.maql = txtMaQL.Text.Trim();
                    p.hotenql = txtHoTenQL.Text.Trim();
                    p.gioitinh = txtGioiTinh.Text.Trim();
                    p.ngaysinh = dtpNgaySinh.Value.Date;
                    p.sdt = Tool.fillNumber(mtbSDT.Text.Trim());
                    p.email = txtEmail.Text.Trim();
                    p.diachi = txtDiaChi.Text.Trim();
                    managerbus.Edit(p);
                    loadDataGridView();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaQL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Manager manager = managers.Find(c => c.maql == txtMaQL.Text.Trim());
                    managers.Remove(manager);
                    managerbus.Delete(manager);
                    loadDataGridView();
                    resetValue();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = false;
            txtMaQL.Enabled = true;
            resetValue();
            txtMaQL.Focus();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            managers = managerbus.getAll();
            txtMaQL.Enabled = false;
            btnThem.Enabled = false;
            loadDataGridView();
        }

        private void dgvManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhongQL.Text = dgvManager.CurrentRow.Cells["maphong"].Value.ToString();
            txtMaQL.Text = dgvManager.CurrentRow.Cells["maql"].Value.ToString();
            txtHoTenQL.Text = dgvManager.CurrentRow.Cells["hotenql"].Value.ToString();
            txtGioiTinh.Text = dgvManager.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtDiaChi.Text = dgvManager.CurrentRow.Cells["diachi"].Value.ToString();
            txtEmail.Text = dgvManager.CurrentRow.Cells["email"].Value.ToString();
            dtpNgaySinh.Text = dgvManager.CurrentRow.Cells["ngaysinh"].Value.ToString();
            mtbSDT.Text = dgvManager.CurrentRow.Cells["sdt"].Value.ToString();
            btnThem.Enabled = false;
        }

        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng ứng dụng không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.Show();
        }
    }
}
