namespace BAI_TAP_LON.Views.Staff.ShowtimePage
{
    partial class MovieShowtimePage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieShowtimePage));
			this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.gunaDateNgayChieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.gunaCbTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.gunatxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.flDanhSachPhim = new System.Windows.Forms.FlowLayoutPanel();
			this.guna2ShadowPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2ShadowPanel1
			// 
			this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel1.Controls.Add(this.gunaDateNgayChieu);
			this.guna2ShadowPanel1.Controls.Add(this.gunaCbTheLoai);
			this.guna2ShadowPanel1.Controls.Add(this.gunatxtSearch);
			this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
			this.guna2ShadowPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
			this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
			this.guna2ShadowPanel1.Size = new System.Drawing.Size(1385, 90);
			this.guna2ShadowPanel1.TabIndex = 2;
			// 
			// gunaDateNgayChieu
			// 
			this.gunaDateNgayChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gunaDateNgayChieu.AutoRoundedCorners = true;
			this.gunaDateNgayChieu.BackColor = System.Drawing.Color.White;
			this.gunaDateNgayChieu.BorderColor = System.Drawing.Color.Silver;
			this.gunaDateNgayChieu.BorderRadius = 17;
			this.gunaDateNgayChieu.BorderThickness = 1;
			this.gunaDateNgayChieu.Checked = true;
			this.gunaDateNgayChieu.FillColor = System.Drawing.SystemColors.Window;
			this.gunaDateNgayChieu.Font = new System.Drawing.Font("Bookman Old Style", 10.2F);
			this.gunaDateNgayChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.gunaDateNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.gunaDateNgayChieu.Location = new System.Drawing.Point(894, 29);
			this.gunaDateNgayChieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.gunaDateNgayChieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.gunaDateNgayChieu.Name = "gunaDateNgayChieu";
			this.gunaDateNgayChieu.Size = new System.Drawing.Size(400, 36);
			this.gunaDateNgayChieu.TabIndex = 9;
			this.gunaDateNgayChieu.Value = new System.DateTime(2023, 10, 3, 15, 35, 40, 214);
			this.gunaDateNgayChieu.ValueChanged += new System.EventHandler(this.gunaDateNgayChieu_ValueChanged);
			this.gunaDateNgayChieu.Leave += new System.EventHandler(this.gunaDateNgayChieu_Leave);
			// 
			// gunaCbTheLoai
			// 
			this.gunaCbTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gunaCbTheLoai.AutoRoundedCorners = true;
			this.gunaCbTheLoai.BackColor = System.Drawing.Color.Transparent;
			this.gunaCbTheLoai.BorderColor = System.Drawing.Color.Silver;
			this.gunaCbTheLoai.BorderRadius = 17;
			this.gunaCbTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.gunaCbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gunaCbTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.gunaCbTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.gunaCbTheLoai.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gunaCbTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.gunaCbTheLoai.ItemHeight = 30;
			this.gunaCbTheLoai.Items.AddRange(new object[] {
            "Kinh dị",
            "Tình cảm",
            "Hài hước"});
			this.gunaCbTheLoai.Location = new System.Drawing.Point(451, 29);
			this.gunaCbTheLoai.Name = "gunaCbTheLoai";
			this.gunaCbTheLoai.Size = new System.Drawing.Size(400, 36);
			this.gunaCbTheLoai.TabIndex = 8;
			this.gunaCbTheLoai.SelectedValueChanged += new System.EventHandler(this.gunaCbTheLoai_SelectedValueChanged);
			this.gunaCbTheLoai.Click += new System.EventHandler(this.gunaCbTheLoai_Click);
			this.gunaCbTheLoai.Leave += new System.EventHandler(this.gunaCbTheLoai_Leave);
			// 
			// gunatxtSearch
			// 
			this.gunatxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gunatxtSearch.AutoRoundedCorners = true;
			this.gunatxtSearch.BorderColor = System.Drawing.Color.Silver;
			this.gunatxtSearch.BorderRadius = 17;
			this.gunatxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.gunatxtSearch.DefaultText = "Search for movie";
			this.gunatxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.gunatxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.gunatxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.gunatxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.gunatxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.gunatxtSearch.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gunatxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.gunatxtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("gunatxtSearch.IconRight")));
			this.gunatxtSearch.IconRightSize = new System.Drawing.Size(30, 30);
			this.gunatxtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.gunatxtSearch.Location = new System.Drawing.Point(15, 29);
			this.gunatxtSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.gunatxtSearch.Name = "gunatxtSearch";
			this.gunatxtSearch.PasswordChar = '\0';
			this.gunatxtSearch.PlaceholderText = "";
			this.gunatxtSearch.SelectedText = "";
			this.gunatxtSearch.Size = new System.Drawing.Size(400, 36);
			this.gunatxtSearch.TabIndex = 2;
			this.gunatxtSearch.Click += new System.EventHandler(this.gunatxtSearch_Click);
			this.gunatxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gunatxtSearch_KeyDown);
			this.gunatxtSearch.Leave += new System.EventHandler(this.gunatxtSearch_Leave);
			// 
			// flDanhSachPhim
			// 
			this.flDanhSachPhim.BackColor = System.Drawing.SystemColors.Window;
			this.flDanhSachPhim.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flDanhSachPhim.Location = new System.Drawing.Point(0, 90);
			this.flDanhSachPhim.Name = "flDanhSachPhim";
			this.flDanhSachPhim.Size = new System.Drawing.Size(1385, 710);
			this.flDanhSachPhim.TabIndex = 3;
			// 
			// MovieShowtimePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1385, 800);
			this.Controls.Add(this.flDanhSachPhim);
			this.Controls.Add(this.guna2ShadowPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(1300, 800);
			this.Name = "MovieShowtimePage";
			this.Tag = "";
			this.Load += new System.EventHandler(this.MovieShowtimePgae_Load);
			this.guna2ShadowPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox gunatxtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox gunaCbTheLoai;
        private Guna.UI2.WinForms.Guna2DateTimePicker gunaDateNgayChieu;
        private System.Windows.Forms.FlowLayoutPanel flDanhSachPhim;
    }
}