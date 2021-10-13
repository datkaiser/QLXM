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
    public partial class TimKiemTTXe : Form
    {
        public TimKiemTTXe()
        {
            InitializeComponent();
        }
        QLXMDataContext db = new QLXMDataContext();
        private void btTim_Click(object sender, EventArgs e)
        {
            if (cb_tenxe.Checked == true && cb_mancc.Checked == true && cb_tt.Checked == true)
            {

                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text) && d.MaNCC.Contains(txt_mancc.Text) && d.TinhTrang.Contains(txt_tinhtrang.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_tenxe.Checked == true && cb_mancc.Checked == true)
            {
                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text) && d.MaNCC.Contains(txt_mancc.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }

            }
            else if (cb_tenxe.Checked == true && cb_tt.Checked == true)
            {

                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text) && d.TinhTrang.Contains(txt_tinhtrang.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }

            }
            else if (cb_mancc.Checked == true && cb_tt.Checked == true)
            {

                var qr = from d in db.Xes
                         where d.MaNCC.Contains(txt_mancc.Text) && d.TinhTrang.Contains(txt_tinhtrang.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_tenxe.Checked == true)
            {
                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_mancc.Checked == true)
            {
                var qr = from d in db.Xes
                         where d.MaNCC.Contains(txt_mancc.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_tt.Checked == true)
            {

                var qr1 = from d in db.Xes
                          where d.TinhTrang.Contains(txt_tinhtrang.Text)
                          select d;

                if (qr1.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr1.ToList();
                }
            }
        }
        private void reset()
        {
            txt_tenxe.Text = "";
            txt_mancc.Text = "";
            txt_tinhtrang.Text = "";
        }

        private void btHienhet_Click(object sender, EventArgs e)
        {
            dgv_ht.DataSource = db.Xes.ToList();
            reset();
        }

        private void bttrove_Click(object sender, EventArgs e)
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

        private void cb_tenxe_CheckedChanged(object sender, EventArgs e)
        {
            txt_tenxe.Text = "";
        }

        private void cb_mancc_CheckedChanged(object sender, EventArgs e)
        {
            txt_mancc.Text = "";
        }

        private void cb_tt_CheckedChanged(object sender, EventArgs e)
        {
            txt_tinhtrang.ResetText();
        }

        private void TimKiemTTXe_Load(object sender, EventArgs e)
        {
            dgv_ht.DataSource = db.Xes.ToList();
            dgv_ht.Columns[12].Visible = false;
            dgv_ht.Columns[13].Visible = false;
        }

        private void dgv_ht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
