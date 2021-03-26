namespace DoAnGiuaKi
{
    partial class CRUDBan
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
            this.lbTenBan = new System.Windows.Forms.Label();
            this.txbTenBan = new System.Windows.Forms.TextBox();
            this.lbTang = new System.Windows.Forms.Label();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.Location = new System.Drawing.Point(24, 66);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(62, 17);
            this.lbTenBan.TabIndex = 0;
            this.lbTenBan.Text = "Tên Bàn";
            // 
            // txbTenBan
            // 
            this.txbTenBan.Location = new System.Drawing.Point(92, 66);
            this.txbTenBan.Name = "txbTenBan";
            this.txbTenBan.Size = new System.Drawing.Size(209, 22);
            this.txbTenBan.TabIndex = 1;
            // 
            // lbTang
            // 
            this.lbTang.AutoSize = true;
            this.lbTang.Location = new System.Drawing.Point(27, 127);
            this.lbTang.Name = "lbTang";
            this.lbTang.Size = new System.Drawing.Size(41, 17);
            this.lbTang.TabIndex = 2;
            this.lbTang.Text = "Tầng";
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(92, 127);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(209, 24);
            this.cbTang.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(114, 194);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(88, 33);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnHuy.IconColor = System.Drawing.Color.Red;
            this.btnHuy.IconSize = 25;
            this.btnHuy.Location = new System.Drawing.Point(222, 194);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Rotation = 0D;
            this.btnHuy.Size = new System.Drawing.Size(88, 33);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DarkRed;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(305, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(37, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CRUDBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 271);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbTang);
            this.Controls.Add(this.lbTang);
            this.Controls.Add(this.txbTenBan);
            this.Controls.Add(this.lbTenBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDBan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDBan_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.TextBox txbTenBan;
        private System.Windows.Forms.Label lbTang;
        private System.Windows.Forms.ComboBox cbTang;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}