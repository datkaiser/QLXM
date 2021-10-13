using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_DoAn
{
    public partial class TimKiemTTKhachHang : Form
    {
        public TimKiemTTKhachHang()
        {
            InitializeComponent();
        }
        QLXMDataContext db = new QLXMDataContext();

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IQDI89M;Initial Catalog=QLXM;Integrated Security=True");
        SqlDataAdapter adapt;
        DataTable dt;
        private void btTim_Click(object sender, EventArgs e)
        {
            
        }

        private void TimKiemTTKhachHang_Load(object sender, EventArgs e)
        {
            dgvTTKH.DataSource = db.KhachHangs.ToList();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btHienhet_Click(object sender, EventArgs e)
        {
            dgvTTKH.DataSource = db.KhachHangs.ToList();
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            FormChinh fr = new FormChinh();
            fr.Show();
            this.Hide();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btTim_Click_1(object sender, EventArgs e)
        {
            if (rdMakh.Checked)
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã Khách Hàng cần tìm");
                var qr = from d in db.KhachHangs
                         where d.MaKH.Contains(s)
                         select d;
                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTKH.DataSource = qr.ToList();

            }
            else if (rdTenkh.Checked)
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập Tên Khách Hàng cần tìm");
                var qr = from d in db.KhachHangs
                         where d.TenKH.Contains(s)
                         select d;

                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTKH.DataSource = qr.ToList();
            }
        }
    }
}
