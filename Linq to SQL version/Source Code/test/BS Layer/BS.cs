using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace test.BS_Layer
{
    class BS
    {
        //table user1
        public List<user1> FindUser(string username, string password)
        {
            DataDataContext data = new DataDataContext();
            var userquery = (from user in data.user1s
                             where user.username == username && user.password == password
                             select user).ToList<user1>();
            return userquery;

        }
        //register
        public bool Dangky(string username, string password, string hoten, string pass2)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                user1 user = new user1();
                user.username = username;user.password = password;user.hoten = hoten;user.pass2 = pass2;  
                data.user1s.InsertOnSubmit(user);
                data.user1s.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //quen mk
        public string timpass2(string username, string pass2)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from user in data.user1s
                             where user.username == username && user.pass2 == pass2
                             select user).SingleOrDefault();
                if (query != null)
                {
                    return query.password;
                }
                return null;
            }
            catch { return null; }
        }
        public bool QuenMk(string username, string password, string pass2)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from user in data.user1s
                             where user.username==username && user.pass2==pass2
                             select user).SingleOrDefault();
                if (query != null)
                {
                    query.password = password;
                     data.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }

        //table nguoi
        public System.Data.Linq.Table<nguoi> LayNguoi()
        {
            DataDataContext data = new DataDataContext();
            return data.nguois;

        }
        public bool ThemNguoi(string idnguoi, string hoten, string cmnd, string diachi, string quequan, string tuoi, string sdt, string tennguoithan, string sdtnguoithan)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                nguoi ng = new nguoi();
                ng.idnguoi = Convert.ToInt32(idnguoi);
                ng.hoten = hoten; ng.cmnd = cmnd; ng.diachi = diachi; ng.quequan = quequan; ng.tuoi = tuoi; ng.sdt = sdt; ng.tennguoithan = tennguoithan; ng.sdtnguoithan = sdtnguoithan;
                data.nguois.InsertOnSubmit(ng);
                data.nguois.Context.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaNguoi(string idnguoi, string hoten, string cmnd, string diachi, string quequan, string tuoi, string sdt, string tennguoithan, string sdtnguoithan)
        {   
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from ng in data.nguois
                             where ng.idnguoi == Convert.ToInt32(idnguoi)
                             select ng).SingleOrDefault();
                if (query != null)
                {
                    query.hoten = hoten;
                    query.cmnd = cmnd;query.diachi = diachi;query.quequan = quequan;query.tuoi = tuoi;query.sdt = sdt;query.tennguoithan = tennguoithan;query.sdtnguoithan = sdtnguoithan;
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return false; }
        }
        public bool XoaNguoi(string idnguoi)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var remove = (from ng in data.nguois
                              where ng.idnguoi == Convert.ToInt32(idnguoi)
                                select ng).SingleOrDefault();
                if (remove !=null)
                {
                    data.nguois.DeleteOnSubmit(remove);
                    data.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }
        //search--------------
        public List<nguoi>  Search(string type, string word)
        {
            DataDataContext data = new DataDataContext();
            var find = (from ng in data.nguois
                        where ng.hoten == word
                        select ng).Distinct();
            switch (type)
            {
                case "idnguoi":
                    find = (from ng in data.nguois
                            where ng.idnguoi == Convert.ToInt32(word)
                            select ng).Distinct();
                    break;
                case "hoten":
                    break;
                case "cmnd":
                    find = (from ng in data.nguois
                            where ng.cmnd == word
                            select ng).Distinct();
                    break;
                case "diachi":
                    find = (from ng in data.nguois
                            where ng.diachi == word
                            select ng).Distinct();
                    break;
                case "quequan":
                    find = (from ng in data.nguois
                            where ng.quequan == word
                            select ng).Distinct();
                    break;
                case "tuoi":
                    find = (from ng in data.nguois
                            where ng.tuoi == word
                            select ng).Distinct();
                    break;
                case "sdt":
                    find = (from ng in data.nguois
                            where ng.sdt == word
                            select ng).Distinct();
                    break;
                case "tennguoithan":
                    find = (from ng in data.nguois
                            where ng.tennguoithan == word
                            select ng).Distinct();
                    break;
                case "sdtnguoithan":
                    find = (from ng in data.nguois
                            where ng.sdtnguoithan == word
                            select ng).Distinct();
                    break;
            }
            
            if (find != null)
            {
                
                data.SubmitChanges();
            }
            return find.ToList();
        }
        //table phong
        public System.Data.Linq.Table<phong> LayPhong()
        {
            DataDataContext data = new DataDataContext();
            return data.phongs;
        }
        public bool ThemPhong(string idphong, string gia, string tinhtrang, string ghichu)
        {
          

            try
            {
                DataDataContext data = new DataDataContext();
                phong ph = new phong();
                ngph ngph = new ngph();
                diennuoc dn = new diennuoc();
                tienno no = new tienno();
                ph.idphong = Convert.ToInt32(idphong);                
                ph.gia = gia; ph.tinhtrang = tinhtrang;ph.ghichu = ghichu;
                ngph.idphong = Convert.ToInt32(idphong);
                dn.idphong = Convert.ToInt32(idphong);
                no.idphong = Convert.ToInt32(idphong);
                data.phongs.InsertOnSubmit(ph);
                data.ngphs.InsertOnSubmit(ngph); data.diennuocs.InsertOnSubmit(dn);data.tiennos.InsertOnSubmit(no);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaPhong(string idphong, string gia, string tinhtrang, string ghichu)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from ph in data.phongs
                             where ph.idphong == Convert.ToInt32(idphong)
                             select ph).SingleOrDefault();
                if (query != null)
                {
                    query.gia = gia;query.tinhtrang = tinhtrang;query.ghichu = ghichu;                  
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return false; }
        }
        public bool XoaPhong(string idphong)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var remove = (from ph in data.phongs
                              where ph.idphong == Convert.ToInt32(idphong)
                              select ph).SingleOrDefault();
                var remove1 = (from ph in data.ngphs
                              where ph.idphong == Convert.ToInt32(idphong)
                              select ph).SingleOrDefault();
                var remove2 = (from ph in data.diennuocs
                              where ph.idphong == Convert.ToInt32(idphong)
                              select ph).SingleOrDefault();
                var remove3 = (from ph in data.tiennos
                              where ph.idphong == Convert.ToInt32(idphong)
                              select ph).SingleOrDefault();

                if (remove != null)
                {
                    data.phongs.DeleteOnSubmit(remove);
                    data.ngphs.DeleteOnSubmit(remove1);
                    data.diennuocs.DeleteOnSubmit(remove2);
                    data.tiennos.DeleteOnSubmit(remove3);
                    data.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }
        //table ng ph
        public System.Data.Linq.Table<ngph> LayNgph()
        {
            DataDataContext data = new DataDataContext();
            return data.ngphs;
        }
        public bool SuaNgph(string idngph, string ten1, string ten2, string ngayvao, string ghichu)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from np in data.ngphs
                             where np.idphong == Convert.ToInt32(idngph)
                             select np).SingleOrDefault();
                if (query != null)
                {
                    query.hotennguoi1 = ten1;query.hotennguoi2 = ten2;query.ngayvao = ngayvao;query.ghichu = ghichu;
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return false; }
        }
        public string timnguoitheoid(string id)
        {
            DataDataContext data = new DataDataContext();
            var userquery = (from nguoi in data.nguois
                             where nguoi.idnguoi == Convert.ToInt32(id)
                             select nguoi).ToList<nguoi>();
            if (userquery.Count <= 0) return "null";
            else
                return userquery[0].hoten.ToString();
        }
        //table dien nuoc
        public System.Data.Linq.Table<diennuoc> LayDien()
        {
            DataDataContext data = new DataDataContext();
            return data.diennuocs;
        }
        public bool SuaDien(string idphong, string kwh, string nuoc, string ghichu)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from dn in data.diennuocs
                             where dn.idphong == Convert.ToInt32(idphong)
                             select dn).SingleOrDefault();
                if (query != null)
                {
                    query.kwh =Convert.ToInt32( kwh);query.nuoc =Convert.ToInt32( nuoc);query.ghichu = ghichu;
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return false; }
        }
        public bool Tinhtien(int giadien, int gianuoc)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from dn in data.diennuocs
                             where 1>0
                             select dn).SingleOrDefault();
                if (query != null)
                {
                    query.Tongtien = 1;
                    query.ghichu = "Giá điện : " + giadien + "k/kwh. Giá nước : " + gianuoc + "k/m3";
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return true; }
        }
        public string tongdien()
        {
            DataDataContext data = new DataDataContext();
            var query = (from dn in data.diennuocs
                         select dn.kwh).Sum();
            return Convert.ToString(query);
        }
        public string tongnuoc()
        {
            DataDataContext data = new DataDataContext();
            var query = (from dn in data.diennuocs
                         select dn.nuoc).Sum();
            return Convert.ToString(query);
        }
        public string tongtien()
        {
            DataDataContext data = new DataDataContext();
            var query = (from dn in data.diennuocs
                         select dn.Tongtien).Sum();
            return Convert.ToString(query);
        }
        //table lich su
        public System.Data.Linq.Table<lichsu> LayLichsu()
        {
            DataDataContext data = new DataDataContext();
            return data.lichsus;
        }
        public bool NhapvaoLS(string thangnam, string kwh, string nuoc, string tongtien, string date)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                lichsu ls = new lichsu();
                ls.thoigian = thangnam; ls.kwh = kwh;ls.nuoc = nuoc;ls.tien = tongtien;ls.ngaythem = date;
                data.lichsus.InsertOnSubmit(ls);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        //table giao dich
        public System.Data.Linq.Table<giaodich> LayGiaodich()
        {
            DataDataContext data = new DataDataContext();
            return data.giaodiches;
        }
        public bool ThemGD(string id, string idphong, string sotien, string ngaythanhtoan, string thoigian, string nguoithanhtoan, string ngaythemvao)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                giaodich gd = new giaodich();
                gd.idbill =Convert.ToInt32( id);gd.idphong =Convert.ToInt32( idphong);gd.sotien = Convert.ToInt32(sotien);gd.ngaythanhtoan = ngaythanhtoan;gd.thoigian = thoigian;gd.nguoithanhtoan = nguoithanhtoan;gd.ngaythemvao = ngaythemvao;
                data.giaodiches.InsertOnSubmit(gd);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaGD(string id, string idphong, string sotien, string ngaythanhtoan, string thoigian, string nguoithanhtoan, string ngaychinhsua)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from gd in data.giaodiches
                             where gd.idphong == Convert.ToInt32(idphong)
                             select gd).SingleOrDefault();
                if (query != null)
                {
                    query.idphong =Convert.ToInt32( id);query.sotien = Convert.ToInt32(sotien);query.ngaythanhtoan = ngaythanhtoan;query.thoigian = thoigian;query.nguoithanhtoan = nguoithanhtoan;query.ngaychinhsua = ngaychinhsua;
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return false; }
        }
        //table tien no
        public System.Data.Linq.Table<tienno> LayTienno()
        {
            DataDataContext data = new DataDataContext();
            return data.tiennos;
        }
        public void TruNo(string idphong, string sotien)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from no in data.tiennos
                             where no.idphong == Convert.ToInt32(idphong)
                             select no).SingleOrDefault();
                if (query != null)
                {
                    query.sotienno = Convert.ToInt32(query.sotienno) - Convert.ToInt32(sotien);
                    data.SubmitChanges();
                }

            }
            catch {  }
        }
        public bool SuaNo(string idphong, string sotien, string ghichu)
        {
            try
            {
                DataDataContext data = new DataDataContext();
                var query = (from no in data.tiennos
                             where no.idphong == Convert.ToInt32(idphong)
                             select no).SingleOrDefault();
                if (query != null)
                {
                    query.sotienno = Convert.ToInt32(sotien);
                    query.ghichu = ghichu;
                    data.SubmitChanges();
                }
                return true;

            }
            catch { return false; }
        }
    }
}
