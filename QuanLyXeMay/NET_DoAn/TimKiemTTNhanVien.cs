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
    public partial class TimKiemTTNhanVien : Form
    {
        public TimKiemTTNhanVien()
        {
            InitializeComponent();
        }
        QLXMDataContext db = new QLXMDataContext();
        private void btTim_Click(object sender, EventArgs e)
        {
            if (rdManv.Checked)
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập Mã Nhân Viên cần tìm");
                var qr = from d in db.NhanViens
                         where d.MaNV.Contains(s)
                         select d;
                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTNV.DataSource = qr.ToList();
            }
            else
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập Tên Nhân Viên cần tìm");
                var qr = from d in db.NhanViens
                         where d.TenNV.Contains(s)
                         select d;
                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTNV.DataSource = qr.ToList();
            }
        }

        private void TimKiemTTNhanVien_Load(object sender, EventArgs e)
        {
            dgvTTNV.DataSource = db.NhanViens.ToList();
            //dgvTTNV.Columns[10].Visible = false;
            //dgvTTNV.Columns[11].Visible = false;
        }

        private void btHienhet_Click(object sender, EventArgs e)
        {
            dgvTTNV.DataSource = db.NhanViens.ToList();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            FormQuanLy fr = new FormQuanLy();
            fr.Show();
            this.Hide();
        }
    }
}
