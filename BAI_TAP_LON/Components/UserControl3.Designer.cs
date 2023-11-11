namespace BAI_TAP_LON
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.gunaPanelTenPhim = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gunalblTenPhim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gunaPicPhim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaPanelTenPhim.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPicPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanelTenPhim
            // 
            this.gunaPanelTenPhim.Controls.Add(this.gunalblTenPhim);
            this.gunaPanelTenPhim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanelTenPhim.FillColor = System.Drawing.Color.Gainsboro;
            this.gunaPanelTenPhim.FillColor2 = System.Drawing.Color.Gainsboro;
            this.gunaPanelTenPhim.FillColor3 = System.Drawing.Color.Gainsboro;
            this.gunaPanelTenPhim.FillColor4 = System.Drawing.Color.Gainsboro;
            this.gunaPanelTenPhim.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaPanelTenPhim.Location = new System.Drawing.Point(0, 424);
            this.gunaPanelTenPhim.Name = "gunaPanelTenPhim";
            this.gunaPanelTenPhim.Size = new System.Drawing.Size(323, 92);
            this.gunaPanelTenPhim.TabIndex = 1;
            // 
            // gunalblTenPhim
            // 
            this.gunalblTenPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunalblTenPhim.BackColor = System.Drawing.Color.Transparent;
            this.gunalblTenPhim.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunalblTenPhim.ForeColor = System.Drawing.Color.Black;
            this.gunalblTenPhim.Location = new System.Drawing.Point(58, 32);
            this.gunalblTenPhim.Name = "gunalblTenPhim";
            this.gunalblTenPhim.Size = new System.Drawing.Size(206, 29);
            this.gunalblTenPhim.TabIndex = 3;
            this.gunalblTenPhim.Text = "Conan - Viên Đạn đỏ";
            this.gunalblTenPhim.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.gunaPicPhim);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(323, 424);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // gunaPicPhim
            // 
            this.gunaPicPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPicPhim.Image = ((System.Drawing.Image)(resources.GetObject("gunaPicPhim.Image")));
            this.gunaPicPhim.ImageRotate = 0F;
            this.gunaPicPhim.Location = new System.Drawing.Point(0, 0);
            this.gunaPicPhim.Name = "gunaPicPhim";
            this.gunaPicPhim.Size = new System.Drawing.Size(323, 424);
            this.gunaPicPhim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPicPhim.TabIndex = 0;
            this.gunaPicPhim.TabStop = false;
            this.gunaPicPhim.Click += new System.EventHandler(this.gunaPicPhim_Click);
            this.gunaPicPhim.MouseLeave += new System.EventHandler(this.gunaPicPhim_MouseLeave);
            this.gunaPicPhim.MouseHover += new System.EventHandler(this.gunaPicPhim_MouseHover);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.gunaPanelTenPhim);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(323, 516);
            this.gunaPanelTenPhim.ResumeLayout(false);
            this.gunaPanelTenPhim.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPicPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel gunaPanelTenPhim;
        private Guna.UI2.WinForms.Guna2HtmlLabel gunalblTenPhim;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox gunaPicPhim;
    }
}
