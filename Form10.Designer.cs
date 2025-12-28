namespace QuanLyBanHang
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.btntienmat = new System.Windows.Forms.Button();
            this.btnQA = new System.Windows.Forms.Button();
            this.txtgiatridon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btntienmat
            // 
            this.btntienmat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntienmat.BackgroundImage = global::QuanLyBanHang.Properties.Resources.images;
            this.btntienmat.Location = new System.Drawing.Point(287, 102);
            this.btntienmat.Name = "btntienmat";
            this.btntienmat.Size = new System.Drawing.Size(200, 50);
            this.btntienmat.TabIndex = 0;
            this.btntienmat.Text = "THANH TOÁN BẰNG TIỀN MẶT";
            this.btntienmat.UseVisualStyleBackColor = true;
            // 
            // btnQA
            // 
            this.btnQA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQA.BackgroundImage = global::QuanLyBanHang.Properties.Resources.images;
            this.btnQA.Location = new System.Drawing.Point(287, 175);
            this.btnQA.Name = "btnQA";
            this.btnQA.Size = new System.Drawing.Size(200, 50);
            this.btnQA.TabIndex = 0;
            this.btnQA.Text = "THANH TOÁN BẰNG NGÂN HÀNG/VÍ ĐIỆN TỬ";
            this.btnQA.UseVisualStyleBackColor = true;
            // 
            // txtgiatridon
            // 
            this.txtgiatridon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgiatridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiatridon.Location = new System.Drawing.Point(210, 248);
            this.txtgiatridon.Name = "txtgiatridon";
            this.txtgiatridon.Size = new System.Drawing.Size(347, 38);
            this.txtgiatridon.TabIndex = 1;
            this.txtgiatridon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "vnd";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgiatridon);
            this.Controls.Add(this.btnQA);
            this.Controls.Add(this.btntienmat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Vui lòng  chọn phương thức thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntienmat;
        private System.Windows.Forms.Button btnQA;
        private System.Windows.Forms.TextBox txtgiatridon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}