namespace BAI_TAP_LON.Views.Admin.FoodManagement
{
    partial class FoodManagement
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
            this.pnlBooter = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cbGenre = new Krypton.Toolkit.KryptonComboBox();
            this.btnImportProduct = new Krypton.Toolkit.KryptonButton();
            this.btnAddProduct = new Krypton.Toolkit.KryptonButton();
            this.txtFind = new Krypton.Toolkit.KryptonTextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBooter
            // 
            this.pnlBooter.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBooter.Location = new System.Drawing.Point(0, 702);
            this.pnlBooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBooter.Name = "pnlBooter";
            this.pnlBooter.Size = new System.Drawing.Size(1312, 50);
            this.pnlBooter.TabIndex = 7;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 98);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1312, 654);
            this.pnlBody.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.cbGenre);
            this.pnlHeader.Controls.Add(this.btnImportProduct);
            this.pnlHeader.Controls.Add(this.btnAddProduct);
            this.pnlHeader.Controls.Add(this.txtFind);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1312, 98);
            this.pnlHeader.TabIndex = 5;
            // 
            // cbGenre
            // 
            this.cbGenre.CornerRoundingRadius = -1F;
            this.cbGenre.DropDownWidth = 229;
            this.cbGenre.IntegralHeight = false;
            this.cbGenre.Location = new System.Drawing.Point(1121, 54);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbGenre.Size = new System.Drawing.Size(173, 23);
            this.cbGenre.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbGenre.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenre.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbGenre.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbGenre.TabIndex = 16;
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.CornerRoundingRadius = 6F;
            this.btnImportProduct.Location = new System.Drawing.Point(641, 16);
            this.btnImportProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.Size = new System.Drawing.Size(93, 62);
            this.btnImportProduct.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.btnImportProduct.StateCommon.Back.Color2 = System.Drawing.SystemColors.Window;
            this.btnImportProduct.StateCommon.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btnImportProduct.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImportProduct.StateCommon.Border.Rounding = 6F;
            this.btnImportProduct.StateCommon.Border.Width = 1;
            this.btnImportProduct.TabIndex = 15;
            this.btnImportProduct.Values.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.CornerRoundingRadius = 6F;
            this.btnAddProduct.Location = new System.Drawing.Point(513, 14);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(93, 62);
            this.btnAddProduct.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.btnAddProduct.StateCommon.Back.Color2 = System.Drawing.SystemColors.Window;
            this.btnAddProduct.StateCommon.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btnAddProduct.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddProduct.StateCommon.Border.Rounding = 6F;
            this.btnAddProduct.StateCommon.Border.Width = 1;
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.Values.Text = "";
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(53, 50);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtFind.Size = new System.Drawing.Size(401, 25);
            this.txtFind.StateCommon.Back.Color1 = System.Drawing.SystemColors.Window;
            this.txtFind.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtFind.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.TabIndex = 13;
            this.txtFind.Text = "Tìm kiếm....";
            // 
            // FoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.pnlBooter);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FoodManagement";
            this.Text = "FoodManagement";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private Krypton.Toolkit.KryptonComboBox cbGenre;
        private Krypton.Toolkit.KryptonButton btnImportProduct;
        private Krypton.Toolkit.KryptonButton btnAddProduct;
        private Krypton.Toolkit.KryptonTextBox txtFind;
    }
}