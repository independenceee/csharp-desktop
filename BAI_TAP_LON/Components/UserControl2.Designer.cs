namespace BAI_TAP_LON
{
    partial class UserControl2
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
            this.numSoLuongSP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongSP)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numSoLuongSP
            // 
            this.numSoLuongSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSoLuongSP.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuongSP.BorderColor = System.Drawing.Color.Firebrick;
            this.numSoLuongSP.BorderRadius = 4;
            this.numSoLuongSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuongSP.Location = new System.Drawing.Point(202, 13);
            this.numSoLuongSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSoLuongSP.Name = "numSoLuongSP";
            this.numSoLuongSP.Size = new System.Drawing.Size(93, 35);
            this.numSoLuongSP.TabIndex = 0;
            this.numSoLuongSP.UpDownButtonFillColor = System.Drawing.Color.Firebrick;
            this.numSoLuongSP.UpDownButtonForeColor = System.Drawing.Color.DarkGray;
            this.numSoLuongSP.ValueChanged += new System.EventHandler(this.numSoLuongSP_ValueChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.lblThanhTien);
            this.guna2GradientPanel1.Controls.Add(this.lblTenSP);
            this.guna2GradientPanel1.Controls.Add(this.btnXoa);
            this.guna2GradientPanel1.Controls.Add(this.numSoLuongSP);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(374, 55);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(301, 24);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(49, 16);
            this.lblThanhTien.TabIndex = 4;
            this.lblThanhTien.Text = "$25000";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(58, 24);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(102, 16);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Popcorn in CGV";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Brown;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 40;
            this.btnXoa.Location = new System.Drawing.Point(3, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(374, 55);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongSP)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuongSP;
        private FontAwesome.Sharp.IconButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTenSP;
    }
}
