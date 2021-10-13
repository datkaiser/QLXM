namespace NET_DoAn
{
    partial class rpXuatPBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rp3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btTrove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rp3
            // 
            this.rp3.ActiveViewIndex = -1;
            this.rp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rp3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp3.Location = new System.Drawing.Point(0, 0);
            this.rp3.Name = "rp3";
            this.rp3.Size = new System.Drawing.Size(792, 407);
            this.rp3.TabIndex = 0;
            // 
            // btTrove
            // 
            this.btTrove.Image = global::NET_DoAn.Properties.Resources.iconfinder_Undo_27885;
            this.btTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrove.Location = new System.Drawing.Point(79, 283);
            this.btTrove.Name = "btTrove";
            this.btTrove.Size = new System.Drawing.Size(93, 30);
            this.btTrove.TabIndex = 11;
            this.btTrove.Text = "Trở về";
            this.btTrove.UseVisualStyleBackColor = true;
            this.btTrove.Click += new System.EventHandler(this.btTrove_Click);
            // 
            // rpXuatPBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 407);
            this.Controls.Add(this.btTrove);
            this.Controls.Add(this.rp3);
            this.Name = "rpXuatPBH";
            this.Text = "rpXuatPBH";
            this.Load += new System.EventHandler(this.rpXuatPBH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rp3;
        private System.Windows.Forms.Button btTrove;
    }
}