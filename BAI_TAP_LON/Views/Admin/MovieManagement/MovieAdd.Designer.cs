namespace BAI_TAP_LON.Views.Admin.MovieManagement
{
    partial class MovieAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieAdd));
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.rtbMoTa = new Krypton.Toolkit.KryptonRichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.errorChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDescription.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhPhim)).BeginInit();
            this.pnlInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHangSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNuocSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheLoai)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDescription.Controls.Add(this.rtbMoTa);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(503, 346);
            this.pnlDescription.Margin = new System.Windows.Forms.Padding(1);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(581, 435);
            this.pnlDescription.TabIndex = 15;
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMoTa.Location = new System.Drawing.Point(64, 33);
            this.rtbMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(466, 376);
            this.rtbMoTa.TabIndex = 1;
            this.rtbMoTa.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(60, 13);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(52, 19);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô tả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1084, 346);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 435);
            this.panel1.TabIndex = 14;
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
            this.btnLuu.Location = new System.Drawing.Point(43, 383);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 45);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlPoster
            // 
            this.pnlPoster.BackColor = System.Drawing.SystemColors.Window;
            this.pnlPoster.Controls.Add(this.picAnhPhim);
            this.pnlPoster.Controls.Add(this.btnUpLoad);
            this.pnlPoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPoster.Location = new System.Drawing.Point(0, 346);
            this.pnlPoster.Margin = new System.Windows.Forms.Padding(1);
            this.pnlPoster.Name = "pnlPoster";
            this.pnlPoster.Size = new System.Drawing.Size(503, 435);
            this.pnlPoster.TabIndex = 13;
            // 
            // picAnhPhim
            // 
            this.picAnhPhim.BackColor = System.Drawing.Color.Transparent;
            this.picAnhPhim.BorderRadius = 1;
            this.picAnhPhim.FillColor = System.Drawing.Color.WhiteSmoke;
            this.picAnhPhim.Image = ((System.Drawing.Image)(resources.GetObject("picAnhPhim.Image")));
            this.picAnhPhim.ImageRotate = 0F;
            this.picAnhPhim.Location = new System.Drawing.Point(84, 21);
            this.picAnhPhim.Name = "picAnhPhim";
            this.picAnhPhim.Size = new System.Drawing.Size(315, 388);
            this.picAnhPhim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhPhim.TabIndex = 23;
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
            this.btnUpLoad.Location = new System.Drawing.Point(425, 374);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(60, 54);
            this.btnUpLoad.TabIndex = 22;
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
            this.pnlInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInfor.Location = new System.Drawing.Point(0, 73);
            this.pnlInfor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(1312, 273);
            this.pnlInfor.TabIndex = 12;
            // 
            // cbHangSX
            // 
            this.cbHangSX.CornerRoundingRadius = -1F;
            this.cbHangSX.DropDownWidth = 227;
            this.cbHangSX.IntegralHeight = false;
            this.cbHangSX.Location = new System.Drawing.Point(567, 210);
            this.cbHangSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbHangSX.Size = new System.Drawing.Size(303, 23);
            this.cbHangSX.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbHangSX.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHangSX.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbHangSX.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbHangSX.TabIndex = 26;
            this.cbHangSX.Text = "Hãng sản xuất";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hãng sản xuất";
            // 
            // txtDienVienChinh
            // 
            this.txtDienVienChinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienVienChinh.Location = new System.Drawing.Point(932, 52);
            this.txtDienVienChinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienVienChinh.Name = "txtDienVienChinh";
            this.txtDienVienChinh.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtDienVienChinh.Size = new System.Drawing.Size(364, 25);
            this.txtDienVienChinh.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtDienVienChinh.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtDienVienChinh.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienVienChinh.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(928, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Diễn viên chính";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPhim.Location = new System.Drawing.Point(85, 132);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtTenPhim.Size = new System.Drawing.Size(374, 25);
            this.txtTenPhim.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtTenPhim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTenPhim.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên phim";
            // 
            // dateNgayKhoiChieu
            // 
            this.dateNgayKhoiChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKhoiChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayKhoiChieu.Location = new System.Drawing.Point(932, 144);
            this.dateNgayKhoiChieu.Name = "dateNgayKhoiChieu";
            this.dateNgayKhoiChieu.Size = new System.Drawing.Size(216, 27);
            this.dateNgayKhoiChieu.TabIndex = 20;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDaoDien.Location = new System.Drawing.Point(85, 208);
            this.txtDaoDien.Margin = new System.Windows.Forms.Padding(4);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtDaoDien.Size = new System.Drawing.Size(374, 25);
            this.txtDaoDien.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtDaoDien.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtDaoDien.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaoDien.TabIndex = 19;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhim.Location = new System.Drawing.Point(84, 59);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtMaPhim.Size = new System.Drawing.Size(375, 25);
            this.txtMaPhim.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtMaPhim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtMaPhim.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.TabIndex = 18;
            // 
            // cbNuocSX
            // 
            this.cbNuocSX.CornerRoundingRadius = -1F;
            this.cbNuocSX.DropDownWidth = 227;
            this.cbNuocSX.IntegralHeight = false;
            this.cbNuocSX.Location = new System.Drawing.Point(567, 134);
            this.cbNuocSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbNuocSX.Name = "cbNuocSX";
            this.cbNuocSX.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbNuocSX.Size = new System.Drawing.Size(303, 23);
            this.cbNuocSX.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbNuocSX.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNuocSX.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbNuocSX.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbNuocSX.TabIndex = 16;
            this.cbNuocSX.Text = "Quốc gia";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.CornerRoundingRadius = -1F;
            this.cbTheLoai.DropDownWidth = 229;
            this.cbTheLoai.IntegralHeight = false;
            this.cbTheLoai.Location = new System.Drawing.Point(567, 62);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbTheLoai.Size = new System.Drawing.Size(303, 23);
            this.cbTheLoai.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbTheLoai.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheLoai.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbTheLoai.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbTheLoai.TabIndex = 15;
            this.cbTheLoai.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày khởi chiếu";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(563, 101);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 19);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "Quốc gia";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(563, 26);
            this.lblMovieGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(66, 19);
            this.lblMovieGenre.TabIndex = 12;
            this.lblMovieGenre.Text = "Thể loại";
            // 
            // lblDirector
            // 
            this.lblDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(80, 177);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(75, 19);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Đạo diễn";
            // 
            // lblMovieName
            // 
            this.lblMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(80, 26);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(71, 19);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Mã phim";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTittle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1312, 73);
            this.pnlHeader.TabIndex = 11;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(79, 28);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(115, 24);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Thêm phim";
            // 
            // errorChiTiet
            // 
            this.errorChiTiet.ContainerControl = this;
            // 
            // MovieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 781);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPoster);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MovieAdd";
            this.Text = "MovieAdd";
            this.Load += new System.EventHandler(this.MovieAdd_Load);
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhPhim)).EndInit();
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHangSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNuocSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheLoai)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescription;
        private Krypton.Toolkit.KryptonRichTextBox rtbMoTa;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPoster;
        private System.Windows.Forms.Panel pnlInfor;
        private Krypton.Toolkit.KryptonTextBox txtDaoDien;
        private Krypton.Toolkit.KryptonTextBox txtMaPhim;
        private Krypton.Toolkit.KryptonComboBox cbNuocSX;
        private Krypton.Toolkit.KryptonComboBox cbTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTittle;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private FontAwesome.Sharp.IconButton btnUpLoad;
        private System.Windows.Forms.DateTimePicker dateNgayKhoiChieu;
        private Krypton.Toolkit.KryptonTextBox txtDienVienChinh;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtTenPhim;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox picAnhPhim;
        private Krypton.Toolkit.KryptonComboBox cbHangSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorChiTiet;
    }
}