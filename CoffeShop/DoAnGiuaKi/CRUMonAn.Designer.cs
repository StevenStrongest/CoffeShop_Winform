namespace DoAnGiuaKi
{
    partial class CRUMonAn
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
            this.panelID = new System.Windows.Forms.Panel();
            this.txbID = new JTextBox.JText_Box();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txbGia = new JTextBox.JText_Box();
            this.txbTen = new JTextBox.JText_Box();
            this.Ten = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.Label();
            this.loai = new System.Windows.Forms.Label();
            this.HeaderBox.SuspendLayout();
            this.panelID.SuspendLayout();
            this.panelErrorPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelErrorName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBox
            // 
            this.HeaderBox.Controls.Add(this.panelID);
            this.HeaderBox.Controls.Add(this.btnSua);
            this.HeaderBox.Controls.Add(this.btnThem);
            this.HeaderBox.Controls.Add(this.panelErrorPrice);
            this.HeaderBox.Controls.Add(this.panelErrorName);
            this.HeaderBox.Controls.Add(this.btnHuy);
            this.HeaderBox.Controls.Add(this.cbxLoai);
            this.HeaderBox.Controls.Add(this.txbGia);
            this.HeaderBox.Controls.Add(this.txbTen);
            this.HeaderBox.Controls.Add(this.Ten);
            this.HeaderBox.Controls.Add(this.gia);
            this.HeaderBox.Controls.Add(this.loai);
            this.HeaderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderBox.Location = new System.Drawing.Point(12, 12);
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(637, 388);
            this.HeaderBox.TabIndex = 0;
            this.HeaderBox.TabStop = false;
            this.HeaderBox.Text = "Thêm món ăn";
            // 
            // panelID
            // 
            this.panelID.Controls.Add(this.txbID);
            this.panelID.Controls.Add(this.label1);
            this.panelID.Location = new System.Drawing.Point(62, 29);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(509, 62);
            this.panelID.TabIndex = 17;
            this.panelID.Visible = false;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txbID.BorderColor = System.Drawing.Color.Black;
            this.txbID.BorderThickness = 1;
            this.txbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbID.Location = new System.Drawing.Point(58, 10);
            this.txbID.Margin = new System.Windows.Forms.Padding(5);
            this.txbID.MaxLength = 32767;
            this.txbID.Name = "txbID";
            this.txbID.onFocusBorderColor = System.Drawing.Color.Black;
            this.txbID.PasswordChar = '\0';
            this.txbID.RoundedBorder = 5;
            this.txbID.Size = new System.Drawing.Size(292, 40);
            this.txbID.TabIndex = 16;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbID.TextInput = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
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
            this.btnSua.Location = new System.Drawing.Point(170, 330);
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
            this.btnThem.Location = new System.Drawing.Point(170, 330);
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
            this.panelErrorPrice.Location = new System.Drawing.Point(124, 219);
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
            this.panelErrorName.Location = new System.Drawing.Point(121, 146);
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
            this.btnHuy.Location = new System.Drawing.Point(301, 330);
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
            this.cbxLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(124, 254);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(292, 33);
            this.cbxLoai.TabIndex = 7;
            // 
            // txbGia
            // 
            this.txbGia.BorderColor = System.Drawing.Color.Black;
            this.txbGia.BorderThickness = 1;
            this.txbGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGia.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGia.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbGia.Location = new System.Drawing.Point(121, 173);
            this.txbGia.Margin = new System.Windows.Forms.Padding(5);
            this.txbGia.MaxLength = 32767;
            this.txbGia.Name = "txbGia";
            this.txbGia.onFocusBorderColor = System.Drawing.Color.Black;
            this.txbGia.PasswordChar = '\0';
            this.txbGia.RoundedBorder = 5;
            this.txbGia.Size = new System.Drawing.Size(292, 40);
            this.txbGia.TabIndex = 6;
            this.txbGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbGia.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbGia.TextInput = "";
            this.txbGia.Click += new System.EventHandler(this.txbGia_Click);
            // 
            // txbTen
            // 
            this.txbTen.BorderColor = System.Drawing.Color.Black;
            this.txbTen.BorderThickness = 1;
            this.txbTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.FontStyles = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTen.Location = new System.Drawing.Point(121, 101);
            this.txbTen.Margin = new System.Windows.Forms.Padding(5);
            this.txbTen.MaxLength = 32767;
            this.txbTen.Name = "txbTen";
            this.txbTen.onFocusBorderColor = System.Drawing.Color.Black;
            this.txbTen.PasswordChar = '\0';
            this.txbTen.RoundedBorder = 5;
            this.txbTen.Size = new System.Drawing.Size(292, 40);
            this.txbTen.TabIndex = 5;
            this.txbTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTen.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTen.TextInput = "";
            this.txbTen.Click += new System.EventHandler(this.txbTen_Click);
            this.txbTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTen_KeyPress);
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(47, 111);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(66, 21);
            this.Ten.TabIndex = 4;
            this.Ten.Text = "Món Ăn";
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia.Location = new System.Drawing.Point(62, 182);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(34, 21);
            this.gia.TabIndex = 3;
            this.gia.Text = "Giá";
            // 
            // loai
            // 
            this.loai.AutoSize = true;
            this.loai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loai.Location = new System.Drawing.Point(56, 260);
            this.loai.Name = "loai";
            this.loai.Size = new System.Drawing.Size(40, 21);
            this.loai.TabIndex = 2;
            this.loai.Text = "Loại";
            // 
            // CRUMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(663, 406);
            this.Controls.Add(this.HeaderBox);
            this.Name = "CRUMonAn";
            this.Text = "CRUMonAn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUMonAn_FormClosed);
            this.Load += new System.EventHandler(this.CRUMonAn_Load);
            this.HeaderBox.ResumeLayout(false);
            this.HeaderBox.PerformLayout();
            this.panelID.ResumeLayout(false);
            this.panelID.PerformLayout();
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
        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Label loai;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelErrorName;
        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.Panel panelErrorPrice;
        private System.Windows.Forms.Label labelErrorPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label gia;
        public JTextBox.JText_Box txbGia;
        public JTextBox.JText_Box txbTen;
        public System.Windows.Forms.ComboBox cbxLoai;
        public FontAwesome.Sharp.IconButton btnThem;
        public FontAwesome.Sharp.IconButton btnSua;
        public JTextBox.JText_Box txbID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelID;
    }
}