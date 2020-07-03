using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using test.DB_Layer;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace test.BS_Layer
{
    class clsBS
    {
        clsDB db = null;
        public clsBS()
        {
            db = new clsDB();
        }
        //table user-------------------------------------------------------------------
        public DataSet FindUser(string user, string password)
        {
            string sqlString = "select * from user1 where username='" + user + "' and password='"+password+"';";
            return db.ExecuteQueryDataSet(sqlString);
        }
        public string timpass2(string username, string pass2)
        {
            string sqlString = "SELECT * FROM user1 WHERE username = '" + username+ "' and pass2='"+pass2+"'";
            return db.FindNameExecute(sqlString);
        }
        //register
        public bool Dangky(string username, string password,string hoten, string pass2)
        {
            string sqlString = "insert into user1 values('" + username + "','" + password + "','" + hoten + "','" + pass2 + "');";
            return db.MyExecuteNonQuery(sqlString);
        }
        //quen mk
        public bool QuenMk(string username, string password, string pass2)
        {
            string sqlString = "update user1 set password='" + password + "' where username='" + username + "' and pass2='" + pass2 + "'";
            return db.MyExecuteNonQuery(sqlString);
        }
        //table nguoi--------------------------------------------------------------------------------
        public DataSet LayNguoi()
        {
            return db.ExecuteQueryDataSet("select idnguoi as 'ID', hoten as 'Họ và Tên', cmnd as 'CMND', diachi as 'Địa Chỉ'," +
                " quequan as 'Quê Quán',tuoi as 'Tuổi', sdt as 'Số Điện Thoại', tennguoithan as 'Tên Người Thân', sdtnguoithan as 'SĐT Người Thân' from nguoi");
        }
        public bool ThemNguoi(string idnguoi, string hoten, string cmnd, string diachi, string quequan, string tuoi, string sdt, string tennguoithan, string sdtnguoithan)
        {
            string sqlString = "Insert Into nguoi Values('" + idnguoi + "','" + hoten + "','" + cmnd + "','"
                + diachi + "','" + quequan + "','" + tuoi + "','" + sdt + "','"+tennguoithan+"','"+sdtnguoithan+"')";
            return db.MyExecuteNonQuery(sqlString);
        }
        public bool SuaNguoi( string idnguoi, string hoten, string cmnd, string diachi, string quequan, string tuoi, string sdt, string tennguoithan, string sdtnguoithan)
        {
            string sqlString = "Update nguoi SET hoten='" + hoten + "',cmnd='" + cmnd + "',diachi='" 
                + diachi + "',quequan='" + quequan + "',tuoi='" + tuoi + "',sdt='" + sdt + "',tennguoithan='" + tennguoithan +
                "',sdtnguoithan='" + sdtnguoithan + "' WHERE (idnguoi='" + idnguoi+"');";
            return db.MyExecuteNonQuery(sqlString);
        }
        public bool XoaNguoi(string idnguoi)
        {
            string sqlString = "Delete from nguoi where idnguoi=" + idnguoi;
            return db.MyExecuteNonQuery(sqlString);
        }
        //search
        public DataSet Search(string type, string word)
        {
            string sqlString = "Select * from nguoi where " + type + "='" + word + "';";
            return db.ExecuteQueryDataSet(sqlString);
        }


        //table phong----------------------------------------------------------------------------------------------------------
        public DataSet LayPhong()
        {
            return db.ExecuteQueryDataSet("select idphong as 'ID Phòng', gia as 'Giá', tinhtrang as 'Tình Trạng', ghichu as 'Ghi Chú' from phong");
        }
        public bool ThemPhong(string idphong, string gia, string tinhtrang, string ghichu)
        {
            string sqlString1 = "Insert Into phong Values('" + idphong + "','" + gia + "','" + tinhtrang + "','" + ghichu+ "');";
            string sqlString2 = "INSERT INTO ngph (idphong) VALUES ('" + idphong + "');";
            string sqlString3 = "INSERT INTO diennuoc (idphong) VALUES ('" + idphong + "');";
            string sqlString4 = "Insert into tienno (idphong) Values ('" + idphong + "');";
            string sqlString = sqlString1 + sqlString2 + sqlString3 + sqlString4;

            return db.MyExecuteNonQuery(sqlString);
        }
        public bool SuaPhong(string idphong, string gia, string tinhtrang, string ghichu)
        {
            string sqlString = "Update phong SET gia='" + gia + "', tinhtrang='" + tinhtrang + "', ghichu='" + ghichu + "' where (idphong='" + idphong+"')";
            return db.MyExecuteNonQuery(sqlString);
        }
        public bool XoaPhong(string idphong)
        {
            string sqlString = "Delete from phong where idphong=" + idphong + ";Delete from ngph where idphong="
                + idphong + ";Delete from tienno where idphong=" + idphong + ";Delete from diennuoc where idphong=" + idphong;
            return db.MyExecuteNonQuery(sqlString);
        }
        //table ng-ph------------------------------------------------------------------------------------------
        public DataSet LayNgph()
        {
            return db.ExecuteQueryDataSet("select idphong as 'ID Phòng', hotennguoi1 as 'Họ và Tên Người 1'," +
                " hotennguoi2 as 'Họ và Tên Người 2', ngayvao as 'Ngày Vào', ghichu as 'Ghi Chú' from ngph");
        }
        public bool SuaNgph(string idngph, string ten1, string ten2, string ngayvao, string ghichu)
        {
            string sqlString = "Update ngph SET hotennguoi1='" + ten1 + "',hotennguoi2='" + ten2 + "'," +
                "ngayvao='" + ngayvao + "',ghichu='" + ghichu + "' where (idphong='" + idngph + "')";
            return db.MyExecuteNonQuery(sqlString);
        }
        public string timnguoitheoid(string id)
        {
            string sqlString = "SELECT * FROM nguoi WHERE idnguoi = '" + id + "'";
            return db.FindNameExecute(sqlString);
        }
        //table diennuoc----------------------------------------------------------------------------------------
        public DataSet LayDien()
        {
            return db.ExecuteQueryDataSet("select idphong as 'ID Phòng', kwh as 'Điện (Kwh)', nuoc as 'Nước (m3)', " +
                "tongtien as 'Tổng tiền Điện - Nước', ghichu as 'Ghi Chú' from diennuoc");
        }
        public bool SuaDien(string idphong, string kwh, string nuoc, string ghichu)
        {
            string sqlString = "Update diennuoc SET kwh='" + kwh + "',nuoc='" + nuoc + "',ghichu='" + ghichu + "' where idphong='" + idphong + "'";
            return db.MyExecuteNonQuery(sqlString);
        }
        public bool Tinhtien(int giadien, int gianuoc)
        {
            string sqlstr = "Update diennuoc set ghichu = 'Giá điện : " + giadien + "k/Kwh. Giá nước : " + gianuoc + "k/m3.';";
            string sqlString = " UPDATE diennuoc set tongtien = 1000 * kwh *" + giadien + " + 1000* nuoc * " + gianuoc + ";" + sqlstr;
            return db.MyExecuteNonQuery(sqlString);
        }
        public string tongdien()
        {
            string sqlString = "select sum(kwh) from diennuoc";
            return db.Sum(sqlString);
        }
        public string tongnuoc()
        {
            string sqlString = "select sum(nuoc) from diennuoc";
            return db.Sum(sqlString);
        }
        public string tongtien()
        {
            string sqlString = "select sum(tongtien) from diennuoc";
            return db.Sum(sqlString);
        }
        //table lich su---------------------------------------------------------------------------------------------------
        public DataSet LayLichsu()
        {
            return db.ExecuteQueryDataSet("select thoigian as 'Thời Gian', kwh as 'Điện (Kwh)', " +
                "nuoc as 'Nước (m3)', tien as 'Tổng Tiền', ngaythem as 'Ngày Thêm' from lichsu");
        }
        public bool NhapvaoLS(string thangnam, string kwh, string nuoc, string tongtien, string date)
        {
            string sqlString = "Insert into lichsu values('" + thangnam + "','" + kwh + "','" + nuoc + "','" + tongtien + "','"+date+"' );";
            return db.MyExecuteNonQuery(sqlString);
        }

        //table giao dich-----------------------------------------------------------------------------------------------------
        public DataSet LayGiaodich()
        {
            return db.ExecuteQueryDataSet("select idbill as 'ID Bill', idphong as 'ID Phòng', " +
                "sotien as 'Số Tiền', ngaythanhtoan as 'Ngày Thanh Toán', thoigian as 'Thời gian Thanh Toán', " +
                "nguoithanhtoan as 'Người Thanh Toán', ngaythemvao as 'Ngày Thêm Vào', ngaychinhsua as 'Ngày Chỉnh Sửa' from giaodich");
        }
        public bool ThemGD(string id, string idphong, string sotien, string ngaythanhtoan, string thoigian, string nguoithanhtoan, string ngaythemvao )
        {
            string sqlString = "Insert into giaodich values('" + id + "','" + idphong + "','" + sotien + "','" + ngaythanhtoan + "','" + 
                thoigian + "','" +nguoithanhtoan + "','" +ngaythemvao + "','');";
            return db.MyExecuteNonQuery(sqlString);
        }

        public bool SuaGD(string id, string idphong, string sotien, string ngaythanhtoan, string thoigian, string nguoithanhtoan, string ngaychinhsua)
        {
            string sqlString = "Update giaodich SET idphong='" + idphong + "', sotien=' " + sotien + "'," +
                "ngaythanhtoan='" + ngaythanhtoan + "',thoigian='" + thoigian + "',nguoithanhtoan='" + nguoithanhtoan + "',ngaychinhsua='" + 
                ngaychinhsua + "' where idbill='" + id + "';";
            return db.MyExecuteNonQuery(sqlString);
        }
        //table no--------------------------------------------------------------------------------
        public DataSet LayNo()
        {
            return db.ExecuteQueryDataSet("select idphong as 'ID Phòng', sotienno as 'Số Tiền Nợ', ghichu as 'Ghi Chú' from tienno");
        }
        public void TruNo(string idphong, string sotien)
        {
            string sqlString = "Update tienno SET sotienno=sotienno-" + sotien + " where idphong='" + idphong + "';";
            db.MyExecuteNonQuery(sqlString);
        }
        public bool SuaNo(string idphong, string sotien, string ghichu)
        {
            string sqlString = "Update tienno SET sotienno='" + sotien + "', ghichu='"+ghichu+"' where idphong='" + idphong + "';";
            return db.MyExecuteNonQuery(sqlString);
        }

      
    }
}
