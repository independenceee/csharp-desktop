namespace BAI_TAP_LON.Views.Admin.Import_ExportManagement
{
    partial class ImportPage
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvListImport = new System.Windows.Forms.DataGridView();
            this.pnlBooter = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.cbOrder2 = new Krypton.Toolkit.KryptonComboBox();
            this.cbOrder1 = new Krypton.Toolkit.KryptonComboBox();
            this.txtFind = new Krypton.Toolkit.KryptonTextBox();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImport)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrder1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvListImport);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 85);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1312, 544);
            this.pnlBody.TabIndex = 6;
            // 
            // dgvListImport
            // 
            this.dgvListImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListImport.Location = new System.Drawing.Point(0, 0);
            this.dgvListImport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListImport.Name = "dgvListImport";
            this.dgvListImport.RowHeadersWidth = 51;
            this.dgvListImport.Size = new System.Drawing.Size(1312, 544);
            this.dgvListImport.TabIndex = 0;
            // 
            // pnlBooter
            // 
            this.pnlBooter.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBooter.Location = new System.Drawing.Point(0, 629);
            this.pnlBooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBooter.Name = "pnlBooter";
            this.pnlBooter.Size = new System.Drawing.Size(1312, 123);
            this.pnlBooter.TabIndex = 5;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.Controls.Add(this.kryptonButton1);
            this.pnlHeader.Controls.Add(this.cbOrder2);
            this.pnlHeader.Controls.Add(this.cbOrder1);
            this.pnlHeader.Controls.Add(this.txtFind);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1312, 85);
            this.pnlHeader.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = 6F;
            this.kryptonButton1.Location = new System.Drawing.Point(1124, 25);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(155, 31);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.SystemColors.MenuHighlight;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 6F;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "Xuất file Excel";
            // 
            // cbOrder2
            // 
            this.cbOrder2.AutoCompleteCustomSource.AddRange(new string[] {
            "Toàn bộ",
            "Theo ngày",
            "Theo tháng"});
            this.cbOrder2.CornerRoundingRadius = -1F;
            this.cbOrder2.DropDownWidth = 123;
            this.cbOrder2.IntegralHeight = false;
            this.cbOrder2.Items.AddRange(new object[] {
            "Theo tháng ",
            "Toàn bộ"});
            this.cbOrder2.Location = new System.Drawing.Point(652, 32);
            this.cbOrder2.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrder2.Name = "cbOrder2";
            this.cbOrder2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbOrder2.Size = new System.Drawing.Size(177, 23);
            this.cbOrder2.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbOrder2.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrder2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbOrder2.TabIndex = 2;
            // 
            // cbOrder1
            // 
            this.cbOrder1.AutoCompleteCustomSource.AddRange(new string[] {
            "Mã đơn",
            "Khách hàng",
            "Số điện thoại"});
            this.cbOrder1.CornerRoundingRadius = -1F;
            this.cbOrder1.DropDownWidth = 135;
            this.cbOrder1.IntegralHeight = false;
            this.cbOrder1.Items.AddRange(new object[] {
            "Mã đơn",
            "Nhân viên",
            "Sản phẩm"});
            this.cbOrder1.Location = new System.Drawing.Point(449, 32);
            this.cbOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrder1.Name = "cbOrder1";
            this.cbOrder1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbOrder1.Size = new System.Drawing.Size(177, 23);
            this.cbOrder1.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.cbOrder1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrder1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbOrder1.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(49, 25);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtFind.Size = new System.Drawing.Size(311, 29);
            this.txtFind.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtFind.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.TabIndex = 0;
            // 
            // ImportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlBooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ImportPage";
            this.Text = "ImportPage";
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImport)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvListImport;
        private System.Windows.Forms.Panel pnlBooter;
        private System.Windows.Forms.Panel pnlHeader;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonComboBox cbOrder2;
        private Krypton.Toolkit.KryptonComboBox cbOrder1;
        private Krypton.Toolkit.KryptonTextBox txtFind;
    }
}