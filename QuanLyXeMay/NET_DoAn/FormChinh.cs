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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                FormDangNhap frDangNhap = new FormDangNhap();
                frDangNhap.Show();
                this.Visible = false;
            }
            else if (r == DialogResult.No)
            {
                return;
            }
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if(r==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cacThanhViênTrongNhomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n Kính Gửi GVHD Thầy Trần Xuân Thanh Phúc \n -Mai Quốc Đạt \n -Nguyễn Vũ Cảnh \n-Dương Thanh Công", "Các Thành Viên Trong Nhóm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
        }

        private void đôcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormDocGia frDocGia = new FormDocGia();
            //frDocGia.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormNhanVien frNhanVien = new FormNhanVien();
            //frNhanVien.Show();
        }

        private void quanLySachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FormQuanLySach frQLySach = new FormQuanLySach();
            //frQLySach.Show();
        }

        private void mươnTraSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormMuonTraSach frMuonTraSach = new FormMuonTraSach();
            //frMuonTraSach.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cậpNhậtThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatTTKhachHang fr = new CapNhatTTKhachHang();
            fr.Show();
            this.Hide();
        }

        private void tìmKiếmThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemTTKhachHang fr = new TimKiemTTKhachHang();
            fr.Show();
            this.Hide();
        }

        private void tìmKiếmThôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemTTXe fr = new TimKiemTTXe();
            fr.Show();
                this.Hide();
        }

        private void nhậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHoaDon fr = new NhapHoaDon();
            fr.Show();
            this.Hide();
        }

        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatHoaDon fr = new XuatHoaDon();
            fr.Show();
            this.Hide();
        }

        private void dăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap fr = new FormDangNhap();
            fr.Show();
            this.Hide();
        }

        private void phiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpXuatPBH fr = new rpXuatPBH();
            fr.Show();
            this.Hide();
        
        }
    }
}
