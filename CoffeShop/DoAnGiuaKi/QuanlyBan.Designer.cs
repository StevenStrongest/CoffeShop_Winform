namespace DoAnGiuaKi
{
    partial class QuanlyBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPre = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.idBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tầng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnGiuaKi.Properties.Resources.table;
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
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý bàn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 465);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Controls.Add(this.panelSearch);
            this.panel3.Controls.Add(this.txbSearch);
            this.panel3.Controls.Add(this.Search);
            this.panel3.Controls.Add(this.dataTable);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 418);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPre);
            this.panel4.Location = new System.Drawing.Point(21, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1084, 37);
            this.panel4.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconSize = 35;
            this.btnNext.Location = new System.Drawing.Point(964, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(58, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.Black;
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPre.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPre.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnPre.IconColor = System.Drawing.Color.White;
            this.btnPre.IconSize = 35;
            this.btnPre.Location = new System.Drawing.Point(1022, 0);
            this.btnPre.Name = "btnPre";
            this.btnPre.Rotation = 0D;
            this.btnPre.Size = new System.Drawing.Size(62, 37);
            this.btnPre.TabIndex = 0;
            this.btnPre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Green;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(169, 16);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(161, 37);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Đặt trước";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Red;
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
            this.panelSearch.Location = new System.Drawing.Point(794, 50);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(300, 3);
            this.panelSearch.TabIndex = 6;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Location = new System.Drawing.Point(794, 25);
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
            this.Search.Location = new System.Drawing.Point(751, 25);
            this.Search.Name = "Search";
            this.Search.Rotation = 0D;
            this.Search.Size = new System.Drawing.Size(37, 28);
            this.Search.TabIndex = 2;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToOrderColumns = true;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBan,
            this.tenBan,
            this.Tầng,
            this.trangthai,
            this.sua});
            this.dataTable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataTable.Location = new System.Drawing.Point(21, 59);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(1081, 301);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // idBan
            // 
            this.idBan.DataPropertyName = "idBan";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.idBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.idBan.FillWeight = 50F;
            this.idBan.HeaderText = "ID";
            this.idBan.MinimumWidth = 6;
            this.idBan.Name = "idBan";
            this.idBan.ReadOnly = true;
            // 
            // tenBan
            // 
            this.tenBan.DataPropertyName = "tenBan";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.tenBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenBan.FillWeight = 80F;
            this.tenBan.HeaderText = "Bàn";
            this.tenBan.MinimumWidth = 6;
            this.tenBan.Name = "tenBan";
            this.tenBan.ReadOnly = true;
            // 
            // Tầng
            // 
            this.Tầng.DataPropertyName = "idTang";
            this.Tầng.HeaderText = "Tầng";
            this.Tầng.MinimumWidth = 6;
            this.Tầng.Name = "Tầng";
            this.Tầng.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.trangthai.DefaultCellStyle = dataGridViewCellStyle3;
            this.trangthai.FillWeight = 85.47237F;
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // sua
            // 
            this.sua.DataPropertyName = "Xóa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = "Xóa";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.sua.DefaultCellStyle = dataGridViewCellStyle4;
            this.sua.FillWeight = 60F;
            this.sua.HeaderText = "Thao tác";
            this.sua.MinimumWidth = 6;
            this.sua.Name = "sua";
            this.sua.ReadOnly = true;
            this.sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sua.ToolTipText = "Thêm mới";
            // 
            // QuanlyBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1143, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanlyBan";
            this.Text = "QuanlyBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private FontAwesome.Sharp.IconButton Search;
        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tầng;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
    }
}