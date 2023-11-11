namespace BAI_TAP_LON.Components
{
    partial class UserControl4
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
			this.gunacheckbChair_Valid = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.lblMaGhe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// gunacheckbChair_Valid
			// 
			this.gunacheckbChair_Valid.BackColor = System.Drawing.Color.Transparent;
			this.gunacheckbChair_Valid.CheckedState.BorderColor = System.Drawing.Color.Lime;
			this.gunacheckbChair_Valid.CheckedState.BorderRadius = 3;
			this.gunacheckbChair_Valid.CheckedState.BorderThickness = 3;
			this.gunacheckbChair_Valid.CheckedState.FillColor = System.Drawing.Color.Lime;
			this.gunacheckbChair_Valid.CheckMarkColor = System.Drawing.Color.Lime;
			this.gunacheckbChair_Valid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gunacheckbChair_Valid.Location = new System.Drawing.Point(0, 0);
			this.gunacheckbChair_Valid.Name = "gunacheckbChair_Valid";
			this.gunacheckbChair_Valid.Size = new System.Drawing.Size(60, 60);
			this.gunacheckbChair_Valid.TabIndex = 1;
			this.gunacheckbChair_Valid.UncheckedState.BorderColor = System.Drawing.Color.Lime;
			this.gunacheckbChair_Valid.UncheckedState.BorderRadius = 3;
			this.gunacheckbChair_Valid.UncheckedState.BorderThickness = 3;
			this.gunacheckbChair_Valid.UncheckedState.FillColor = System.Drawing.SystemColors.Control;
			this.gunacheckbChair_Valid.CheckedChanged += new System.EventHandler(this.gunacheckbChair_Valid_CheckedChanged);
			this.gunacheckbChair_Valid.Click += new System.EventHandler(this.gunacheckbChair_Valid_Click);
			// 
			// lblMaGhe
			// 
			this.lblMaGhe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMaGhe.AutoSize = true;
			this.lblMaGhe.BackColor = System.Drawing.Color.Transparent;
			this.lblMaGhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblMaGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaGhe.Location = new System.Drawing.Point(12, 20);
			this.lblMaGhe.Name = "lblMaGhe";
			this.lblMaGhe.Size = new System.Drawing.Size(33, 18);
			this.lblMaGhe.TabIndex = 2;
			this.lblMaGhe.Text = "A16";
			// 
			// UserControl4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblMaGhe);
			this.Controls.Add(this.gunacheckbChair_Valid);
			this.Name = "UserControl4";
			this.Size = new System.Drawing.Size(60, 60);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomCheckBox gunacheckbChair_Valid;
        private System.Windows.Forms.Label lblMaGhe;
    }
}
