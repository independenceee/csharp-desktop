namespace BAI_TAP_LON.Components
{
    partial class UserControl5
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
            this.numSL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Brown;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 40;
            this.btnXoa.Location = new System.Drawing.Point(12, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // numSL
            // 
            this.numSL.BackColor = System.Drawing.Color.Transparent;
            this.numSL.BorderColor = System.Drawing.Color.Firebrick;
            this.numSL.BorderRadius = 4;
            this.numSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSL.Location = new System.Drawing.Point(287, 12);
            this.numSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(70, 32);
            this.numSL.TabIndex = 4;
            this.numSL.UpDownButtonFillColor = System.Drawing.Color.Firebrick;
            this.numSL.UpDownButtonForeColor = System.Drawing.Color.DarkGray;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(82, 24);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(71, 20);
            this.lblTenSP.TabIndex = 5;
            this.lblTenSP.Text = "Popcorn";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(380, 26);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(28, 16);
            this.lblTien.TabIndex = 6;
            this.lblTien.Text = "$25";
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnXoa);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(469, 68);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnXoa;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSL;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblTien;
    }
}
