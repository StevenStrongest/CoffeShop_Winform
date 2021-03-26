namespace DoAnGiuaKi
{
    partial class CRUDDatBAn
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
            this.label6 = new System.Windows.Forms.Label();
            this.txbGhichu = new System.Windows.Forms.TextBox();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDatBan = new System.Windows.Forms.DataGridView();
            this.iddat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnDat = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbGhichu);
            this.panel1.Controls.Add(this.rdoTrue);
            this.panel1.Controls.Add(this.rdoFalse);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpNgay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxBan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbSdt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTenKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 398);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ghi chú";
            // 
            // txbGhichu
            // 
            this.txbGhichu.Location = new System.Drawing.Point(135, 294);
            this.txbGhichu.Multiline = true;
            this.txbGhichu.Name = "txbGhichu";
            this.txbGhichu.Size = new System.Drawing.Size(254, 89);
            this.txbGhichu.TabIndex = 11;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(260, 235);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(119, 21);
            this.rdoTrue.TabIndex = 10;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "Đã thanh toán";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(135, 235);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(70, 21);
            this.rdoFalse.TabIndex = 9;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "Không";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trả trước";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(135, 176);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(254, 22);
            this.dtpNgay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày đặt";
            // 
            // cbxBan
            // 
            this.cbxBan.FormattingEnabled = true;
            this.cbxBan.Location = new System.Drawing.Point(135, 114);
            this.cbxBan.Name = "cbxBan";
            this.cbxBan.Size = new System.Drawing.Size(254, 24);
            this.cbxBan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bàn";
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(135, 62);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(254, 22);
            this.txbSdt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại";
            // 
            // txbTenKhachHang
            // 
            this.txbTenKhachHang.Location = new System.Drawing.Point(135, 8);
            this.txbTenKhachHang.Name = "txbTenKhachHang";
            this.txbTenKhachHang.Size = new System.Drawing.Size(254, 22);
            this.txbTenKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataDatBan);
            this.panel2.Location = new System.Drawing.Point(480, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 459);
            this.panel2.TabIndex = 1;
            // 
            // dataDatBan
            // 
            this.dataDatBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDatBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddat,
            this.tenKhachHang,
            this.sdt,
            this.Ban,
            this.NgayDat,
            this.trangthai,
            this.ghichu});
            this.dataDatBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDatBan.Location = new System.Drawing.Point(0, 0);
            this.dataDatBan.Name = "dataDatBan";
            this.dataDatBan.RowHeadersWidth = 51;
            this.dataDatBan.RowTemplate.Height = 24;
            this.dataDatBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDatBan.Size = new System.Drawing.Size(977, 459);
            this.dataDatBan.TabIndex = 0;
            // 
            // iddat
            // 
            this.iddat.DataPropertyName = "idDat";
            this.iddat.FillWeight = 55F;
            this.iddat.HeaderText = "ID";
            this.iddat.MinimumWidth = 6;
            this.iddat.Name = "iddat";
            this.iddat.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.FillWeight = 82.35294F;
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.MinimumWidth = 6;
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.FillWeight = 82.35294F;
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // Ban
            // 
            this.Ban.DataPropertyName = "tenBan";
            this.Ban.FillWeight = 82.35294F;
            this.Ban.HeaderText = "Bàn";
            this.Ban.MinimumWidth = 6;
            this.Ban.Name = "Ban";
            this.Ban.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.FillWeight = 82.35294F;
            this.NgayDat.HeaderText = "Ngày Đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.FillWeight = 82.35294F;
            this.trangthai.HeaderText = "Trả trước";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "Ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbHeader);
            this.panel3.Location = new System.Drawing.Point(480, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 55);
            this.panel3.TabIndex = 2;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(255, 16);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(106, 25);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "ĐẶT BÀN";
            // 
            // btnDat
            // 
            this.btnDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDat.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDat.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnDat.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDat.IconSize = 32;
            this.btnDat.Location = new System.Drawing.Point(310, 515);
            this.btnDat.Name = "btnDat";
            this.btnDat.Rotation = 0D;
            this.btnDat.Size = new System.Drawing.Size(134, 42);
            this.btnDat.TabIndex = 3;
            this.btnDat.Text = "Đặt Bàn";
            this.btnDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDat.UseVisualStyleBackColor = false;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHuy.IconColor = System.Drawing.Color.Black;
            this.btnHuy.IconSize = 16;
            this.btnHuy.Location = new System.Drawing.Point(768, 577);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Rotation = 0D;
            this.btnHuy.Size = new System.Drawing.Size(328, 55);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy Đặt";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // CRUDDatBAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1469, 680);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDDatBAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDDatBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDatBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataDatBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbGhichu;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenKhachHang;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDat;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}