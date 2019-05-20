namespace QLBanGiay.GUI
{
    partial class Main
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
            this.btnBaoCaoThongKe = new MetroFramework.Controls.MetroButton();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.btnGiay = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBaoCaoThongKe.Location = new System.Drawing.Point(265, 38);
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.Size = new System.Drawing.Size(107, 61);
            this.btnBaoCaoThongKe.TabIndex = 5;
            this.btnBaoCaoThongKe.Text = "Thống Kê Giầy";
            this.btnBaoCaoThongKe.UseCustomBackColor = true;
            this.btnBaoCaoThongKe.UseSelectable = true;
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCaoThongKe_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(175, 130);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 61);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseCustomBackColor = true;
            this.btnThoat.UseSelectable = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGiay
            // 
            this.btnGiay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiay.Location = new System.Drawing.Point(91, 38);
            this.btnGiay.Name = "btnGiay";
            this.btnGiay.Size = new System.Drawing.Size(110, 61);
            this.btnGiay.TabIndex = 3;
            this.btnGiay.Text = "Giầy";
            this.btnGiay.UseCustomBackColor = true;
            this.btnGiay.UseSelectable = true;
            this.btnGiay.Click += new System.EventHandler(this.btnGiay_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.btnThoat);
            this.metroPanel1.Controls.Add(this.btnBaoCaoThongKe);
            this.metroPanel1.Controls.Add(this.btnGiay);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(458, 225);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 334);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Main";
            this.Text = "Main";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBaoCaoThongKe;
        private MetroFramework.Controls.MetroButton btnThoat;
        private MetroFramework.Controls.MetroButton btnGiay;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}