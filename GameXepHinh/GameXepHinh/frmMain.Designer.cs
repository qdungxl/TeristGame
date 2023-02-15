namespace GameXepHinh
{
    partial class frmMain
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
            this.pnXepHinh = new System.Windows.Forms.Panel();
            this.btnTronLaiHinh = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.lblHinhGoc = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblKiemTra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnXepHinh
            // 
            this.pnXepHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnXepHinh.Location = new System.Drawing.Point(18, 18);
            this.pnXepHinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnXepHinh.Name = "pnXepHinh";
            this.pnXepHinh.Size = new System.Drawing.Size(400, 400);
            this.pnXepHinh.TabIndex = 0;
            // 
            // btnTronLaiHinh
            // 
            this.btnTronLaiHinh.Location = new System.Drawing.Point(306, 426);
            this.btnTronLaiHinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTronLaiHinh.Name = "btnTronLaiHinh";
            this.btnTronLaiHinh.Size = new System.Drawing.Size(112, 45);
            this.btnTronLaiHinh.TabIndex = 2;
            this.btnTronLaiHinh.Text = "Trộn lại";
            this.btnTronLaiHinh.UseVisualStyleBackColor = true;
            this.btnTronLaiHinh.Click += new System.EventHandler(this.btnTronLaiHinh_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(662, 426);
            this.btnChonHinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(112, 45);
            this.btnChonHinh.TabIndex = 3;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // lblHinhGoc
            // 
            this.lblHinhGoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHinhGoc.Location = new System.Drawing.Point(474, 118);
            this.lblHinhGoc.Name = "lblHinhGoc";
            this.lblHinhGoc.Size = new System.Drawing.Size(300, 300);
            this.lblHinhGoc.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKiemTra.Location = new System.Drawing.Point(474, 18);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(300, 87);
            this.lblKiemTra.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 485);
            this.Controls.Add(this.lblKiemTra);
            this.Controls.Add(this.lblHinhGoc);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnTronLaiHinh);
            this.Controls.Add(this.pnXepHinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game xếp hình";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnXepHinh;
        private System.Windows.Forms.Button btnTronLaiHinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Label lblHinhGoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblKiemTra;
    }
}