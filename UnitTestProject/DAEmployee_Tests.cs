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
    public class DAEmployee_Tests
    {
        //[TestMethod()]
        //public void AddEmployeeTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DeleteEmployeeTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void GetAllEmployeesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEmployeeTest()
        {
            DAEmployee employee = new DAEmployee();
            TOEmployee empl = new TOEmployee();

            empl.Code = 3; //poner el codigo del emp a buscar
            TOEmployee actual;
            actual = employee.GetEmployee(3);//poner el codigo del emp esperado

            Assert.AreEqual(empl.Code, actual.Code);
        }

        //[TestMethod()]
        //public void ModifyEmployeeTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetEmployeesDepartmentTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void GetTotalHoursPerWeekTest()
        {
            DAEmployee employee = new DAEmployee();


            double expect = 35; //poner la cantidad de horas que trabajo
            double actual;
            actual = employee.GetTotalHoursPerWeek(3, 45);//poner el codigo del emp y la semana laborada

            Assert.AreEqual(expect, actual);
        }
    }
}