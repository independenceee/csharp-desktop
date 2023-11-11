namespace BAI_TAP_LON.Components
{
    partial class PhimControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnChinhSua = new FontAwesome.Sharp.IconButton();
            this.lblNgayKhoiChieu = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblDaoDien = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 36;
            this.btnXoa.Location = new System.Drawing.Point(1051, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(49, 46);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnChinhSua.IconColor = System.Drawing.Color.Black;
            this.btnChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChinhSua.IconSize = 36;
            this.btnChinhSua.Location = new System.Drawing.Point(996, 10);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(49, 46);
            this.btnChinhSua.TabIndex = 6;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // lblNgayKhoiChieu
            // 
            this.lblNgayKhoiChieu.AutoSize = true;
            this.lblNgayKhoiChieu.Location = new System.Drawing.Point(821, 26);
            this.lblNgayKhoiChieu.Name = "lblNgayKhoiChieu";
            this.lblNgayKhoiChieu.Size = new System.Drawing.Size(103, 16);
            this.lblNgayKhoiChieu.TabIndex = 11;
            this.lblNgayKhoiChieu.Text = "Ngày khởi chiếu";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(712, 26);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(56, 16);
            this.lblTheLoai.TabIndex = 10;
            this.lblTheLoai.Text = "Thể loại";
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Location = new System.Drawing.Point(542, 26);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(91, 16);
            this.lblNuocSX.TabIndex = 9;
            this.lblNuocSX.Text = "Nước sản xuất";
            // 
            // lblDaoDien
            // 
            this.lblDaoDien.AutoSize = true;
            this.lblDaoDien.Location = new System.Drawing.Point(402, 26);
            this.lblDaoDien.Name = "lblDaoDien";
            this.lblDaoDien.Size = new System.Drawing.Size(61, 16);
            this.lblDaoDien.TabIndex = 8;
            this.lblDaoDien.Text = "Đạo diễn";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(23, 26);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(64, 16);
            this.lblTenPhim.TabIndex = 7;
            this.lblTenPhim.Text = "Tên Phim";
            // 
            // PhimControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblNgayKhoiChieu);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblDaoDien);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Name = "PhimControl";
            this.Size = new System.Drawing.Size(1117, 68);
            this.Load += new System.EventHandler(this.PhimControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnChinhSua;
        private System.Windows.Forms.Label lblNgayKhoiChieu;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblDaoDien;
        private System.Windows.Forms.Label lblTenPhim;
    }
}
