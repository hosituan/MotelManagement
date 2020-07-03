using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.BS_Layer;
using System.Data.Common;
using test.Properties;

namespace test
{
    public partial class DangKy : Form
    {
        BS data1 = new BS();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            bool f = data1.Dangky(txtusername.Text, txtpassword.Text, txthoten.Text, txtpass2.Text);
            if (f == true)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else MessageBox.Show("Đã có lỗi! Đăng ký thất bại!");
        }

        private void txtnhaplai_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == txtnhaplai.Text)
            {
                label6.Text = "OK";
            }
            else
            {
                label6.Text = "X";
            }
        }
    }
}
