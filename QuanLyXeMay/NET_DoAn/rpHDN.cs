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
    public partial class rpHDN : Form
    {
        public rpHDN()
        {
            InitializeComponent();
        }

        private void rpHDN_Load(object sender, EventArgs e)
        {
            using (QLXMDataContext db = new QLXMDataContext())
            {
                rpPhieuNhap report = new rpPhieuNhap();
                 var data = db.ChitietHDNs;
                report.SetDataSource(
                    data.AsEnumerable().Select(r =>
                    {
                        return new
                        {
                            MaHDN = r.MaHDN,
                            MaXe = r.MaXe,
                            Dongia = r.Dongia.ToString(),
                            Soluong = r.Soluong.ToString(),
                            ThueVAT = r.ThueVAT.ToString()
                        };
                    })
                    );

              
                crystalReportViewer1.ReportSource = report;
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
