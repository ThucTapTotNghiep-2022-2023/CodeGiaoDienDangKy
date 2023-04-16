using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using webDangKiem;
using webDangKiem.Controllers;
using webDangKiem.Models;
using System.Web.Mvc;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        
        [TestMethod]
        public void TestMethod1()
        {
            string cccd = "112543234876";
            string nhapcccd = "112543234876";
            CTest CT = new CTest();
            Assert.AreEqual(true, CT.TraCuuLich(cccd, nhapcccd));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string cccd = "112543234878";
            string nhapcccd = "112543234876";
            CTest CT = new CTest();
            Assert.AreEqual(true, CT.TraCuuLich(cccd, nhapcccd));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string cccd = "112543234876";
            string nhapcccd = "112543234876";
            CTest CT = new CTest();
            Assert.AreEqual(true, CT.TraCuuLich(cccd, nhapcccd));
        }
        
    }
}
