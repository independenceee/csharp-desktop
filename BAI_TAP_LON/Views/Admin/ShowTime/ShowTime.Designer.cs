namespace BAI_TAP_LON.Views.Admin.ShowTime
{
    partial class ShowTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtFind = new Krypton.Toolkit.KryptonTextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dateNgayChose = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnP05 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnP04 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnP03 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnP02 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnP01 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnToanBo = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhSachXuatChieu = new System.Windows.Forms.DataGridView();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXuatChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 6;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimKiem.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(457, 41);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 45);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(22, 59);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtFind.Size = new System.Drawing.Size(401, 25);
            this.txtFind.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtFind.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtFind.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.TabIndex = 13;
            this.txtFind.Text = "Tìm kiếm";
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 6;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(841, 11);
            this.btnThem.Margin = new System.Windows.Forms.Padding(20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 45);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "+ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BorderRadius = 6;
            this.btnChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTiet.FillColor = System.Drawing.Color.LimeGreen;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChiTiet.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnChiTiet.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnChiTiet.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(1004, 11);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(20);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(125, 45);
            this.btnChiTiet.TabIndex = 15;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.Controls.Add(this.dateNgayChose);
            this.pnlHeader.Controls.Add(this.btnTimKiem);
            this.pnlHeader.Controls.Add(this.txtFind);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1312, 110);
            this.pnlHeader.TabIndex = 8;
            // 
            // dateNgayChose
            // 
            this.dateNgayChose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateNgayChose.Checked = true;
            this.dateNgayChose.FillColor = System.Drawing.Color.White;
            this.dateNgayChose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayChose.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayChose.Location = new System.Drawing.Point(982, 41);
            this.dateNgayChose.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayChose.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayChose.Name = "dateNgayChose";
            this.dateNgayChose.Size = new System.Drawing.Size(245, 36);
            this.dateNgayChose.TabIndex = 17;
            this.dateNgayChose.Value = new System.DateTime(2023, 11, 2, 0, 31, 34, 421);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnP05);
            this.panel2.Controls.Add(this.btnP04);
            this.panel2.Controls.Add(this.btnP03);
            this.panel2.Controls.Add(this.btnP02);
            this.panel2.Controls.Add(this.btnP01);
            this.panel2.Controls.Add(this.btnToanBo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 576);
            this.panel2.TabIndex = 13;
            // 
            // btnP05
            // 
            this.btnP05.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP05.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP05.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP05.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP05.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnP05.FillColor = System.Drawing.Color.Transparent;
            this.btnP05.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP05.ForeColor = System.Drawing.Color.Black;
            this.btnP05.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnP05.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnP05.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnP05.Location = new System.Drawing.Point(0, 220);
            this.btnP05.Name = "btnP05";
            this.btnP05.Size = new System.Drawing.Size(150, 44);
            this.btnP05.TabIndex = 5;
            this.btnP05.Text = "Phòng 05";
            this.btnP05.Click += new System.EventHandler(this.btnP05_Click);
            // 
            // btnP04
            // 
            this.btnP04.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP04.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP04.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP04.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP04.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnP04.FillColor = System.Drawing.Color.Transparent;
            this.btnP04.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP04.ForeColor = System.Drawing.Color.Black;
            this.btnP04.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnP04.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnP04.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnP04.Location = new System.Drawing.Point(0, 176);
            this.btnP04.Name = "btnP04";
            this.btnP04.Size = new System.Drawing.Size(150, 44);
            this.btnP04.TabIndex = 4;
            this.btnP04.Text = "Phòng 04";
            this.btnP04.Click += new System.EventHandler(this.btnP04_Click);
            // 
            // btnP03
            // 
            this.btnP03.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP03.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP03.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP03.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP03.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnP03.FillColor = System.Drawing.Color.Transparent;
            this.btnP03.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP03.ForeColor = System.Drawing.Color.Black;
            this.btnP03.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnP03.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnP03.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnP03.Location = new System.Drawing.Point(0, 132);
            this.btnP03.Name = "btnP03";
            this.btnP03.Size = new System.Drawing.Size(150, 44);
            this.btnP03.TabIndex = 3;
            this.btnP03.Text = "Phòng 03";
            this.btnP03.Click += new System.EventHandler(this.btnP03_Click);
            // 
            // btnP02
            // 
            this.btnP02.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP02.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP02.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP02.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP02.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnP02.FillColor = System.Drawing.Color.Transparent;
            this.btnP02.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP02.ForeColor = System.Drawing.Color.Black;
            this.btnP02.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnP02.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnP02.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnP02.Location = new System.Drawing.Point(0, 88);
            this.btnP02.Name = "btnP02";
            this.btnP02.Size = new System.Drawing.Size(150, 44);
            this.btnP02.TabIndex = 2;
            this.btnP02.Text = "Phòng 02";
            this.btnP02.Click += new System.EventHandler(this.btnP02_Click);
            // 
            // btnP01
            // 
            this.btnP01.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP01.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP01.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP01.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP01.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnP01.FillColor = System.Drawing.Color.Transparent;
            this.btnP01.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP01.ForeColor = System.Drawing.Color.Black;
            this.btnP01.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnP01.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnP01.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnP01.Location = new System.Drawing.Point(0, 44);
            this.btnP01.Name = "btnP01";
            this.btnP01.Size = new System.Drawing.Size(150, 44);
            this.btnP01.TabIndex = 1;
            this.btnP01.Text = "Phòng 01";
            this.btnP01.Click += new System.EventHandler(this.btnP01_Click);
            // 
            // btnToanBo
            // 
            this.btnToanBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToanBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToanBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToanBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToanBo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToanBo.FillColor = System.Drawing.Color.Transparent;
            this.btnToanBo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToanBo.ForeColor = System.Drawing.Color.Black;
            this.btnToanBo.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnToanBo.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnToanBo.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnToanBo.Location = new System.Drawing.Point(0, 0);
            this.btnToanBo.Name = "btnToanBo";
            this.btnToanBo.Size = new System.Drawing.Size(150, 44);
            this.btnToanBo.TabIndex = 0;
            this.btnToanBo.Text = "Toàn bộ";
            this.btnToanBo.Click += new System.EventHandler(this.btnToanBo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 686);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 66);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1227, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 576);
            this.panel3.TabIndex = 14;
            // 
            // dgvDanhSachXuatChieu
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDanhSachXuatChieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachXuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachXuatChieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachXuatChieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachXuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXuatChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachXuatChieu.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachXuatChieu.Location = new System.Drawing.Point(150, 110);
            this.dgvDanhSachXuatChieu.Name = "dgvDanhSachXuatChieu";
            this.dgvDanhSachXuatChieu.ReadOnly = true;
            this.dgvDanhSachXuatChieu.RowHeadersWidth = 51;
            this.dgvDanhSachXuatChieu.RowTemplate.Height = 24;
            this.dgvDanhSachXuatChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachXuatChieu.Size = new System.Drawing.Size(1077, 576);
            this.dgvDanhSachXuatChieu.TabIndex = 15;
            this.dgvDanhSachXuatChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachXuatChieu_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderRadius = 6;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Crimson;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1160, 11);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 45);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            // 
            // ShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.dgvDanhSachXuatChieu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ShowTime";
            this.Text = "ShowTime";
            this.Load += new System.EventHandler(this.ShowTime_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXuatChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Krypton.Toolkit.KryptonTextBox txtFind;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnChiTiet;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhSachXuatChieu;
        private Guna.UI2.WinForms.Guna2TileButton btnToanBo;
        private Guna.UI2.WinForms.Guna2TileButton btnP05;
        private Guna.UI2.WinForms.Guna2TileButton btnP04;
        private Guna.UI2.WinForms.Guna2TileButton btnP03;
        private Guna.UI2.WinForms.Guna2TileButton btnP02;
        private Guna.UI2.WinForms.Guna2TileButton btnP01;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayChose;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}