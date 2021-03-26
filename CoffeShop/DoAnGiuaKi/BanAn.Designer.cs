namespace DoAnGiuaKi
{
    partial class BanAn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanAn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBill = new System.Windows.Forms.DataGridView();
            this.tenTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBill = new System.Windows.Forms.Panel();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.clockprogress = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSl = new System.Windows.Forms.TextBox();
            this.btnDat = new FontAwesome.Sharp.IconButton();
            this.cbxTA = new System.Windows.Forms.ComboBox();
            this.cbxLoaiTA = new System.Windows.Forms.ComboBox();
            this.TableList = new System.Windows.Forms.ImageList(this.components);
            this.lswData = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            this.panelBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 102);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Có khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đặt trước";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trống";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnGiuaKi.Properties.Resources.tablegreen;
            this.pictureBox3.Location = new System.Drawing.Point(354, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnGiuaKi.Properties.Resources.image_list_red;
            this.pictureBox2.Location = new System.Drawing.Point(190, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnGiuaKi.Properties.Resources.image_list2;
            this.pictureBox1.Location = new System.Drawing.Point(40, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trạng thái";
            // 
            // dataBill
            // 
            this.dataBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBill.BackgroundColor = System.Drawing.Color.White;
            this.dataBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBill.ColumnHeadersHeight = 35;
            this.dataBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTA,
            this.gia,
            this.soluong,
            this.tongtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataBill.EnableHeadersVisualStyles = false;
            this.dataBill.GridColor = System.Drawing.Color.Blue;
            this.dataBill.Location = new System.Drawing.Point(3, 165);
            this.dataBill.Name = "dataBill";
            this.dataBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataBill.RowHeadersVisible = false;
            this.dataBill.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataBill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataBill.RowTemplate.Height = 24;
            this.dataBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBill.Size = new System.Drawing.Size(619, 326);
            this.dataBill.TabIndex = 0;
            // 
            // tenTA
            // 
            this.tenTA.DataPropertyName = "tenTA";
            this.tenTA.FillWeight = 85.5043F;
            this.tenTA.HeaderText = "Thức Ăn";
            this.tenTA.MinimumWidth = 10;
            this.tenTA.Name = "tenTA";
            this.tenTA.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.FillWeight = 24.79625F;
            this.gia.HeaderText = "Giá Tiền";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.FillWeight = 24.79625F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "Tongtien";
            this.tongtien.FillWeight = 24.79625F;
            this.tongtien.HeaderText = "Thành Tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // panelBill
            // 
            this.panelBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBill.BackColor = System.Drawing.Color.White;
            this.panelBill.Controls.Add(this.btnThanhToan);
            this.panelBill.Controls.Add(this.clockprogress);
            this.panelBill.Controls.Add(this.label2);
            this.panelBill.Controls.Add(this.txbSl);
            this.panelBill.Controls.Add(this.btnDat);
            this.panelBill.Controls.Add(this.cbxTA);
            this.panelBill.Controls.Add(this.cbxLoaiTA);
            this.panelBill.Controls.Add(this.dataBill);
            this.panelBill.Location = new System.Drawing.Point(510, 12);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(625, 588);
            this.panelBill.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnThanhToan.IconColor = System.Drawing.Color.White;
            this.btnThanhToan.IconSize = 32;
            this.btnThanhToan.Location = new System.Drawing.Point(451, 535);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Rotation = 0D;
            this.btnThanhToan.Size = new System.Drawing.Size(161, 41);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // clockprogress
            // 
            this.clockprogress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.clockprogress.AnimationSpeed = 500;
            this.clockprogress.BackColor = System.Drawing.Color.Transparent;
            this.clockprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockprogress.ForeColor = System.Drawing.Color.White;
            this.clockprogress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.clockprogress.InnerMargin = 2;
            this.clockprogress.InnerWidth = -1;
            this.clockprogress.Location = new System.Drawing.Point(442, 3);
            this.clockprogress.MarqueeAnimationSpeed = 5000;
            this.clockprogress.Name = "clockprogress";
            this.clockprogress.OuterColor = System.Drawing.Color.Gray;
            this.clockprogress.OuterMargin = -25;
            this.clockprogress.OuterWidth = 25;
            this.clockprogress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clockprogress.ProgressWidth = 10;
            this.clockprogress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockprogress.Size = new System.Drawing.Size(170, 133);
            this.clockprogress.StartAngle = 270;
            this.clockprogress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.clockprogress.SubscriptColor = System.Drawing.Color.White;
            this.clockprogress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.clockprogress.SubscriptText = "";
            this.clockprogress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clockprogress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.clockprogress.SuperscriptText = "";
            this.clockprogress.TabIndex = 6;
            this.clockprogress.Text = "00:00:00";
            this.clockprogress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.clockprogress.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng";
            // 
            // txbSl
            // 
            this.txbSl.Location = new System.Drawing.Point(304, 78);
            this.txbSl.Name = "txbSl";
            this.txbSl.Size = new System.Drawing.Size(59, 22);
            this.txbSl.TabIndex = 4;
            this.txbSl.Text = "1";
            // 
            // btnDat
            // 
            this.btnDat.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDat.FlatAppearance.BorderSize = 0;
            this.btnDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDat.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnDat.IconColor = System.Drawing.Color.White;
            this.btnDat.IconSize = 30;
            this.btnDat.Location = new System.Drawing.Point(221, 20);
            this.btnDat.Name = "btnDat";
            this.btnDat.Rotation = 0D;
            this.btnDat.Size = new System.Drawing.Size(142, 35);
            this.btnDat.TabIndex = 3;
            this.btnDat.Text = "Đặt Món";
            this.btnDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDat.UseVisualStyleBackColor = false;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // cbxTA
            // 
            this.cbxTA.FormattingEnabled = true;
            this.cbxTA.Location = new System.Drawing.Point(15, 71);
            this.cbxTA.Name = "cbxTA";
            this.cbxTA.Size = new System.Drawing.Size(186, 24);
            this.cbxTA.TabIndex = 2;
            // 
            // cbxLoaiTA
            // 
            this.cbxLoaiTA.FormattingEnabled = true;
            this.cbxLoaiTA.Location = new System.Drawing.Point(15, 20);
            this.cbxLoaiTA.Name = "cbxLoaiTA";
            this.cbxLoaiTA.Size = new System.Drawing.Size(186, 24);
            this.cbxLoaiTA.TabIndex = 1;
            this.cbxLoaiTA.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiTA_SelectedIndexChanged);
            // 
            // TableList
            // 
            this.TableList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TableList.ImageStream")));
            this.TableList.TransparentColor = System.Drawing.Color.Transparent;
            this.TableList.Images.SetKeyName(0, "image-list2.jpg");
            this.TableList.Images.SetKeyName(1, "image-list-red.jpg");
            this.TableList.Images.SetKeyName(2, "tablegreen.jfif");
            // 
            // lswData
            // 
            this.lswData.HideSelection = false;
            this.lswData.LargeImageList = this.TableList;
            this.lswData.Location = new System.Drawing.Point(23, 15);
            this.lswData.Name = "lswData";
            this.lswData.Size = new System.Drawing.Size(458, 448);
            this.lswData.TabIndex = 4;
            this.lswData.UseCompatibleStateImageBehavior = false;
            this.lswData.SelectedIndexChanged += new System.EventHandler(this.lswData_SelectedIndexChanged);
            // 
            // BanAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1161, 612);
            this.Controls.Add(this.lswData);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanAn";
            this.Text = "BanAn";
            this.Load += new System.EventHandler(this.BanAn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataBill;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSl;
        private FontAwesome.Sharp.IconButton btnDat;
        private System.Windows.Forms.ComboBox cbxTA;
        private System.Windows.Forms.ComboBox cbxLoaiTA;
        private CircularProgressBar.CircularProgressBar clockprogress;
        private System.Windows.Forms.ImageList TableList;
        private System.Windows.Forms.ListView lswData;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}