namespace DoAnGiuaKi
{
    partial class ThongTinTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongtin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnDoi = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbRePass = new JTextBox2.JTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPass = new JTextBox2.JTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new JTextBox2.JTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(475, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // gbThongtin
            // 
            this.gbThongtin.BackColor = System.Drawing.SystemColors.Control;
            this.gbThongtin.Controls.Add(this.pictureBox1);
            this.gbThongtin.Controls.Add(this.btnHuy);
            this.gbThongtin.Controls.Add(this.btnDoi);
            this.gbThongtin.Controls.Add(this.label10);
            this.gbThongtin.Controls.Add(this.label11);
            this.gbThongtin.Controls.Add(this.label12);
            this.gbThongtin.Controls.Add(this.txbRePass);
            this.gbThongtin.Controls.Add(this.label13);
            this.gbThongtin.Controls.Add(this.label6);
            this.gbThongtin.Controls.Add(this.label7);
            this.gbThongtin.Controls.Add(this.label8);
            this.gbThongtin.Controls.Add(this.txbPass);
            this.gbThongtin.Controls.Add(this.label9);
            this.gbThongtin.Controls.Add(this.txbTaiKhoan);
            this.gbThongtin.Controls.Add(this.label2);
            this.gbThongtin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(135)))), ((int)(((byte)(14)))));
            this.gbThongtin.Location = new System.Drawing.Point(312, 162);
            this.gbThongtin.Name = "gbThongtin";
            this.gbThongtin.Size = new System.Drawing.Size(539, 299);
            this.gbThongtin.TabIndex = 1;
            this.gbThongtin.TabStop = false;
            this.gbThongtin.Text = "Chỉnh sửa thông tin tài khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnGiuaKi.Properties.Resources.protected_icon;
            this.pictureBox1.Location = new System.Drawing.Point(126, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuy.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Transparent;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnHuy.IconColor = System.Drawing.Color.White;
            this.btnHuy.IconSize = 23;
            this.btnHuy.Location = new System.Drawing.Point(407, 227);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Rotation = 0D;
            this.btnHuy.Size = new System.Drawing.Size(89, 40);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDoi
            // 
            this.btnDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(135)))), ((int)(((byte)(14)))));
            this.btnDoi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDoi.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoi.ForeColor = System.Drawing.Color.White;
            this.btnDoi.IconChar = FontAwesome.Sharp.IconChar.DigitalOcean;
            this.btnDoi.IconColor = System.Drawing.Color.White;
            this.btnDoi.IconSize = 25;
            this.btnDoi.Location = new System.Drawing.Point(272, 227);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Rotation = 0D;
            this.btnDoi.Size = new System.Drawing.Size(115, 40);
            this.btnDoi.TabIndex = 15;
            this.btnDoi.Text = "Thay Đổi";
            this.btnDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoi.UseVisualStyleBackColor = false;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(132, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(144, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = ")";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(123, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "(";
            // 
            // txbRePass
            // 
            this.txbRePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRePass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRePass.Font_Size = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRePass.HintText = null;
            this.txbRePass.IsPassword = true;
            this.txbRePass.Location = new System.Drawing.Point(168, 172);
            this.txbRePass.Margin = new System.Windows.Forms.Padding(4);
            this.txbRePass.MaxLength = 32767;
            this.txbRePass.Name = "txbRePass";
            this.txbRePass.OnFocusedColor = System.Drawing.Color.White;
            this.txbRePass.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRePass.ReadOnly = false;
            this.txbRePass.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txbRePass.Size = new System.Drawing.Size(328, 27);
            this.txbRePass.TabIndex = 11;
            this.txbRePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbRePass.TextName = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(39, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "Nhập lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(132, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(144, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = ")";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(123, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "(";
            // 
            // txbPass
            // 
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Font_Size = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.HintText = null;
            this.txbPass.IsPassword = true;
            this.txbPass.Location = new System.Drawing.Point(168, 105);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbPass.MaxLength = 32767;
            this.txbPass.Name = "txbPass";
            this.txbPass.OnFocusedColor = System.Drawing.Color.White;
            this.txbPass.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPass.ReadOnly = false;
            this.txbPass.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txbPass.Size = new System.Drawing.Size(328, 27);
            this.txbPass.TabIndex = 6;
            this.txbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPass.TextName = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mật khẩu";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.Font_Size = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.HintText = null;
            this.txbTaiKhoan.IsPassword = false;
            this.txbTaiKhoan.Location = new System.Drawing.Point(168, 42);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txbTaiKhoan.MaxLength = 32767;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.OnFocusedColor = System.Drawing.Color.Gainsboro;
            this.txbTaiKhoan.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTaiKhoan.ReadOnly = false;
            this.txbTaiKhoan.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txbTaiKhoan.Size = new System.Drawing.Size(328, 27);
            this.txbTaiKhoan.TabIndex = 1;
            this.txbTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTaiKhoan.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản";
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1143, 565);
            this.Controls.Add(this.gbThongtin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinTaiKhoan";
            this.Text = "ThongTinTaiKhoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbThongtin.ResumeLayout(false);
            this.gbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongtin;
        private JTextBox2.JTextBox txbTaiKhoan;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnDoi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private JTextBox2.JTextBox txbRePass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private JTextBox2.JTextBox txbPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}