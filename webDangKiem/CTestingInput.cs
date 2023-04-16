using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webDangKiem.Models;

namespace webDangKiem
{
    public class CTestingInput 
    {
        public bool checkValidateData(LichDangKiemView ldkv)
        {
            if(ldkv.cccd.Equals("079201031411") && ldkv.hoVaten.Equals("Ha Hoang Long") && ldkv.soDT.Equals("0999099900") 
                && ldkv.email.Equals("Long@gmail.com") && ldkv.bienSoxe.Equals("48A90909")
                && ldkv.ngayDangkiem.Equals(DateTime.Parse("12/2/2012"))
                && ldkv.ngayHethan.Equals(DateTime.Parse("12/2/2012")))
                return true;
            return false;
        }
    }
}