using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using test.BS_Layer;
using System.Data.Common;
using test.Properties;
using System.IO;

namespace test
{
    public partial class Form1 : Form
    {
        clsBS data = new clsBS();

        public Form1()
        {
            InitializeComponent();
            DisplayData();
            DisplayDataPhong();
            DisplayDataNgph();
            DisplayDataDiennuoc();
            DisplayDataLichsu();
            DisplayDataGiaodich();
            DisplayDataNo();
            DateTime theDate = DateTime.Now;
            tbngaythemvao.Text = theDate.ToString("yyyy-MM-dd H:mm");

        }
        //Phần khởi động/login----------------------------------------

        //button Đăng Ký
        private void lbdangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }
        //bấm vào quên mật khẩu
        private void lbquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK mk = new QuenMK();
            mk.Show();
        }
        //Button Đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbusername.Text != "")
            {
                DataSet ds = data.FindUser(tbusername.Text, tbpassword.Text);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    AutoClosingMessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu!", "Login...", 1000);
                    tbpassword.Text = "";

                }
                else
                {
                    AutoClosingMessageBox.Show("Đăng nhập Thành Công!", "Login...", 1000);
                    lbuser.Text = dt.Rows[0].Field<string>(2);

                    lbuser.Visible = true;
                    lblogout.Visible = true;
                    panel1.Height = 89;
                    //user thuong
                    btchinhsua.Enabled = false;
                    btthemgiaodich.Enabled = false;
                    btthemnguoi.Enabled = false;
                    btthemphong.Enabled = false;
                    btsua.Enabled = false;
                    btsuagiaodich.Enabled = false;
                    btsuanguoi.Enabled = false;
                    btsuano.Enabled = false;
                    btsuaphong.Enabled = false;
                    btxoanguoi.Enabled = false;
                    btxoaphong.Enabled = false;
                    //user admin
                    if (tbusername.Text == "admin")
                    {
                        btchinhsua.Enabled = true;
                        btthemgiaodich.Enabled = true;
                        btthemnguoi.Enabled = true;
                        btthemphong.Enabled = true;
                        btsua.Enabled = true;
                        btsuagiaodich.Enabled = true;
                        btsuanguoi.Enabled = true;
                        btsuano.Enabled = true;
                        btsuaphong.Enabled = true;
                        btxoanguoi.Enabled = true;
                        btxoaphong.Enabled = true;
                    }
                }
            }


        }
        //Button Đăng Xuất
        private void lblogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Height = 692;
            tbpassword.Text = "";
            lbuser.Visible = false;
            lblogout.Visible = false;
        }


        //Table Nguoi----------------------
        //Lấy danh sách người
        private void btlaydsnguoi_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        //hàm hiện dữ liệu
        public void DisplayData()
        {
            try
            {
                DataSet ds = data.LayNguoi();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");
            }
        }
        //hàm làm sạch dữ liệu textbox
        public void ClearData()
        {
            tbidnguoi.Text = "";
            tbhoten.Text = ""; tbcmnd.ResetText(); tbquequan.ResetText(); tbsdt.ResetText();
            tbsdtngthan.ResetText(); tbtuoi.ResetText(); tbtennguoithan.ResetText();
            tbdiachi.ResetText();
        }
        //button thêm người
        private void btthemnguoi_Click(object sender, EventArgs e)
        {
            if (tbidnguoi.Text != "" && tbhoten.Text != "" && tbcmnd.Text!="" && tbquequan.Text != "" && tbsdt.Text != "" )
            {
                bool f = data.ThemNguoi(tbidnguoi.Text, tbhoten.Text, tbcmnd.Text, tbdiachi.Text, tbquequan.Text, tbtuoi.Text,tbsdt.Text, tbtennguoithan.Text, tbsdtngthan.Text);
                if (f == true) { MessageBox.Show("Thêm Thành Công!"); ClearData(); }
                else MessageBox.Show("Đã có lỗi trong việc nhập thông tin!");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            DisplayData();
        }
        //button sửa thông tin người
        private void btsuanguoi_Click(object sender, EventArgs e)
        {

            bool f = data.SuaNguoi(tbidnguoi.Text, tbhoten.Text, tbcmnd.Text, tbdiachi.Text, tbquequan.Text, tbtuoi.Text, tbsdt.Text, tbtennguoithan.Text, tbsdtngthan.Text);
            if (f == true) { MessageBox.Show("Sửa Thành Công!"); ClearData(); }
            else MessageBox.Show("Đã xảy ra lỗi, không sửa được!");
            DisplayData();
        }
        //button xóa người
        private void btxoanguoi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn xóa hàng này chưa?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool f = data.XoaNguoi(tbidnguoi.Text);
                if (f == true) { MessageBox.Show("Xóa Thành Công!"); ClearData(); }
                else MessageBox.Show("Đã xảy ra lỗi, không xóa được!");
                DisplayData();
            }
            else if (dialogResult == DialogResult.No)
            {      
            }

        }
        //button làm sạch dữ liệu textbox
        private void btclr_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //lấy nội dung của hàng được click đưa ra textbox
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbidnguoi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbhoten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbcmnd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbquequan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbtuoi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbtennguoithan.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbsdtngthan.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        //select text của textbox tìm kiếm khi click vào
        private void tbser_Click(object sender, EventArgs e)
        {
            tbser.SelectAll();
        }
        //button tìm kiếm
        private void btsernguoi_Click(object sender, EventArgs e)
        {
            
            string select = comboBoxnguoi.GetItemText(comboBoxnguoi.SelectedItem);
            switch (select)
            {
                case "ID":
                    select = "idnguoi";
                    break;
                case "Họ và Tên":
                    select = "hoten"; break;
                case "CMND":
                    select = "cmnd"; break;
                case "Địa Chỉ":
                    select = "diachi"; break;
                case "Quê Quán":
                    select = "quequan"; break;
                case "Tuổi":
                    select = "tuoi"; break;
                case "SĐT":
                    select = "sdt"; break;
                case "Tên Người Thân":
                    select = "tennguoithan"; break;
                case "SĐT Người Thân":
                    select = "sdtngthan"; break;
                case "":
                    select = "idnguoi";break;
            }
            string word = tbser.Text;
            try
            {
                DataSet ds = data.Search(select, word);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, chưa thể tìm kiếm!");
            }

        }

        //Table Phong----------------------------
        //lấy danh sách phòng
        private void btlaydsphong_Click(object sender, EventArgs e)
        {
            DisplayDataPhong();
        }
        public void DisplayDataPhong()
        {
            try
            {
                DataSet ds = data.LayPhong();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView2.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");
            }
        }
        public void ClearDataPhong()
        {
            tbidphong.Text = "";tbgia.Text = "";tbtinhtrang.Text = "";tbghichu.Text = "";
        }
        //button thêm phòng
        private void btthemphong_Click(object sender, EventArgs e)
        {
            if (tbidphong.Text != "" && tbgia.Text != "" && tbtinhtrang.Text != "")
            {
                bool f = data.ThemPhong(tbidphong.Text, tbgia.Text, tbtinhtrang.Text, tbghichu.Text);
                if (f == true) { MessageBox.Show("Thêm Thành Công!"); DisplayDataPhong(); ClearDataPhong(); }
                else MessageBox.Show("Đã có lỗi trong việc nhập thông tin!");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            DisplayDataPhong();
        }
        //button sửa phòng
        private void btsuaphong_Click(object sender, EventArgs e)
        {
            bool f = data.SuaPhong(tbidphong.Text, tbgia.Text, tbtinhtrang.Text, tbghichu.Text);
            if (f == true) { MessageBox.Show("Sửa Thành Công!");DisplayDataPhong(); ClearDataPhong(); }
            else MessageBox.Show("Đã xảy ra lỗi, không sửa được!");
            DisplayDataPhong();
        }
        //button xóa phòng
        private void btxoaphong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn xóa hàng này chưa?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool f = data.XoaPhong(tbidphong.Text);
                if (f == true) { MessageBox.Show("Xóa Thành Công!"); ClearDataPhong(); }
                else MessageBox.Show("Đã xảy ra lỗi, không xóa được!");
                DisplayDataPhong();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        //button làm sạch dữ liệu textbox
        private void btclrphong_Click(object sender, EventArgs e)
        {
            ClearDataPhong();
        }
        //button lấy nội dung của hàng được click từ datagridview
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbidphong.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbgia.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbtinhtrang.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbghichu.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        //table ngph----------------------------------------------
        //lấy danh sách người phòng
        private void btlaydsngph_Click(object sender, EventArgs e)
        {
            DisplayDataNgph();
        }
        public void DisplayDataNgph()
        {
            try
            {
                DataSet ds = data.LayNgph();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView3.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");
            }
        }
        public void ClearDataNgph()
        {
            tbidngph.Text = "";
            tbidng1.Text = "";
            tbten1.Text = "";
            tbidng2.Text = "";
            tbten2.Text = "";
        }
        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbidngph.Text=dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            //tbidng1.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbten1.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
           // tbidng2.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbten2.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbngayvao.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbghichungph.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        //button làm sạch các textbox
        private void btclrngph_Click(object sender, EventArgs e)
        {
            ClearDataNgph();
        }
        //button sửa dữ liệu của phòng
        private void btsua_Click(object sender, EventArgs e)
        {
            bool f = data.SuaNgph(tbidngph.Text, tbten1.Text, tbten2.Text,tbngayvao.Text, tbghichu.Text);
            if (f == true) { MessageBox.Show("Sửa Thành Công!"); DisplayDataNgph(); ClearDataNgph(); }
            else MessageBox.Show("Đã xảy ra lỗi, không sửa được!");
            DisplayDataNgph();
        }
        //tự động lấy dữ liệu từ table người đưa sang textbox
        private void tbidng1_TextChanged(object sender, EventArgs e)
        {
            string id1 = tbidng1.Text;
            tbten1.Text = data.timnguoitheoid(id1);

        }
        private void tbidng2_TextChanged(object sender, EventArgs e)
        {
            string id2 = tbidng2.Text; tbten2.Text = data.timnguoitheoid(id2);
        }
        //table dien nuoc------------------------------------------------------
        public void DisplayDataDiennuoc()
        {
            try
            {
                DataSet ds = data.LayDien();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView4.DataSource = dt;
                lbdien.Text = data.tongdien();
                lbnuoc.Text = data.tongnuoc();
                lbtien.Text = data.tongtien();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");
            }
        }
        public void ClearDataDiennuoc()
        {
            tbidphongdien.Text = "";
            tbkwh.Text = "";
            tbnuoc.Text = "";
            tbghichudien.Text = "";
        }
        //lấy danh sách điện nước
        private void btlaydsdien_Click(object sender, EventArgs e)
        {
            DisplayDataDiennuoc();
        }
        //chỉnh sửa giá trị điện nước của phòng
        private void btchinhsua_Click(object sender, EventArgs e)
        {
            bool f = data.SuaDien(tbidphongdien.Text,tbkwh.Text,tbnuoc.Text,tbghichudien.Text);
            if (f == true) { MessageBox.Show("Sửa Thành Công!"); DisplayDataDiennuoc(); ClearDataDiennuoc(); }
            else MessageBox.Show("Đã xảy ra lỗi, không sửa được!");
            DisplayDataDiennuoc();
        }
        //làm sạch các textbox
        private void btclrdn_Click(object sender, EventArgs e)
        {
            ClearDataDiennuoc();
        }
        //lấy dữ liệu hàng của datagrid view khi click
        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbidphongdien.Text= dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbkwh.Text= dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbnuoc.Text= dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbghichudien.Text= dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        //----------------
        //select text ở textbox giá điện, nước
        private void tbgiadien_Click(object sender, EventArgs e)
        {
            tbgiadien.SelectAll();
        }
        private void tbgianuoc_Click(object sender, EventArgs e)
        {
            tbgianuoc.SelectAll();
        }
        //button tính tiền điện
        private void bttinhtiendien_Click(object sender, EventArgs e)
        {
            try
            {
                int giadien = Convert.ToInt32(tbgiadien.Text);
                int gianuoc = Convert.ToInt32(tbgianuoc.Text);
                bool f = data.Tinhtien(giadien, gianuoc);
                if (f == true) { MessageBox.Show("Tính tiền Thành Công!"); DisplayDataDiennuoc(); }
                else MessageBox.Show("Đã xảy ra lỗi, không tính được!");
                DisplayDataDiennuoc();
            }
            catch
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!");
            }          
        }

        //table lich su------------------------------------------------------------------------------------
        private void btnhapvaolichsu_Click(object sender, EventArgs e)
        {
            string select = comboxthang.GetItemText(comboxthang.SelectedItem);
            string thangnam = select + "/" + tbnam.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn nhập này chứ? Không thể quay lại!", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime theDate = DateTime.Now;
                string date = theDate.ToString("yyyy-MM-dd H:mm:ss");
                bool f = data.NhapvaoLS(thangnam, lbdien.Text, lbnuoc.Text, lbtien.Text, date);
                if (f == true) { MessageBox.Show("Nhập Thành Công!"); }
                else MessageBox.Show("Đã xảy ra lỗi, không nhập được!");

            }
            else if (dialogResult == DialogResult.No)
            {
            }

        }
        private void tbnam_Click(object sender, EventArgs e)
        {
            tbnam.SelectAll();
        }
        public void DisplayDataLichsu()
        {
            try
            {
                DataSet ds = data.LayLichsu();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView5.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");
            }
        }

        private void btlaydslichsu_Click(object sender, EventArgs e)
        {
            DisplayDataLichsu();
        }

        //table giao dich
        public void DisplayDataGiaodich()
        {
            try
            {
                DataSet ds = data.LayGiaodich();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView6.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");

            }
        }
        public void ClearDataGD()
        {
            tbidgd.Text = "";tbphonggd.Text = "";tbsotiengd.Text = "";tbngaythanhtoan.Text = "";tbthoigiangd.Text = "";tbnguoithanhtoan.Text = "";
        }

        //giao dich chi co them sua, khong co xoa, ghi lai lich su day du
        private void btlaydsgiaodich_Click(object sender, EventArgs e)
        {
            DisplayDataGiaodich();
        }
        private void btthemgiaodich_Click(object sender, EventArgs e)
        {

            DateTime theDate = DateTime.Now;
            string date = theDate.ToString("yyyy-MM-dd H:mm:ss");
            bool f = data.ThemGD(tbidgd.Text,tbphonggd.Text,tbsotiengd.Text,tbngaythanhtoan.Text,tbthoigiangd.Text,tbnguoithanhtoan.Text,date);
            if (f == true) {
                //xuat file
                string filepath = "D:\\" + tbidgd.Text + ".txt";
                System.IO.FileStream fs = new FileStream(filepath, FileMode.Create);          
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine("ID giao dịch :"+ tbidgd.Text);
                sWriter.WriteLine("Phòng :" + tbphonggd.Text);
                sWriter.WriteLine("Số tiền :" + tbsotiengd.Text);
                sWriter.WriteLine("Ngày Thanh Toán :"+tbngaythanhtoan.Text);
                sWriter.WriteLine("Thời gian thanh toán  :"+tbthoigiangd.Text);
                sWriter.WriteLine("Người thanh toán :"+tbnguoithanhtoan.Text);

                // Ghi và đóng file
                sWriter.Flush();
                fs.Close();

                data.TruNo(tbphonggd.Text, tbsotiengd.Text);
                MessageBox.Show("Thêm Thành Công! Trừ nợ thành công cho phòng :" + tbphonggd.Text + ". Xuất file giao dịch tại " + filepath); DisplayDataGiaodich(); ClearDataGD();
            }
            else MessageBox.Show("Đã xảy ra lỗi, không thêm được!");
            DisplayDataGiaodich();

        }

        private void btclrgd_Click(object sender, EventArgs e)
        {
            ClearDataGD();
        }
        private void btsuagiaodich_Click(object sender, EventArgs e)
        {
            DateTime theDate = DateTime.Now;
            string date = theDate.ToString("yyyy-MM-dd H:mm:ss");
            bool f = data.SuaGD(tbidgd.Text, tbphonggd.Text, tbsotiengd.Text, tbngaythanhtoan.Text, tbthoigiangd.Text, tbnguoithanhtoan.Text, date);
            if (f == true) { MessageBox.Show("Sửa Thành Công!"); DisplayDataGiaodich(); ClearDataGD(); }
            else MessageBox.Show("Đã xảy ra lỗi, không sửa được!");
            DisplayDataGiaodich();
        }
        private void dataGridView6_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbidgd.Text = dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbphonggd.Text = dataGridView6.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbsotiengd.Text = dataGridView6.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbngaythanhtoan.Text = dataGridView6.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbthoigiangd.Text = dataGridView6.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbnguoithanhtoan.Text = dataGridView6.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //tabel tienno
        public void DisplayDataNo()
        {
            try
            {
                DataSet ds = data.LayNo();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridView7.DataSource = dt;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Đã có lỗi, Không thể lấy danh sách!");

            }
        }
        private void btsuano_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn sửa này chứ?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime theDate = DateTime.Now;
                string date = theDate.ToString("yyyy-MM-dd H:mm:ss");
                bool f = data.SuaNo(tbphongno.Text, tbtienno.Text, tbghichuno.Text + "          |      " + date);
                if (f == true) { MessageBox.Show("Sửa Thành Công!");DisplayDataNo(); }
                else MessageBox.Show("Đã xảy ra lỗi, không sửa được!");

            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void dataGridView7_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbphongno.Text = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbtienno.Text = dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbghichuno.Text = dataGridView7.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void btclrno_Click(object sender, EventArgs e)
        {
            tbphongno.Text = "";
            tbtienno.Text = "";tbghichuno.Text = "";
        }

        //-------------------------------------------------------------------------------------------------------

        private void btno_Click(object sender, EventArgs e)
        {
            DisplayDataNo();
        }


        //login
        private void tbusername_Click(object sender, EventArgs e)
        {
            tbusername.SelectAll();
        }

        private void tbpassword_Click(object sender, EventArgs e)
        {
            tbpassword.SelectAll();
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime theDate = DateTime.Now;
            lbtime.Text = theDate.ToString("yyyy-MM-dd     H:mm:ss");
        }


    }
    //auto close message box
    public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        
}
