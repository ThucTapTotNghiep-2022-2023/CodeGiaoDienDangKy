using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webDangKiem;
using webDangKiem.Models;

namespace UnitTest.ModelTest
{
    [TestFixture]
    public class DataTest
    {
        [Test]
        public void testDataLichDangKiem()
        {
            LichDangKiemView ldkv = new LichDangKiemView()
            {
                cccd = "123321123321",
                hoVaten="Ha Hoang Long",
                soDT="0000000000",
                email="Long@gmail.com",
                bienSoxe="9099099",
                ngayDangkiem=DateTime.Parse(DateTime.Today.ToString()),
                ngayHethan= DateTime.Parse(DateTime.Today.ToString()),
            };
            var cti = new CTestingInput();
            var result = cti.checkValidateData(ldkv);
            Assert.That(result, Is.True);
        }
        [Test]
        public void testDataLichDangKiem1()
        {
            LichDangKiemView ldkv = new LichDangKiemView()
            {
                cccd = "079201031411",
                hoVaten = "Ha Hoang Long",
                soDT = "0999099900",
                email = "Long@gmail.com",
                bienSoxe = "48A90909",
                ngayDangkiem = DateTime.Parse(DateTime.Today.ToString()),
                ngayHethan = DateTime.Parse(DateTime.Today.ToString()),
            };
            var cti = new CTestingInput();
            var result = cti.checkValidateData(ldkv);
            Assert.That(result, Is.True);
        }
        [Test]
        public void testDataLichDangKiem3()
        {
            LichDangKiemView ldkv = new LichDangKiemView()
            {
                cccd = "079201031411",
                hoVaten = "Ha Hoang Long",
                soDT = "0999099900",
                email = "Long@gmail.com",
                bienSoxe = "48A90909",
                ngayDangkiem = DateTime.Parse("12/2/2012"),
                ngayHethan = DateTime.Parse("12/2/2012"),
            };
            var cti = new CTestingInput();
            var result = cti.checkValidateData(ldkv);
            Assert.That(result, Is.True);
        }
        [Test]
        public void testDataLichDangKiem4()
        {
            LichDangKiemView ldkv = new LichDangKiemView()
            {
                cccd = "079201031411",
                hoVaten = "Ha Hoang Long",
                soDT = "0999099900",
                email = "Long@gmail.com",
                bienSoxe = "48A90909",
                ngayDangkiem = DateTime.Parse("12/2/2012"),
                ngayHethan = DateTime.Parse("12/2/2012"),
            };
            var cti = new CTestingInput();
            var result = cti.checkValidateData(ldkv);
            Assert.That(result, Is.True);
        }
        [Test]
        public void testDataLichDangKiem5()
        {
            LichDangKiemView ldkv = new LichDangKiemView()
            {
                cccd = "079201031411",
                hoVaten = "Ha Hoang Long",
                soDT = "0999099900",
                email = "Long@gmail.com",
                bienSoxe = "48A90909",
                ngayDangkiem = DateTime.Parse("12/2/2012"),
                ngayHethan = DateTime.Parse("12/2/2012"),
            };
            var cti = new CTestingInput();
            var result = cti.checkValidateData(ldkv);
            Assert.That(result, Is.True);
        }
    }
}
