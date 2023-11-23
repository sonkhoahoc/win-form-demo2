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
    public partial class frmRoom : Form
    {
        RoomBUS roombus = new RoomBUS();
        List<Room> rooms;

        public frmRoom()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            dgvRoom.DataSource = null;
            dgvRoom.DataSource = rooms;
            dgvRoom.Columns[0].HeaderText = "Mã phòng";
            dgvRoom.Columns[1].HeaderText = "Tên phòng";
            dgvRoom.Columns[2].HeaderText = "Tình trạng";
            dgvRoom.Columns[3].HeaderText = "Số phòng";

            if (dgvRoom.Rows.Count > 1)
            {
                dgvRoom.CurrentCell = dgvRoom.Rows[dgvRoom.Rows.Count - 1].Cells[0];
            }
        }

        private void resetValue()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtTinhTrang.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng");
                txtMaPhong.Focus();
            }
            else if (txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên phòng");
                txtTenPhong.Focus();
            }
            else if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
            }
            else if (txtTinhTrang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tình trạng");
                txtTinhTrang.Focus();
            }
            else
            {
                Room rom = new Room();
                rom.maphong = txtMaPhong.Text.Trim();
                rom.tenphong = txtTenPhong.Text.Trim();
                rom.tinhtrang = txtTinhTrang.Text.Trim();
                rom.soluong = int.Parse(txtSoLuong.Text.Trim());
                
                if (roombus.Add(rom) == false)
                {
                    MessageBox.Show("Mã phòng đã tồn tại");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân nào");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Room rom = rooms.Find(c => c.maphong == txtMaPhong.Text.Trim());
                    rooms.Remove(rom);
                    roombus.Delete(rom);
                    loadDataGridView();
                    resetValue();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn mã Phòng");
                txtMaPhong.Focus();
            }
            else if (txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên Phòng");
                txtTenPhong.Focus();
            }
            else if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
            }
            else if (txtTinhTrang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tình trạng");
                txtTinhTrang.Focus();
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Room rom = new Room();
                    rom.maphong = txtMaPhong.Text.Trim();
                    rom.tenphong = txtTenPhong.Text.Trim();
                    rom.tinhtrang = txtTinhTrang.Text.Trim();
                    rom.soluong = int.Parse(txtSoLuong.Text.Trim());
                    roombus.Edit(rom);
                    loadDataGridView();
                }
            }
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            rooms = roombus.getAll();
            txtMaPhong.Enabled = false;
            btnThem.Enabled = false;
            loadDataGridView();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvRoom.CurrentRow.Cells["maphong"].Value.ToString();
            txtTenPhong.Text = dgvRoom.CurrentRow.Cells["tenphong"].Value.ToString();
            txtTinhTrang.Text = dgvRoom.CurrentRow.Cells["tinhtrang"].Value.ToString();
            txtSoLuong.Text = dgvRoom.CurrentRow.Cells["soluong"].Value.ToString();
            btnThem.Enabled = false;
        }

        private void frmRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng ứng dụng không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMaPhong_Leave(object sender, EventArgs e)
        {
            Room room = rooms.Find(c => c.maphong == txtMaPhong.Text.Trim());
            if (room != null)
            {
                txtTenPhong.Text = room.tenphong;
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
