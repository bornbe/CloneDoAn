namespace QuanLyBanHang
{
    partial class Form4
    {

        private System.ComponentModel.IContainer components = null;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.gbAddIteam = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtNameIteam = new System.Windows.Forms.TextBox();
            this.txtIdIteam = new System.Windows.Forms.TextBox();
            this.btnDeleteIteam = new System.Windows.Forms.Button();
            this.btnAddIteam = new System.Windows.Forms.Button();
            this.btnUpIteam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iditeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameiteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIsapxep = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHàngĐãHếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddIteam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddIteam
            // 
            this.gbAddIteam.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.gbAddIteam.BackgroundImage = global::QuanLyBanHang.Properties.Resources.hinh_nen_may_tinh_1;
            this.gbAddIteam.Controls.Add(this.txtSoLuong);
            this.gbAddIteam.Controls.Add(this.txtGia);
            this.gbAddIteam.Controls.Add(this.txtNameIteam);
            this.gbAddIteam.Controls.Add(this.txtIdIteam);
            this.gbAddIteam.Controls.Add(this.btnDeleteIteam);
            this.gbAddIteam.Controls.Add(this.btnAddIteam);
            this.gbAddIteam.Controls.Add(this.btnUpIteam);
            this.gbAddIteam.Controls.Add(this.label4);
            this.gbAddIteam.Controls.Add(this.label3);
            this.gbAddIteam.Controls.Add(this.label2);
            this.gbAddIteam.Controls.Add(this.label1);
            this.gbAddIteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddIteam.ForeColor = System.Drawing.Color.Black;
            this.gbAddIteam.Location = new System.Drawing.Point(12, 110);
            this.gbAddIteam.Name = "gbAddIteam";
            this.gbAddIteam.Size = new System.Drawing.Size(485, 277);
            this.gbAddIteam.TabIndex = 0;
            this.gbAddIteam.TabStop = false;
            this.gbAddIteam.Text = "Thêm Hàng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Location = new System.Drawing.Point(170, 153);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(134, 27);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGia.Location = new System.Drawing.Point(170, 113);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(134, 27);
            this.txtGia.TabIndex = 6;
            this.txtGia.Text = "0";
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameIteam
            // 
            this.txtNameIteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameIteam.Location = new System.Drawing.Point(170, 73);
            this.txtNameIteam.Name = "txtNameIteam";
            this.txtNameIteam.Size = new System.Drawing.Size(252, 27);
            this.txtNameIteam.TabIndex = 5;
            // 
            // txtIdIteam
            // 
            this.txtIdIteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdIteam.Location = new System.Drawing.Point(170, 33);
            this.txtIdIteam.Name = "txtIdIteam";
            this.txtIdIteam.Size = new System.Drawing.Size(169, 27);
            this.txtIdIteam.TabIndex = 4;
            // 
            // btnDeleteIteam
            // 
            this.btnDeleteIteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteIteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIteam.Location = new System.Drawing.Point(360, 200);
            this.btnDeleteIteam.Name = "btnDeleteIteam";
            this.btnDeleteIteam.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteIteam.TabIndex = 3;
            this.btnDeleteIteam.Text = "xóa";
            this.btnDeleteIteam.UseVisualStyleBackColor = true;
            // 
            // btnAddIteam
            // 
            this.btnAddIteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddIteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIteam.ForeColor = System.Drawing.Color.Black;
            this.btnAddIteam.Location = new System.Drawing.Point(10, 200);
            this.btnAddIteam.Name = "btnAddIteam";
            this.btnAddIteam.Size = new System.Drawing.Size(80, 40);
            this.btnAddIteam.TabIndex = 2;
            this.btnAddIteam.Text = "Thêm";
            this.btnAddIteam.UseVisualStyleBackColor = true;
            // 
            // btnUpIteam
            // 
            this.btnUpIteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpIteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpIteam.ForeColor = System.Drawing.Color.Black;
            this.btnUpIteam.Location = new System.Drawing.Point(170, 200);
            this.btnUpIteam.Name = "btnUpIteam";
            this.btnUpIteam.Size = new System.Drawing.Size(80, 40);
            this.btnUpIteam.TabIndex = 1;
            this.btnUpIteam.Text = "Sửa";
            this.btnUpIteam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Lượng :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món hàng :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Món hàng :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iditeam,
            this.nameiteam,
            this.gia,
            this.soluong});
            this.dataGridView1.Location = new System.Drawing.Point(503, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 521);
            this.dataGridView1.TabIndex = 1;
            // 
            // iditeam
            // 
            this.iditeam.HeaderText = "Mã món hàng";
            this.iditeam.MinimumWidth = 6;
            this.iditeam.Name = "iditeam";
            this.iditeam.Width = 125;
            // 
            // nameiteam
            // 
            this.nameiteam.HeaderText = "Tên món hàng";
            this.nameiteam.MinimumWidth = 6;
            this.nameiteam.Name = "nameiteam";
            this.nameiteam.Width = 125;
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(426, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 46);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh sách hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIsapxep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIsapxep
            // 
            this.TSMIsapxep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchHàngĐãHếtToolStripMenuItem,
            this.thoátToolStripMenuItem});
//            this.TSMIsapxep.Image = global::QuanLyBanHang.Properties.Resources.images__2_;
            this.TSMIsapxep.Name = "TSMIsapxep";
            this.TSMIsapxep.Size = new System.Drawing.Size(73, 24);
            this.TSMIsapxep.Text = "Xem";
            // 
            // danhSáchHàngĐãHếtToolStripMenuItem
            // 
            this.danhSáchHàngĐãHếtToolStripMenuItem.Name = "danhSáchHàngĐãHếtToolStripMenuItem";
            this.danhSáchHàngĐãHếtToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.danhSáchHàngĐãHếtToolStripMenuItem.Text = "Danh sách hàng đã hết!";
            // 
            // thoátToolStripMenuItem
            // 
//            this.thoátToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.images1;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(1148, 678);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbAddIteam);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Nhập Hàng";
            this.gbAddIteam.ResumeLayout(false);
            this.gbAddIteam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddIteam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddIteam;
        private System.Windows.Forms.Button btnUpIteam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteIteam;
        private System.Windows.Forms.TextBox txtIdIteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameiteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameIteam;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIsapxep;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHàngĐãHếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}