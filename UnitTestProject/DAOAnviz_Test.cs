using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System;
using TransferObjects;

namespace DataAccess.Tests
{
    [TestClass()]
    public class DAOAnviz_Test
    {
        //[TestMethod()]
        //public void GetChecksTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetChecksWithRestsTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void AddDayDetailTest()
        {
            DAOAnviz anv = new DAOAnviz();
            TOWorkDayDetail dayDet = new TOWorkDayDetail(30, new DateTime(1,12,2016), new DateTime(2,12,2016));

            Boolean expect = true;
            Assert.AreEqual(expect, anv.AddDayDetail(dayDet));
        }

        [TestMethod()]
        public void checksbyDateTest()
        {
            DAOAnviz anv = new DAOAnviz();
            decimal expected = 4;

            Assert.AreEqual(expected, anv.checksbyDate(new DateTime(1, 12, 2016), "I"));
        }
    }
}