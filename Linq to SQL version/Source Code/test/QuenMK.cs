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
    public partial class QuenMK : Form
    {
        BS data = new BS();
        public QuenMK()
        {
            InitializeComponent();
        }

        private void tbrepass_TextChanged(object sender, EventArgs e)
        {
            if (tbpass.Text == tbrepass.Text)
            {
                label5.Text = "OK";
                label5.ForeColor = Color.Green;

            }
            else { label5.Text = "X"; label5.ForeColor = Color.Red; }
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            if (tbusername.Text != "" && tbpass2.Text != "")
            {
                string check = data.timpass2(tbusername.Text, tbpass2.Text);
                if (check != null)
                {
                    label1.Visible = false; ; label2.Visible = false; tbusername.Visible = false; tbpass2.Visible = false;
                    label3.Visible = true; label4.Visible = true; tbpass.Visible = true; tbrepass.Visible = true; label5.Visible = true;
                    btcheck.Text = "Phục Hồi";
                    if (label5.Text == "OK")
                    {
                        data.QuenMk(tbusername.Text, tbpass.Text, tbpass2.Text);
                        MessageBox.Show("Phục Hồi Thành Công!");
                        this.Close();
                    }
                    else if (label5.Text=="X") MessageBox.Show("Không thành công, vui lòng thử lại!");

                }
                else MessageBox.Show("Bạn Đã Nhập Sai Mk Cấp 2!");
            }
        }
    }
}
