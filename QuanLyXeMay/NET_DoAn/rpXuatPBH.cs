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
    public partial class rpXuatPBH : Form
    {
        public rpXuatPBH()
        {
            InitializeComponent();
        }

        private void rpXuatPBH_Load(object sender, EventArgs e)
        {
            using (QLXMDataContext db = new QLXMDataContext())
            {
                rpBaoHanh report = new rpBaoHanh();

                var data = db.BaoHanhs;
                report.SetDataSource(
                    data.AsEnumerable().Select(r =>
                    {
                        return new
                        {
                            MaPhieuBH = r.MaPhieuBH,
                            MaKH = r.MaKH,
                            MaNV = r.MaNV,
                            MaXe = r.MaXe,
                            TGBH=r.TGBH.ToString(),
                            NgayMua=r.NgayMua== null?string.Empty:r.NgayMua.ToString()
                        };
                    })
                    );

                rp3.ReportSource = report;
            }
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            FormChinh fr = new FormChinh();
            fr.Show();
            this.Hide();
        }
    }
}
