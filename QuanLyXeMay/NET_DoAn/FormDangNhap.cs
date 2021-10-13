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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            FormChinh frChinh = new FormChinh();
            frChinh.Show();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (NV(txtDangNhap.Text, txtMatKhau.Text) || KH(txtDangNhap.Text,txtMatKhau.Text))
            {     
                RadioButton ckb = null;
                foreach (RadioButton item in pnl.Controls)
                {
                    if (item != null)
                    {
                        if (item.Checked == true)
                        {
                            ckb = item;
                            if (radAdmin.Checked == true)
                            {
                                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormChinh fr = new FormChinh();
                                fr.Show();
                                FormDangNhap fr2 = new FormDangNhap();
                                fr2.Hide();
                                this.Hide();
                                return;
                            }
                            if (radKhachHang.Checked == true)
                            {
                                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormQuanLy fr = new FormQuanLy();
                                fr.Show();
                                FormDangNhap fr2 = new FormDangNhap();
                                fr2.Hide();
                                this.Hide();
                                return;
                            }
                        }
                        if ((radAdmin.Checked || radKhachHang.Checked) == false) 
                        {
                            MessageBox.Show("Vui lòng chọn ADMIN hoặc Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            
            else
            {
                MessageBox.Show("Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDangNhap.Focus();
            }
        }
        private bool NV(string userName, string password)
        {
            QLXMDataContext context = new QLXMDataContext();
            {
                    var q = from p in context.NhanViens
                            where p.MaNV == txtDangNhap.Text
                            && p.Pass == txtMatKhau.Text
                            select p;
                
                //var b = from t in context.DOCGIAs
                //        where t.TENTAIKHOAN == txtDangNhap.Text
                //        && t.MATKHAU == txtMatKhau.Text
                //        select t;
                if (q.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool KH(string userName, string password)
        {
            QLXMDataContext context = new QLXMDataContext();
            {
                var q = from p in context.Admins
                        where p.Usename == txtDangNhap.Text
                        && p.Password == txtMatKhau.Text
                        select p;
                if (q.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (r == DialogResult.No)
            {
                return;
            }
        }

        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radio = sender as RadioButton;
            //if (radio.Checked)
            //{
            //    FormChinh fr = new FormChinh();
            //    fr.Show();
            //}
        }

        private void radKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radio = sender as RadioButton;
            ////if (radio.Checked)
            //{
            //    FormKhachHang fr = new FormKhachHang();
            //    fr.Show();
            //}
        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {
            QLXMDataContext login = new QLXMDataContext();
            {
                NhanVien nv = new NhanVien();
                KhachHang kh = new KhachHang();
                if (txtDangNhap.Text == "N")
                {
                    radAdmin.Enabled = true;
                    radKhachHang.Enabled = false;
                }
                else if (txtDangNhap.Text == "A")
                {
                    radKhachHang.Enabled = true;
                    radAdmin.Enabled = false;
                }
                else if (txtDangNhap.Text == "")
                {
                    radAdmin.Enabled = true;
                    radKhachHang.Enabled = true;
                }
                
            }
        }
    }
}
