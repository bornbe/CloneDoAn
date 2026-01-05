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
    public partial class Form9 : Form
    {
        private Form8 _form8Cu;

        public Form9()
        {
            InitializeComponent();
        }
        public Form9(Form8 f8) : this()
        {
            _form8Cu = f8;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (_form8Cu != null)
            {
                _form8Cu.Show();
            }
            else
            {
                new Form8().Show();
            }
            this.Close();
        }
        private void btnhoantathoadon_Click(object sender, EventArgs e)
        {
                Form10 f10 = new Form10();
                f10.Show();
                this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}