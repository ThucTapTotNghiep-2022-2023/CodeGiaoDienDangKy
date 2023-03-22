using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webDangKiem.Models;

namespace webDangKiem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index() {
            ViewBag.Message ="DỊCH VỤ ĐĂNG KÝ LỊCH";
            return View();
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            List<TinhThanhPho> lst = new List<TinhThanhPho>();
            TinhThanhPho tinhthanh;
            tinhthanh = new TinhThanhPho();
            tinhthanh.idCity = 1;
            tinhthanh.CityName = "TPHCM";
            lst.Add(tinhthanh);
            tinhthanh = new TinhThanhPho();
            tinhthanh.idCity = 2;
            tinhthanh.CityName = "CanTho";
            lst.Add(tinhthanh);
            tinhthanh = new TinhThanhPho();
            tinhthanh.idCity = 3;
            tinhthanh.CityName = "VungTau";
            lst.Add(tinhthanh);
            tinhthanh = new TinhThanhPho();
            tinhthanh.idCity = 4;
            tinhthanh.CityName = "HaNoi";
            lst.Add(tinhthanh);

            ViewBag.TinhThanhPho = new SelectList(lst, "idCity", "CityName");


            List<LoaiXe> lstXe = new List<LoaiXe>();
            LoaiXe lx;
            lx = new LoaiXe();
            lx.idXe = 1;
            lx.tenXe = "Ô tô chở người các loại đến 09 chỗ không kinh doanh vận tải";
            lstXe.Add(lx);

            lx = new LoaiXe();
            lx.idXe = 1;
            lx.tenXe = "Ô tô chở người các loại đến 09 chỗ có kinh doanh vận tải";
            lstXe.Add(lx);

            lx = new LoaiXe();
            lx.idXe = 1;
            lx.tenXe = "Ô tô chở người các loại trên 09 chỗ";
            lstXe.Add(lx);

            lx = new LoaiXe();
            lx.idXe = 1;
            lx.tenXe = "Ô tô tải các loại, ô tô chuyên dùng, ô tô đầu kéo, rơ moóc, sơmi rơ moóc";
            lstXe.Add(lx);

            ViewBag.LoaiXe = new SelectList(lstXe, "idXe", "tenXe");

            ViewBag.Message="Trang Đăng Ký Lịch";
            return View();
        }

        [HttpGet]
        public ActionResult TinTuc()
        {
            ViewBag.Message="Trang Tin Tức";
            return View();
        }
    }
}