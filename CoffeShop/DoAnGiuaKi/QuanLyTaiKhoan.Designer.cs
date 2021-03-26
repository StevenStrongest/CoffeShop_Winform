namespace DoAnGiuaKi
{
    partial class QuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.dataAcc = new System.Windows.Forms.DataGridView();
            this.tenTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnGiuaKi.Properties.Resources.aminacc;
            this.pictureBox1.Location = new System.Drawing.Point(1022, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 465);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Controls.Add(this.panelSearch);
            this.panel3.Controls.Add(this.txbSearch);
            this.panel3.Controls.Add(this.Search);
            this.panel3.Controls.Add(this.dataAcc);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 429);
            this.panel3.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAdd.IconColor = System.Drawing.Color.White;
            this.BtnAdd.IconSize = 25;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(21, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(129, 37);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Black;
            this.panelSearch.Location = new System.Drawing.Point(807, 50);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(300, 3);
            this.panelSearch.TabIndex = 6;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Location = new System.Drawing.Point(807, 25);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(295, 20);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.Text = "Tìm Kiếm";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            this.txbSearch.Leave += new System.EventHandler(this.txbSearch_Leave);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DimGray;
            this.Search.Enabled = false;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.White;
            this.Search.IconSize = 25;
            this.Search.Location = new System.Drawing.Point(764, 25);
            this.Search.Name = "Search";
            this.Search.Rotation = 0D;
            this.Search.Size = new System.Drawing.Size(37, 28);
            this.Search.TabIndex = 2;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // dataAcc
            // 
            this.dataAcc.AllowUserToOrderColumns = true;
            this.dataAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAcc.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTA,
            this.gia,
            this.loaiTk,
            this.sua});
            this.dataAcc.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataAcc.Location = new System.Drawing.Point(21, 59);
            this.dataAcc.Name = "dataAcc";
            this.dataAcc.ReadOnly = true;
            this.dataAcc.RowHeadersVisible = false;
            this.dataAcc.RowHeadersWidth = 51;
            this.dataAcc.RowTemplate.Height = 24;
            this.dataAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAcc.Size = new System.Drawing.Size(1095, 347);
            this.dataAcc.TabIndex = 0;
            this.dataAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAcc_CellContentClick);
            // 
            // tenTA
            // 
            this.tenTA.DataPropertyName = "tenTaiKhoan";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tenTA.DefaultCellStyle = dataGridViewCellStyle5;
            this.tenTA.FillWeight = 150F;
            this.tenTA.HeaderText = "Tài khoản";
            this.tenTA.MinimumWidth = 6;
            this.tenTA.Name = "tenTA";
            this.tenTA.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "matkhau";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.gia.DefaultCellStyle = dataGridViewCellStyle6;
            this.gia.FillWeight = 80F;
            this.gia.HeaderText = "Mật khẩu";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // loaiTk
            // 
            this.loaiTk.DataPropertyName = "loaiTK";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.loaiTk.DefaultCellStyle = dataGridViewCellStyle7;
            this.loaiTk.FillWeight = 85.47237F;
            this.loaiTk.HeaderText = "Quyền";
            this.loaiTk.MinimumWidth = 6;
            this.loaiTk.Name = "loaiTk";
            this.loaiTk.ReadOnly = true;
            // 
            // sua
            // 
            this.sua.DataPropertyName = "Xóa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.NullValue = "Xóa";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Lime;
            this.sua.DefaultCellStyle = dataGridViewCellStyle8;
            this.sua.FillWeight = 60F;
            this.sua.HeaderText = "Thao tác";
            this.sua.MinimumWidth = 6;
            this.sua.Name = "sua";
            this.sua.ReadOnly = true;
            this.sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sua.ToolTipText = "Thêm mới";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1143, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private FontAwesome.Sharp.IconButton Search;
        public System.Windows.Forms.DataGridView dataAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTk;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
    }
}