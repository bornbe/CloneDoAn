using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang

{

    public partial class Form7 : Form

    {

        public Form7()

        {

            InitializeComponent();
            this.btnThanhToan.Click += BtnThanhToan_Click;

        }
        private void BtnThanhToan_Click(object sender, EventArgs e)

        {
            using (var f8 = new Form8())

            {
                f8.ShowDialog(this);
            }

        }
        private void btntrangchu_Click(object sender, EventArgs e)

        {

            Form f0 = new Form1();
            f0.Show();
            this.Close();

        }

    }

}