namespace DoAnGiuaKi
{
    partial class CRUDTaiKhoan
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
            this.HeaderBox = new System.Windows.Forms.GroupBox();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panelErrorPrice = new System.Windows.Forms.Panel();
            this.labelErrorPrice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelErrorName = new System.Windows.Forms.Panel();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.txbMatKhau = new JTextBox.JText_Box();
            this.txbTaiKhoan = new JTextBox.JText_Box();
            this.Ten = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.Label();
            this.loai = new System.Windows.Forms.Label();
            this.HeaderBox.SuspendLayout();
            this.panelErrorPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelErrorName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBox
            // 
            this.HeaderBox.Controls.Add(this.btnSua);
            this.HeaderBox.Controls.Add(this.btnThem);
            this.HeaderBox.Controls.Add(this.panelErrorPrice);
            this.HeaderBox.Controls.Add(this.panelErrorName);
            this.HeaderBox.Controls.Add(this.btnHuy);
            this.HeaderBox.Controls.Add(this.cbxLoai);
            this.HeaderBox.Controls.Add(this.txbMatKhau);
            this.HeaderBox.Controls.Add(this.txbTaiKhoan);
            this.HeaderBox.Controls.Add(this.Ten);
            this.HeaderBox.Controls.Add(this.gia);
            this.HeaderBox.Controls.Add(this.loai);
            this.HeaderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderBox.Location = new System.Drawing.Point(12, 12);
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(508, 369);
            this.HeaderBox.TabIndex = 1;
            this.HeaderBox.TabStop = false;
            this.HeaderBox.Text = "Thêm tài khoản";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.IconSize = 27;
            this.btnSua.Location = new System.Drawing.Point(59, 311);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(112, 33);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.IconSize = 27;
            this.btnThem.Location = new System.Drawing.Point(209, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(112, 33);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelErrorPrice
            // 
            this.panelErrorPrice.Controls.Add(this.labelErrorPrice);
            this.panelErrorPrice.Controls.Add(this.pictureBox2);
            this.panelErrorPrice.Location = new System.Drawing.Point(163, 200);
            this.panelErrorPrice.Name = "panelErrorPrice";
            this.panelErrorPrice.Size = new System.Drawing.Size(292, 18);
            this.panelErrorPrice.TabIndex = 13;
            // 
            // labelErrorPrice
            // 
            this.labelErrorPrice.AutoSize = true;
            this.labelErrorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelErrorPrice.Location = new System.Drawing.Point(31, 3);
            this.labelErrorPrice.Name = "labelErrorPrice";
            this.labelErrorPrice.Size = new System.Drawing.Size(46, 17);
            this.labelErrorPrice.TabIndex = 12;
            this.labelErrorPrice.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnGiuaKi.Properties.Resources.validate_icon_error;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panelErrorName
            // 
            this.panelErrorName.Controls.Add(this.labelErrorName);
            this.panelErrorName.Controls.Add(this.pictureBox1);
            this.panelErrorName.Location = new System.Drawing.Point(160, 127);
            this.panelErrorName.Name = "panelErrorName";
            this.panelErrorName.Size = new System.Drawing.Size(292, 18);
            this.panelErrorName.TabIndex = 12;
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelErrorName.Location = new System.Drawing.Point(31, 1);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(46, 17);
            this.labelErrorName.TabIndex = 12;
            this.labelErrorName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnGiuaKi.Properties.Resources.validate_icon_error;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnHuy.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.IconSize = 27;
            this.btnHuy.Location = new System.Drawing.Point(340, 311);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Rotation = 0D;
            this.btnHuy.Size = new System.Drawing.Size(112, 33);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // cbxLoai
            // 
            this.cbxLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(163, 235);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(292, 33);
            this.cbxLoai.TabIndex = 7;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txbMatKhau.BorderThickness = 1;
            this.txbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMatKhau.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMatKhau.Location = new System.Drawing.Point(160, 154);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txbMatKhau.MaxLength = 32767;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.onFocusBorderColor = System.Drawing.Color.Lime;
            this.txbMatKhau.PasswordChar = '\0';
            this.txbMatKhau.RoundedBorder = 5;
            this.txbMatKhau.Size = new System.Drawing.Size(292, 40);
            this.txbMatKhau.TabIndex = 6;
            this.txbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMatKhau.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMatKhau.TextInput = "";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.BorderColor = System.Drawing.Color.Black;
            this.txbTaiKhoan.BorderThickness = 1;
            this.txbTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTaiKhoan.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTaiKhoan.Location = new System.Drawing.Point(160, 82);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.txbTaiKhoan.MaxLength = 32767;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.onFocusBorderColor = System.Drawing.Color.Lime;
            this.txbTaiKhoan.PasswordChar = '\0';
            this.txbTaiKhoan.RoundedBorder = 5;
            this.txbTaiKhoan.Size = new System.Drawing.Size(292, 40);
            this.txbTaiKhoan.TabIndex = 5;
            this.txbTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTaiKhoan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTaiKhoan.TextInput = "";
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(51, 92);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(84, 21);
            this.Ten.TabIndex = 4;
            this.Ten.Text = "Tài Khoản";
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia.Location = new System.Drawing.Point(55, 163);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(80, 21);
            this.gia.TabIndex = 3;
            this.gia.Text = "Mật Khẩu";
            // 
            // loai
            // 
            this.loai.AutoSize = true;
            this.loai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loai.Location = new System.Drawing.Point(16, 235);
            this.loai.Name = "loai";
            this.loai.Size = new System.Drawing.Size(119, 21);
            this.loai.TabIndex = 2;
            this.loai.Text = "Loại Tài Khoản";
            // 
            // CRUDTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(563, 389);
            this.Controls.Add(this.HeaderBox);
            this.Name = "CRUDTaiKhoan";
            this.Text = "CRUDTaiKhoan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDTaiKhoan_FormClosed);
            this.HeaderBox.ResumeLayout(false);
            this.HeaderBox.PerformLayout();
            this.panelErrorPrice.ResumeLayout(false);
            this.panelErrorPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelErrorName.ResumeLayout(false);
            this.panelErrorName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HeaderBox;
        public FontAwesome.Sharp.IconButton btnSua;
        public FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panelErrorPrice;
        private System.Windows.Forms.Label labelErrorPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelErrorName;
        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHuy;
        public System.Windows.Forms.ComboBox cbxLoai;
        public JTextBox.JText_Box txbMatKhau;
        public JTextBox.JText_Box txbTaiKhoan;
        private System.Windows.Forms.Label Ten;
        public System.Windows.Forms.Label gia;
        private System.Windows.Forms.Label loai;
    }
}