using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDangKiem.Models
{
    public class LichDangKiemView
    {
        public string cccd { get; set; }
        public string hoVaten { get; set; }
        public string soDT { get; set; }
        public string email { get; set; }
        public int maPT { get; set; }
        public string bienSoxe { get; set; }
        public string loaiXe { get; set; }
        public int loaiBien { get; set; }
        public int maCPT { get; set; }
        public string khuVuc { get; set; }
        public System.DateTime ngayDangkiem { get; set; }
        public System.DateTime ngayHethan { get; set; }
        public int maTT { get; set; }
    }
}