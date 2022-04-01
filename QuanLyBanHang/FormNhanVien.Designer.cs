namespace QuanLyBanHang
{
    partial class FormNhanVien
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
            this.lsvDanhSachNhanVien = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lsvDanhSachNhanVien
            // 
            this.lsvDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1,
            this.Name});
            this.lsvDanhSachNhanVien.HideSelection = false;
            this.lsvDanhSachNhanVien.Location = new System.Drawing.Point(386, 28);
            this.lsvDanhSachNhanVien.Name = "lsvDanhSachNhanVien";
            this.lsvDanhSachNhanVien.Size = new System.Drawing.Size(402, 410);
            this.lsvDanhSachNhanVien.TabIndex = 0;
            this.lsvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            // 
            // Id
            // 
            this.Id.Name = "Id";
            this.Id.Text = "Mã";
            // 
            // Name
            // 
            this.Name.Name = "Name";
            this.Name.Text = "Name";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvDanhSachNhanVien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvDanhSachNhanVien;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Name;
    }
}