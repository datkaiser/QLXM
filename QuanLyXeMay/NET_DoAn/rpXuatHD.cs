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
    public partial class rpXuatHD : Form
    {
        public rpXuatHD()
        {
            InitializeComponent();
        }

        private void rpXuatHD_Load(object sender, EventArgs e)
        {
            using (QLXMDataContext db = new QLXMDataContext())
            {
                rpXHD report = new rpXHD();

                var data = db.ChitietHDXes;
                report.SetDataSource(
                    data.AsEnumerable().Select(r =>
                    {
                        return new
                        {
                            MaHDX = r.MaHDX,
                            MaXE = r.MaXe,
                            Dongia = r.Dongia.ToString(),
                            Soluong = r.Soluong.ToString(),
                            ThueVAT = r.ThueVAT.ToString()
                        };
                    })
                    );

                rp2.ReportSource = report;
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
