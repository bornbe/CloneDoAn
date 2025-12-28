namespace QuanLyBanHang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.bthThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = global::QuanLyBanHang.Properties.Resources.images;
            this.label1.Location = new System.Drawing.Point(230, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý bán hàng";
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Image = global::QuanLyBanHang.Properties.Resources.istockphoto_878320722_2048x2048;
            this.btnQuanLy.Location = new System.Drawing.Point(225, 250);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(400, 50);
            this.btnQuanLy.TabIndex = 1;
            this.btnQuanLy.Text = "Quản lý cửa hàng";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // bthThanhToan
            // 
            this.bthThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bthThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthThanhToan.Image = global::QuanLyBanHang.Properties.Resources.istockphoto_878320722_2048x2048;
            this.bthThanhToan.Location = new System.Drawing.Point(225, 165);
            this.bthThanhToan.Name = "bthThanhToan";
            this.bthThanhToan.Size = new System.Drawing.Size(400, 50);
            this.bthThanhToan.TabIndex = 0;
            this.bthThanhToan.Text = "Thanh toán Đơn hàng";
            this.bthThanhToan.UseVisualStyleBackColor = true;
            this.bthThanhToan.Click += new System.EventHandler(this.bthThanhToan_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.hinh_nen_may_tinh_1;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.bthThanhToan);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthThanhToan;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Label label1;
    }
}

