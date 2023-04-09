using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webDangKiem.Models;

namespace webDangKiem.Controllers
{
    public class HomeController : Controller
    {
        dbdangkiemEntities db = new dbdangkiemEntities();
        // GET: Home
        [HttpGet]
        public ActionResult Index() {
            ViewBag.Message = "DỊCH VỤ ĐĂNG KÝ LỊCH";
            return View();
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            List<Models.trungtam> listt = db.trungtams.ToList();
            List<Models.phuongtien> listpt = db.phuongtiens.ToList();
            ViewBag.KhuVuc = new SelectList(listt, "maTT", "KhuVuc");
            ViewBag.loaiXe = new SelectList(listpt, "maPT", "loaiXe");
            ViewBag.Message = "Trang Đăng Ký Lịch";
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(LichDangKiemView ldk1)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    List<Models.trungtam> listt = db.trungtams.ToList();
                    List<Models.phuongtien> listpt = db.phuongtiens.ToList();
                    ViewBag.KhuVuc = new SelectList(listt, "maTT", "KhuVuc");
                    ViewBag.loaiXe = new SelectList(listpt, "maPT", "loaiXe");

                    chuphuongtien cpt = new chuphuongtien();
                    cpt.cccd = ldk1.cccd;
                    cpt.hoVaten = ldk1.hoVaten;
                    cpt.soDT = ldk1.soDT;
                    cpt.email = ldk1.email;
                    cpt.maCPT = ldk1.maCPT;
                    db.chuphuongtiens.Add(cpt);
                    db.SaveChanges();
                    phuongtien pt = new phuongtien();
                    pt.bienSoxe = ldk1.bienSoxe;
                    pt.loaiBien = ldk1.loaiBien;
                    pt.loaiXe = ldk1.loaiXe;
                    pt.maPT = ldk1.maPT;
                    pt.maCPT = cpt.maCPT;
                    db.phuongtiens.Add(pt);
                    db.SaveChanges();
                    lichdangkiem ldk = new lichdangkiem();
                    ldk.ngayHethan = ldk1.ngayHethan;
                    ldk.ngayDangkiem = ldk1.ngayDangkiem;
                    ldk.maTT = ldk1.maTT;
                    ldk.maCPT = cpt.maCPT;
                    ldk.maPT = pt.maPT;
                    db.lichdangkiems.Add(ldk);
                    db.SaveChanges();
                    return View();
                }
                return RedirectToAction("DangKyThanhCong");
            } catch
            {
                return View();
            }
        }
        
        [HttpGet]
        public ActionResult TinTuc()
        {
            
            ViewBag.Message="Trang Tin Tức";
            return View();
        }
        [HttpGet]
        public ActionResult TraCuu(string searching)
        {
            
            ViewBag.Message = "Trang Tra Cứu Lịch Sử Đăng ký";
            var chuphuongtien = from ldk in db.lichdangkiems select ldk;
            if (!String.IsNullOrEmpty(searching))
            {
                chuphuongtien = chuphuongtien.Where(ldk => ldk.chuphuongtien.cccd.Contains(searching));

            }
            
            return View( chuphuongtien.ToList());

        }
    }
}