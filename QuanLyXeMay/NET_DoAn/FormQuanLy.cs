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
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatTTNhanVien fr = new CapNhatTTNhanVien();
            fr.Show();
            this.Hide();
        }

        private void xemVaMuaSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormMuaSach fr = new FormMuaSach();
            //fr.Show();
        }

        private void cậpNhậtThôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatTTNCC fr = new CapNhatTTNCC();
            fr.Show();
            this.Hide();
        }

        private void cậpNhậtThôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatTTXe fr = new CapNhatTTXe();
            fr.Show();
            this.Hide();
        }

        private void tìmKiếmThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemTTNhanVien fr = new TimKiemTTNhanVien();
            fr.Show();
            this.Hide();
        }

        private void thanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap fr = new FormDangNhap();
            fr.Show();
            this.Hide();
        }
    }
}
