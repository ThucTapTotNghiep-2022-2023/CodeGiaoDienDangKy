using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDangKiem.Models
{
    public class tinTuc
    {
        public int idTT { get; set; }
        public string nameTT { get; set; }
        public string imgTT { get; set; }
        public string motaTT { get; set; }
        public string nguonTT { get; set; }
        public string linkTT { get; set; }

        public List<tinTuc> danhSach() {
            var danhsachTinTuc = new List<tinTuc>();
            tinTuc tt1 = new tinTuc();
            tt1.idTT = 1;
            tt1.nameTT = "Tài xế chờ hơn 2 tháng để đăng kiểm xe";
            tt1.imgTT = "https://i1-vnexpress.vnecdn.net/2023/04/09/img-8565-jpg-6558-1680779115-1-2110-2908-1681013731.jpg?w=500&h=300&q=100&dpr=2&fit=crop&s=fG_RvTAGD16ZZvZT2wg7fw";
            tt1.motaTT = "Dù được bổ sung nhân lực, đăng kiểm vẫn quá tải, tài xế ở TP HCM phải đợi hơn 2 tháng để xét xe, ảnh hưởng công việc, mất thu nhập";
            tt1.nguonTT = "VNExpress";
            tt1.linkTT = "https://vnexpress.net/tai-xe-cho-hon-2-thang-de-dang-kiem-xe-4590402.html";
            danhsachTinTuc.Add(tt1);

            tinTuc tt2 = new tinTuc();
            tt2.idTT = 2;
            tt2.nameTT = "Phó giám đốc Trung tâm đăng kiểm Lâm Đồng bị bắt";
            tt2.imgTT = "https://i1-vnexpress.vnecdn.net/2023/04/06/DangkiemLamDong-1680778264-2156-1680778447.jpg?w=500&h=300&q=100&dpr=2&fit=crop&s=LYk4a4aSkgBLZsq1gd4KqQ";
            tt2.motaTT = "Ông Phan Hoàng Vũ, Phó giám đốc trung tâm đăng kiểm Lâm Đồng, và 3 người bị cáo buộc nhận \"lót tay\" rồi bỏ qua các lỗi khi đăng kiểm xe cho công ty của vợ một thanh tra sở. ";
            tt2.nguonTT = "VNExpress";
            tt2.linkTT = "https://vnexpress.net/pho-giam-doc-trung-tam-dang-kiem-lam-dong-bi-bat-4590398.html";
            danhsachTinTuc.Add(tt2);

            tinTuc tt3 = new tinTuc();
            tt3.idTT = 3;
            tt3.nameTT = "Giám đốc Trung tâm đăng kiểm 61-09D ở Bình Dương bị bắt";
            tt3.imgTT = "https://i1-vnexpress.vnecdn.net/2023/03/31/phong-1680243267-5409-1680243566.jpg?w=500&h=300&q=100&dpr=2&fit=crop&s=uYTV6FCdoTeyAnczLH2p9g";
            tt3.motaTT = "Ông Võ Quốc Phong, 43 tuổi, Giám đốc Trung tâm đăng kiểm xe cơ giới 61-09D, cùng bốn nhân viên bị bắt để điều tra sai phạm giả mạo trong công tác, nhận hối lộ. ";
            tt3.nguonTT = "VNExpress";
            tt3.linkTT = "https://vnexpress.net/giam-doc-trung-tam-dang-kiem-61-09d-o-binh-duong-bi-bat-4587883.html";
            danhsachTinTuc.Add(tt3);

            tinTuc tt4 = new tinTuc();
            tt4.idTT = 4;
            tt4.nameTT = "Cục Đăng kiểm: Độ đèn pha phải dùng loại hợp quy";
            tt4.imgTT = "https://i1-vnexpress.vnecdn.net/2023/03/27/mg-9785-jpg-1679922190-9112-1679922300.jpg?w=500&h=300&q=100&dpr=2&fit=crop&s=oXOqBnldSMp3yY1lQQzGVw";
            tt4.motaTT = "Ngoài việc đáp ứng các tiêu chuẩn kỹ thuật, đèn ôtô mà người dùng độ phải là loại đã được chứng nhận hoặc đăng ký hợp quy.";
            tt4.nguonTT = "VNExpress";
            tt4.linkTT = "https://vnexpress.net/cuc-dang-kiem-do-den-pha-phai-dung-loai-hop-quy-4586212.html";
            danhsachTinTuc.Add(tt4);

            tinTuc tt5 = new tinTuc();
            tt5.idTT = 5;
            tt5.nameTT = "Nhiều cán bộ đăng kiểm trục lợi chính sách, hưởng số tiền rất lớn";
            tt5.imgTT = "https://i1-vnexpress.vnecdn.net/2023/03/28/IMG6123JPG-1679991890-6621-1679991914.jpg?w=500&h=300&q=100&dpr=2&fit=crop&s=1Pv85kbfacrd_lgj1FJj3A";
            tt5.motaTT = "HÀ NỘI-Người phát ngôn Bộ Công an cho biết hàng trăm nghi phạm trong sai phạm đăng kiểm đã trục lợi chính sách để hưởng lợi cá nhân với \"số tiền rất lớn\".";
            tt5.nguonTT = "VNExpress";
            tt5.linkTT = "https://vnexpress.net/nhieu-can-bo-dang-kiem-truc-loi-chinh-sach-huong-so-tien-rat-lon-4586404.html";
            danhsachTinTuc.Add(tt5);

            return danhsachTinTuc;
        }
    }
}