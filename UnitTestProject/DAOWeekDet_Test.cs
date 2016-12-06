using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace DataAccess.Tests
{
    [TestClass()]
    public class DAOWeekDet_Test
    {
        [TestMethod()]
        public void SaveWeekDetailTest()
        {
            DAOWeekDetail weekDet = new DAOWeekDetail();
            TOWorkWeekDetail week = new TOWorkWeekDetail();
            week.Code = 23;
            Boolean expec = true;

            Assert.AreEqual(expec, weekDet.SaveWeekDetail(week));
        }

        [TestMethod()]
        public void UpdateWeekDetailTest()
        {
            DAOWeekDetail weekDet = new DAOWeekDetail();
            TOWorkWeekDetail week = new TOWorkWeekDetail();
            week.Code = 25;
            Boolean expec = true;

            Assert.AreEqual(expec, weekDet.UpdateWeekDetail(week));
        }

        [TestMethod()]
        public void getWeekPerNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getWeekNumbersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getWeekNumbersTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void isWeekSavedTest()
        {
            DAOWeekDetail weekDet = new DAOWeekDetail();
                       
            Boolean expec = true;

            Assert.AreEqual(expec, weekDet.isWeekSaved(40));
        }
    }
}