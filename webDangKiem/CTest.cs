using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
namespace webDangKiem
{
    public partial class CTest
    {
        public bool TraCuuLich(string cccd, string nhapcccd)
        {
            if(cccd != nhapcccd)
            { return false; }
            if(nhapcccd == "")
            { return false; }
            return true;
        }
    }
}