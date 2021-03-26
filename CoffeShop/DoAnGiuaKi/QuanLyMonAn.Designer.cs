namespace DoAnGiuaKi
{
    partial class QuanLyMonAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.dataFood = new System.Windows.Forms.DataGridView();
            this.idTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idloaiTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1161, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnGiuaKi.Properties.Resources.fork;
            this.pictureBox1.Location = new System.Drawing.Point(1037, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thực đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.dataFood);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 417);
            this.panel1.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelSearch.Location = new System.Drawing.Point(801, 50);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(300, 3);
            this.panelSearch.TabIndex = 6;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Location = new System.Drawing.Point(801, 25);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(295, 20);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.Text = "Tìm Kiếm";
            this.txbSearch.Click += new System.EventHandler(this.textBox1_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbSearch.Leave += new System.EventHandler(this.textBox1_Leave);
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
            this.Search.Location = new System.Drawing.Point(758, 25);
            this.Search.Name = "Search";
            this.Search.Rotation = 0D;
            this.Search.Size = new System.Drawing.Size(37, 28);
            this.Search.TabIndex = 2;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // dataFood
            // 
            this.dataFood.AllowUserToOrderColumns = true;
            this.dataFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFood.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTA,
            this.tenTA,
            this.gia,
            this.idloaiTA,
            this.sua,
            this.Xoa});
            this.dataFood.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataFood.Location = new System.Drawing.Point(21, 59);
            this.dataFood.Name = "dataFood";
            this.dataFood.ReadOnly = true;
            this.dataFood.RowHeadersVisible = false;
            this.dataFood.RowHeadersWidth = 51;
            this.dataFood.RowTemplate.Height = 24;
            this.dataFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFood.Size = new System.Drawing.Size(1088, 347);
            this.dataFood.TabIndex = 0;
            this.dataFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFood_CellContentClick);
            // 
            // idTA
            // 
            this.idTA.DataPropertyName = "idTA";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.idTA.DefaultCellStyle = dataGridViewCellStyle1;
            this.idTA.FillWeight = 40F;
            this.idTA.HeaderText = "ID";
            this.idTA.MinimumWidth = 6;
            this.idTA.Name = "idTA";
            this.idTA.ReadOnly = true;
            // 
            // tenTA
            // 
            this.tenTA.DataPropertyName = "tenTA";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.tenTA.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenTA.FillWeight = 150F;
            this.tenTA.HeaderText = "Món Ăn";
            this.tenTA.MinimumWidth = 6;
            this.tenTA.Name = "tenTA";
            this.tenTA.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.gia.DefaultCellStyle = dataGridViewCellStyle3;
            this.gia.FillWeight = 80F;
            this.gia.HeaderText = "Giá tiền";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // idloaiTA
            // 
            this.idloaiTA.DataPropertyName = "tenLoai";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.idloaiTA.DefaultCellStyle = dataGridViewCellStyle4;
            this.idloaiTA.FillWeight = 85.47237F;
            this.idloaiTA.HeaderText = "Loại";
            this.idloaiTA.MinimumWidth = 6;
            this.idloaiTA.Name = "idloaiTA";
            this.idloaiTA.ReadOnly = true;
            // 
            // sua
            // 
            this.sua.DataPropertyName = "Sửa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = "Sửa";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            this.sua.DefaultCellStyle = dataGridViewCellStyle5;
            this.sua.FillWeight = 60F;
            this.sua.HeaderText = "Thao tác";
            this.sua.MinimumWidth = 6;
            this.sua.Name = "sua";
            this.sua.ReadOnly = true;
            this.sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sua.ToolTipText = "Thêm mới";
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "Xóa";
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle6;
            this.Xoa.FillWeight = 50F;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.HeaderText = "";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xoa.Text = "Xoa";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(96, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 36);
            this.panel2.TabIndex = 2;
            // 
            // QuanLyMonAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1161, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyMonAn";
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Search;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idloaiTA;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        public System.Windows.Forms.DataGridView dataFood;
    }
}

