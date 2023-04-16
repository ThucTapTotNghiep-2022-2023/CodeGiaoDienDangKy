using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace webDangKiem.Models
{
    public class LichDangKiemView
    {
        [Required(ErrorMessage = "CCCD không được để trống!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "CCCD chỉ được nhập số")]
        [StringLength(maximumLength: 12, MinimumLength = 12, ErrorMessage = "CCCD chỉ được nhập 12 số")]
        public string cccd { get; set; }
        [Required(ErrorMessage = "Họ tên không được để trống!")]
        [RegularExpression(@"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆ
fFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTu
UùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ\s]+$", ErrorMessage = "Họ và tên Không được nhập số")]
        public string hoVaten { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Số điện thoại chỉ được nhập số")]
        [StringLength(10, ErrorMessage = "Số điện thoại chỉ được nhập 10 chữ số")]
        public string soDT { get; set; }
        [Required(ErrorMessage = "Email không được để trống!")]
        [RegularExpression(@"\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b", ErrorMessage = "không đúng định dạng mail")]
        public string email { get; set; }
        public int maPT { get; set; }
        [Required(ErrorMessage = "Biển số xe không được để trống!")]
        [RegularExpression(@"\b[\d]+[\w\ \d]{1,6}\b", ErrorMessage = "Biển số chưa đúng định dạng(VD:48A99999)")]
        [StringLength(maximumLength: 8, MinimumLength = 7, ErrorMessage = "Biển số phải nhập từ 7-8 chữ số")]
        public string bienSoxe { get; set; }

        public string loaiXe { get; set; }

        public int loaiBien { get; set; }
        public int maCPT { get; set; }

        public string khuVuc { get; set; }

        [Required(ErrorMessage = "Ngày đăng kiểm không được để trống!")]
        public System.DateTime ngayDangkiem { get; set; }

        [Required(ErrorMessage = "Ngày hết hạn không được để trống!")]
        public System.DateTime ngayHethan { get; set; }
        public int maTT { get; set; }

        //public void SendMail()
        //{
        //    MailMessage mc = new MailMessage(System.Configuration.ConfigurationManager.AppSettings["Email"].ToString(), email);
        //    mc.Subject = "Thông báo Đăng ký lịch";
        //    mc.Body = "Bạn đã đăng ký thành công lịch đăng kiểm";
        //    mc.IsBodyHtml = false;
        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //    smtp.Timeout = 1000000;
        //    smtp.EnableSsl = true;
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    NetworkCredential nc = new NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["Email"].ToString(), System.Configuration.ConfigurationManager.AppSettings["Password"].ToString());
        //    smtp.UseDefaultCredentials = false;
        //    smtp.Credentials = nc;
        //    smtp.Send(mc);
        //}
    }
}