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
    public partial class Xemloaixe : Form
    {
        public Xemloaixe()
        {
            InitializeComponent();
        }
        QLXMDataContext db = new QLXMDataContext();
        private void btTrove_Click(object sender, EventArgs e)
        {
            CapNhatTTXe fr = new CapNhatTTXe();
            fr.Show();
            this.Hide();
        }

        private void Xemloaixe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Loaixes.ToList();
            //dataGridView1.Columns[2].Visible = false;
        }
    }
}
