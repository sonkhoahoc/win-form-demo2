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
    public partial class frmHuman : Form
    {
        HumanBUS humanbus = new HumanBUS();
        List<Human> humans;

        public frmHuman()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            dgvHuman.DataSource = null;
            dgvHuman.DataSource = humans;
            dgvHuman.Columns[0].HeaderText = "Mã phòng";
            dgvHuman.Columns[1].HeaderText = "Họ tên";
            dgvHuman.Columns[2].HeaderText = "Giới tính";
            dgvHuman.Columns[3].HeaderText = "Ngày sinh";
            dgvHuman.Columns[4].HeaderText = "CMT";
            dgvHuman.Columns[5].HeaderText = "SDT";
            dgvHuman.Columns[6].HeaderText = "Email";
            dgvHuman.Columns[7].HeaderText = "Địa chỉ";
            dgvHuman.Columns[8].HeaderText = "Số mũi Vaccin";
            dgvHuman.Columns[9].HeaderText = "Ngày khai báo";

            if (dgvHuman.Rows.Count > 1)
            {
                dgvHuman.CurrentCell = dgvHuman.Rows[dgvHuman.Rows.Count - 1].Cells[0];
            }
        }

        private void resetValue()
        {
            txtMaPhong.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtCMT.Text = "";
            dtpNgaySinh.Text = "";
            dtpNgayKhaiBao.Text = "";
            txtVaccin.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            mtbSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại");
                txtMaPhong.Focus();
            }
            else if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên");
                txtHoTen.Focus();
            }
            else if (txtGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giới tính");
                txtGioiTinh.Focus();
            }
            else if (txtCMT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập CMT");
                txtCMT.Focus();
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
            else if (txtVaccin.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên Vaccin");
                txtVaccin.Focus();
            }
            else
            {
                Human human = new Human();
                human.maphong = txtMaPhong.Text.Trim();
                human.hoten = txtHoTen.Text.Trim();
                human.gioitinh = txtGioiTinh.Text.Trim();
                human.CMT = txtCMT.Text.Trim();
                human.ngaysinh = dtpNgaySinh.Value.Date;
                human.ngaykhaibao = dtpNgayKhaiBao.Value.Date;
                human.tiem_Vaccin = Convert.ToByte(txtVaccin.Text.Trim());
                human.diachi = txtDiaChi.Text.Trim();
                human.email = txtEmail.Text.Trim();
                human.sdt = Tool.fillNumber(mtbSDT.Text.Trim());
                if (humanbus.Add(human) == false)
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
                    txtMaPhong.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Bệnh nhân nào");
            }
            else if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên bệnh nhân");
                txtHoTen.Focus();
            }
            else if (txtGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giới tính");
                txtGioiTinh.Focus();
            }
            else if (txtCMT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập CMT");
                txtCMT.Focus();
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
            else if (txtVaccin.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên Vaccin");
                txtVaccin.Focus();
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Human p = new Human();
                    p.maphong = txtMaPhong.Text.Trim();
                    p.hoten = txtHoTen.Text.Trim();
                    p.gioitinh = txtGioiTinh.Text.Trim();
                    p.CMT = txtCMT.Text.Trim();
                    p.ngaykhaibao = dtpNgayKhaiBao.Value.Date;
                    p.ngaysinh = dtpNgaySinh.Value.Date;
                    p.sdt = Tool.fillNumber(mtbSDT.Text.Trim());
                    p.email = txtEmail.Text.Trim();
                    p.tiem_Vaccin = Convert.ToByte(txtVaccin.Text.Trim());
                    humanbus.Edit(p);
                    loadDataGridView();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtCMT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân nào");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Human human = humans.Find(c => c.CMT == txtCMT.Text.Trim());
                    humans.Remove(human);
                    humanbus.Delete(human);
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
            txtMaPhong.Enabled = true;
            resetValue();
            txtMaPhong.Focus();
        }

        private void frmHuman_Load(object sender, EventArgs e)
        {
            humans = humanbus.getAll();
            txtMaPhong.Enabled = false;
            btnThem.Enabled = false;
            loadDataGridView();
        }

        private void dgvHuman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvHuman.CurrentRow.Cells["maphong"].Value.ToString();
            txtHoTen.Text = dgvHuman.CurrentRow.Cells["hoten"].Value.ToString();
            txtGioiTinh.Text = dgvHuman.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtCMT.Text = dgvHuman.CurrentRow.Cells["CMT"].Value.ToString();
            txtDiaChi.Text = dgvHuman.CurrentRow.Cells["diachi"].Value.ToString();
            txtEmail.Text = dgvHuman.CurrentRow.Cells["email"].Value.ToString();
            txtVaccin.Text = dgvHuman.CurrentRow.Cells["tiem_Vaccin"].Value.ToString();
            dtpNgayKhaiBao.Text = dgvHuman.CurrentRow.Cells["ngaykhaibao"].Value.ToString();
            dtpNgaySinh.Text = dgvHuman.CurrentRow.Cells["ngaysinh"].Value.ToString();
            mtbSDT.Text = dgvHuman.CurrentRow.Cells["sdt"].Value.ToString();
            btnThem.Enabled = false;
        }

        private void frmHuman_FormClosing(object sender, FormClosingEventArgs e)
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
