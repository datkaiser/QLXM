using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_DoAn
{
    public partial class ChiTietXuat : Form
    {
        public ChiTietXuat()
        {
            InitializeComponent();
        }
        QLXMDataContext db = new QLXMDataContext();

        public static string MAHDX;
        private void LoaddgvXe()
        {
            dgvXE.DataSource = db.Xes.ToList();
            dgvXE.Columns[12].Visible = false;
            dgvXE.Columns[13].Visible = false;
           
        }
        private void LoadChitietHDX()
        {
            dgvChitietHDX.DataSource = db.ChitietHDXes.ToList();
        }
        public string mahdx = XuatHoaDon.Mahdx;
        private void btTimkiem_Click(object sender, EventArgs e)
        {
            var qr = from d in db.Xes
                     where d.TenXe.Contains(txttenxe.Text)
                     select d;

            if (qr.Count() == 0)
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            else
                dgvXE.DataSource = qr.ToList();
            txttenxe.Text = "";
        }
        private void ChiTietXuat_Load(object sender, EventArgs e)
        {
            txtMahdx.Text = mahdx;
            LoaddgvXe();
            LoadChitietHDX();
            txtMahdx.Enabled = false;
            txtMaxe.Enabled = false;
            txtDongia.Enabled = false;
            txtsoluong.Enabled = false;
            txtThueVAT.Enabled = false;
            dgvChitietHDX.Columns[5].Visible = false;
            dgvChitietHDX.Columns[6].Visible = false;
        }

        private void bttrove_Click(object sender, EventArgs e)
        {
            XuatHoaDon fr = new XuatHoaDon();
            fr.Show();
            this.Hide();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                btThem.Text = "Lưu";
                txtMaxe.Text = dgvXE.CurrentRow.Cells[0].Value.ToString();
                txtDongia.Text = dgvXE.CurrentRow.Cells[5].Value.ToString();
                btSua.Enabled = false;
                btXoa.Enabled = false;
                txtThueVAT.Enabled = true;
                txtsoluong.Enabled = true;
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtsoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số lượng xuất hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoluong.Focus();
                    return;
                }
                if (txtMaxe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Mã xe trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaxe.Focus();
                    return;
                }
                if (txtThueVAT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Thuế VAT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThueVAT.Focus();
                    return;
                }
                else
                {
                    ChitietHDX ct = new ChitietHDX();
                    ct.MaHDX = txtMahdx.Text;
                    ct.MaXe = txtMaxe.Text;
                    ct.Dongia = Convert.ToInt32(txtDongia.Text);
                    ct.Soluong = Convert.ToInt32(txtsoluong.Text);
                    ct.ThueVAT = Convert.ToDecimal(txtThueVAT.Text);
                    db.ChitietHDXes.InsertOnSubmit(ct);
                    db.SubmitChanges();
                    MessageBox.Show("Đã thêm chi tiết hóa đơn xuất", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    LoadChitietHDX();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                txtThueVAT.Enabled = true;
                txtsoluong.Enabled = true;
            }
            else
            {
                if (txtsoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số lượng xuất hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoluong.Focus();
                    return;
                }
                if (txtMaxe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Mã xe trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaxe.Focus();
                    return;
                }
                if (txtThueVAT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Thuế VAT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThueVAT.Focus();
                    return;
                }
                else
                {
                    ChitietHDX ct = db.ChitietHDXes.Single(s => s.MaHDX == txtMahdx.Text);
                    ct.MaHDX = txtMahdx.Text;
                    ct.MaXe = txtMaxe.Text;
                    ct.Dongia = Convert.ToInt32(txtDongia.Text);
                    ct.Soluong = Convert.ToInt32(txtsoluong.Text);
                    ct.ThueVAT = Convert.ToDecimal(txtThueVAT.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Đã sửa chi tiết hóa đơn xuất", "Thông báo");
                    LoadChitietHDX();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvChitietHDX.SelectedRows.Count; i++)
                {
                    string st = dgvChitietHDX.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in db.ChitietHDXes
                             where d.MaHDX == st
                             select d;
                    db.ChitietHDXes.DeleteOnSubmit(qr.FirstOrDefault());
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadChitietHDX();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btInhoadonxuat_Click(object sender, EventArgs e)
        {
            MAHDX = txtMahdx.Text;
            rpXuatHD rp1 = new rpXuatHD();
            rp1.Show();
            this.Hide();
        }

        private void dgvXE_SelectionChanged(object sender, EventArgs e)
        {
            txtMaxe.Text = dgvXE.CurrentRow.Cells[0].Value.ToString();
            txtDongia.Text = dgvXE.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvChitietHDX_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtMahdx.Focus();
                return;
            }
            if (dgvChitietHDX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }
            txtMahdx.Text = dgvChitietHDX.CurrentRow.Cells[0].Value.ToString();
            txtMaxe.Text = dgvChitietHDX.CurrentRow.Cells[1].Value.ToString();
            txtDongia.Text = dgvChitietHDX.CurrentRow.Cells[2].Value.ToString();
            txtsoluong.Text = dgvChitietHDX.CurrentRow.Cells[3].Value.ToString();
            txtThueVAT.Text = dgvChitietHDX.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
