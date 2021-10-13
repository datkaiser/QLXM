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
    public partial class CapNhatTTKhachHang : Form
    {
        public CapNhatTTKhachHang()
        {
            InitializeComponent();
        }
        QLXMDataContext db = new QLXMDataContext();

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                vohieuhoa(true);
                txtMakh.Enabled = true;
                reset();
                txtMakh.Focus();
                btSua.Enabled = false;
                btXoa.Enabled = false;
                btThem.Text = "Lưu";
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtMakh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMakh.Focus();
                    return;
                }
                if (txttenKh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenKh.Focus();
                    return;
                }
                if (txtGt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGt.Focus();
                    return;
                }
                if (txtDc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDc.Focus();
                    return;
                }
                if (txtSdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSdt.Focus();
                    return;
                }
                using (QLXMDataContext db = new QLXMDataContext())
                {
                    var qr = from d in db.KhachHangs
                             where d.MaKH == txtMakh.Text
                             select d;

                    if (qr.Count() != 0)
                    {
                        MessageBox.Show("Trùng mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKH = txtMakh.Text;
                        kh.TenKH = txttenKh.Text;
                        kh.GioiTinh = txtGt.Text;
                        kh.Diachi = txtDc.Text;
                        kh.SDT = txtSdt.Text;
                        kh.Ghichu = txtGhichu.Text;
                        db.KhachHangs.InsertOnSubmit(kh);
                        db.SubmitChanges();
                        MessageBox.Show("Đã thêm nhân viên", "Thông báo");
                        btSua.Enabled = true;
                        btXoa.Enabled = true;
                        reset();
                        LoadKH();
                    }
                }
            }
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            FormChinh fr = new FormChinh();
            fr.Show();
            this.Hide();
        }
        private void LoadKH()
        {
            using (QLXMDataContext db = new QLXMDataContext())
            {
                dgvKH.DataSource = db.KhachHangs.ToList();     
            }
        }
        private void reset()
        {
            txtMakh.Text = "";
            txttenKh.Text = "";
            txtGt.Text = "";
            txtDc.Text = "";
            txtSdt.Text = "";
            txtGhichu.Text = "";
        }
        private void vohieuhoa(bool kt)
        {
            txtSdt.Enabled = kt;
            txtMakh.Enabled = kt;
            txttenKh.Enabled = kt;
            txtGt.Enabled = kt;
            txtDc.Enabled = kt;
            txtGhichu.Enabled = kt;
        }

        private void CapNhatTTKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            txtMakh.Enabled = false;
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtMakh.Focus();
                return;
            }
            if (dgvKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }

            txtMakh.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
            txttenKh.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
            txtGt.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();
            txtDc.Text = dgvKH.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgvKH.CurrentRow.Cells[4].Value.ToString();
            txtGhichu.Text = dgvKH.CurrentRow.Cells[5].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtMakh.Enabled = false;
            }
            else
            {
                //btSua.Text = "Sửa";
                if (txtMakh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMakh.Focus();
                    return;
                }
                if (txttenKh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenKh.Focus();
                    return;
                }
                if (txtGt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGt.Focus();
                    return;
                }
                if (txtDc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDc.Focus();
                    return;
                }
                if (txtSdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSdt.Focus();
                    return;
                }

                else
                {
                    KhachHang kh = db.KhachHangs.Single(s => s.MaKH == txtMakh.Text);
                    kh.MaKH = txtMakh.Text;
                    kh.TenKH = txttenKh.Text;
                    kh.GioiTinh = txtGt.Text;
                    kh.Diachi = txtDc.Text;
                    kh.SDT = txtSdt.Text;
                    kh.Ghichu = txtGhichu.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    reset();
                    LoadKH();
                }
            }               
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvKH.SelectedRows.Count; i++)
                {
                    string st = dgvKH.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in db.KhachHangs
                             where d.MaKH == st
                             select d;
                    db.KhachHangs.DeleteOnSubmit(qr.FirstOrDefault());
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadKH();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormChinh fr = new FormChinh();
                fr.Show();
                this.Hide();
            }
        }
    }
}
