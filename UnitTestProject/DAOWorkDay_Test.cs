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
    public class DAOWorkDay_Test
    {
        [TestMethod()]
        public void AddWorkDayDetailTest()
        {
            DAOWorkDay dayDet = new DAOWorkDay();
            TOWorkDayDetail day = new TOWorkDayDetail();
           
            Boolean expec = true;

            Assert.AreEqual(expec, dayDet.AddWorkDayDetail(day));
        }

        [TestMethod()]
        public void UpdateWorkDayDetailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getWorkDayTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getWorkedWeeksTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getEmployeesCalculatedWeekTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculatedDepartmentsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void isDepartmentRegisteredTest()
        {
            Assert.Fail();
        }
    }
}