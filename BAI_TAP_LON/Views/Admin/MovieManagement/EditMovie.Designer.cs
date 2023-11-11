namespace BAI_TAP_LON.Views.Admin.MovieManagement
{
    partial class EditMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMovie));
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.rtbMoTa = new Krypton.Toolkit.KryptonRichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPoster = new System.Windows.Forms.Panel();
            this.picAnhPhim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUpLoad = new FontAwesome.Sharp.IconButton();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.cbHangSX = new Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienVienChinh = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhim = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayKhoiChieu = new System.Windows.Forms.DateTimePicker();
            this.txtDaoDien = new Krypton.Toolkit.KryptonTextBox();
            this.txtMaPhim = new Krypton.Toolkit.KryptonTextBox();
            this.cbNuocSX = new Krypton.Toolkit.KryptonComboBox();
            this.cbTheLoai = new Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.pnlDescription.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhPhim)).BeginInit();
            this.pnlInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHangSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNuocSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheLoai)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDescription.Controls.Add(this.rtbMoTa);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(512, 320);
            this.pnlDescription.Margin = new System.Windows.Forms.Padding(1);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(547, 432);
            this.pnlDescription.TabIndex = 14;
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMoTa.Location = new System.Drawing.Point(23, 51);
            this.rtbMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(466, 367);
            this.rtbMoTa.TabIndex = 3;
            this.rtbMoTa.Text = "Giới thiệu phim....";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(19, 25);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(52, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Mô tả";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.Window;
            this.pnlButton.Controls.Add(this.btnLuu);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(1059, 320);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(253, 432);
            this.pnlButton.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 6;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuu.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(62, 366);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 45);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlPoster
            // 
            this.pnlPoster.BackColor = System.Drawing.SystemColors.Window;
            this.pnlPoster.Controls.Add(this.picAnhPhim);
            this.pnlPoster.Controls.Add(this.btnUpLoad);
            this.pnlPoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPoster.Location = new System.Drawing.Point(0, 320);
            this.pnlPoster.Margin = new System.Windows.Forms.Padding(1);
            this.pnlPoster.Name = "pnlPoster";
            this.pnlPoster.Size = new System.Drawing.Size(512, 432);
            this.pnlPoster.TabIndex = 12;
            // 
            // picAnhPhim
            // 
            this.picAnhPhim.BackColor = System.Drawing.Color.Transparent;
            this.picAnhPhim.BorderRadius = 1;
            this.picAnhPhim.FillColor = System.Drawing.Color.WhiteSmoke;
            this.picAnhPhim.Image = ((System.Drawing.Image)(resources.GetObject("picAnhPhim.Image")));
            this.picAnhPhim.ImageRotate = 0F;
            this.picAnhPhim.Location = new System.Drawing.Point(56, 25);
            this.picAnhPhim.Name = "picAnhPhim";
            this.picAnhPhim.Size = new System.Drawing.Size(315, 388);
            this.picAnhPhim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhPhim.TabIndex = 25;
            this.picAnhPhim.TabStop = false;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpLoad.FlatAppearance.BorderSize = 2;
            this.btnUpLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpLoad.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUpLoad.IconColor = System.Drawing.Color.Black;
            this.btnUpLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpLoad.IconSize = 36;
            this.btnUpLoad.Location = new System.Drawing.Point(409, 359);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(60, 54);
            this.btnUpLoad.TabIndex = 24;
            this.btnUpLoad.UseVisualStyleBackColor = false;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // pnlInfor
            // 
            this.pnlInfor.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfor.Controls.Add(this.cbHangSX);
            this.pnlInfor.Controls.Add(this.label4);
            this.pnlInfor.Controls.Add(this.txtDienVienChinh);
            this.pnlInfor.Controls.Add(this.label3);
            this.pnlInfor.Controls.Add(this.txtTenPhim);
            this.pnlInfor.Controls.Add(this.label2);
            this.pnlInfor.Controls.Add(this.dateNgayKhoiChieu);
            this.pnlInfor.Controls.Add(this.txtDaoDien);
            this.pnlInfor.Controls.Add(this.txtMaPhim);
            this.pnlInfor.Controls.Add(this.cbNuocSX);
            this.pnlInfor.Controls.Add(this.cbTheLoai);
            this.pnlInfor.Controls.Add(this.label1);
            this.pnlInfor.Controls.Add(this.lblCountry);
            this.pnlInfor.Controls.Add(this.lblMovieGenre);
            this.pnlInfor.Controls.Add(this.lblDirector);
            this.pnlInfor.Controls.Add(this.lblMovieName);
            this.pnlInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfor.Location = new System.Drawing.Point(0, 72);
            this.pnlInfor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(1312, 248);
            this.pnlInfor.TabIndex = 11;
            // 
            // cbHangSX
            // 
            this.cbHangSX.CornerRoundingRadius = -1F;
            this.cbHangSX.DropDownWidth = 227;
            this.cbHangSX.IntegralHeight = false;
            this.cbHangSX.Location = new System.Drawing.Point(535, 197);
            this.cbHangSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbHangSX.Size = new System.Drawing.Size(303, 23);
            this.cbHangSX.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 2);
            this.cbHangSX.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbHangSX.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHangSX.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbHangSX.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbHangSX.TabIndex = 42;
            this.cbHangSX.Text = "Hãng sản xuất";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Hãng sản xuất";
            // 
            // txtDienVienChinh
            // 
            this.txtDienVienChinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienVienChinh.Location = new System.Drawing.Point(900, 39);
            this.txtDienVienChinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienVienChinh.Name = "txtDienVienChinh";
            this.txtDienVienChinh.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtDienVienChinh.Size = new System.Drawing.Size(364, 25);
            this.txtDienVienChinh.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtDienVienChinh.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtDienVienChinh.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienVienChinh.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Diễn viên chính";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPhim.Location = new System.Drawing.Point(53, 119);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtTenPhim.Size = new System.Drawing.Size(374, 25);
            this.txtTenPhim.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtTenPhim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTenPhim.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên phim";
            // 
            // dateNgayKhoiChieu
            // 
            this.dateNgayKhoiChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKhoiChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayKhoiChieu.Location = new System.Drawing.Point(900, 131);
            this.dateNgayKhoiChieu.Name = "dateNgayKhoiChieu";
            this.dateNgayKhoiChieu.Size = new System.Drawing.Size(216, 27);
            this.dateNgayKhoiChieu.TabIndex = 36;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDaoDien.Location = new System.Drawing.Point(53, 195);
            this.txtDaoDien.Margin = new System.Windows.Forms.Padding(4);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtDaoDien.Size = new System.Drawing.Size(374, 25);
            this.txtDaoDien.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtDaoDien.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtDaoDien.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaoDien.TabIndex = 35;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhim.Location = new System.Drawing.Point(52, 46);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtMaPhim.Size = new System.Drawing.Size(375, 25);
            this.txtMaPhim.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtMaPhim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtMaPhim.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.TabIndex = 34;
            // 
            // cbNuocSX
            // 
            this.cbNuocSX.CornerRoundingRadius = -1F;
            this.cbNuocSX.DropDownWidth = 227;
            this.cbNuocSX.IntegralHeight = false;
            this.cbNuocSX.Location = new System.Drawing.Point(535, 121);
            this.cbNuocSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbNuocSX.Name = "cbNuocSX";
            this.cbNuocSX.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbNuocSX.Size = new System.Drawing.Size(303, 23);
            this.cbNuocSX.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 2);
            this.cbNuocSX.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbNuocSX.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNuocSX.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbNuocSX.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbNuocSX.TabIndex = 33;
            this.cbNuocSX.Text = "Quốc gia";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.CornerRoundingRadius = -1F;
            this.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheLoai.DropDownWidth = 229;
            this.cbTheLoai.IntegralHeight = false;
            this.cbTheLoai.Location = new System.Drawing.Point(535, 49);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheLoai.MaxDropDownItems = 20;
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbTheLoai.Size = new System.Drawing.Size(303, 23);
            this.cbTheLoai.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 2);
            this.cbTheLoai.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbTheLoai.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheLoai.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbTheLoai.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbTheLoai.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ngày khởi chiếu";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(531, 88);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 19);
            this.lblCountry.TabIndex = 30;
            this.lblCountry.Text = "Quốc gia";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(531, 13);
            this.lblMovieGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(66, 19);
            this.lblMovieGenre.TabIndex = 29;
            this.lblMovieGenre.Text = "Thể loại";
            // 
            // lblDirector
            // 
            this.lblDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(48, 164);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(75, 19);
            this.lblDirector.TabIndex = 28;
            this.lblDirector.Text = "Đạo diễn";
            // 
            // lblMovieName
            // 
            this.lblMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(48, 13);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(71, 19);
            this.lblMovieName.TabIndex = 27;
            this.lblMovieName.Text = "Mã phim";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTiltle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1312, 72);
            this.pnlHeader.TabIndex = 10;
            // 
            // lblTiltle
            // 
            this.lblTiltle.AutoSize = true;
            this.lblTiltle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.Location = new System.Drawing.Point(79, 28);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(159, 24);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Chỉnh sửa phim";
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlPoster);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.pnlHeader);
            this.Name = "EditMovie";
            this.Text = "EditMovie";
            this.Load += new System.EventHandler(this.EditMovie_Load);
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhPhim)).EndInit();
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHangSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNuocSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheLoai)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlPoster;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTiltle;
        private Krypton.Toolkit.KryptonComboBox cbHangSX;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonTextBox txtDienVienChinh;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtTenPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayKhoiChieu;
        private Krypton.Toolkit.KryptonTextBox txtDaoDien;
        private Krypton.Toolkit.KryptonTextBox txtMaPhim;
        private Krypton.Toolkit.KryptonComboBox cbNuocSX;
        private Krypton.Toolkit.KryptonComboBox cbTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblMovieName;
        private Guna.UI2.WinForms.Guna2PictureBox picAnhPhim;
        private FontAwesome.Sharp.IconButton btnUpLoad;
        private Krypton.Toolkit.KryptonRichTextBox rtbMoTa;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
    }
}