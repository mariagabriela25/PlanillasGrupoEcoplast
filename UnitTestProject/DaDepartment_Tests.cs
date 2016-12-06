using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using TransferObjects;

namespace DataAccess.Tests
{
    [TestClass()]
    public class DaDepartment_Tests
    {
        //[TestMethod()]
        //public void addDepartmentTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void modifyDepartmentTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void deleteDepartmentTest()
        //{
        //    DADepartment dep = new DADepartment();
        //    TODepartment depExpected = new TODepartment();

        //    int expected = 1;
        //    //int actual = dep.deleteDepartment(depExpected);
        //    //No se puede probar xq no retorna nada

        //    Assert.Fail();
        //}

        [TestMethod()]
        public void GetAllDepartmentsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDepartmentTest()
        {
            DADepartment dep = new DADepartment();
            TODepartment depExpected = new TODepartment();

            depExpected.Name = "conversion";            
            TODepartment actual;
            actual = dep.GetDepartment(11);//codigo del departamento a traer

            Assert.AreEqual(actual.Name, depExpected.Name);                 
        }


        [TestMethod()]
        public void searchDepartmentTest()
        {
            DADepartment dep = new DADepartment();
            TODepartment depExpected = new TODepartment();

            depExpected.Code = 11; //poner el codigo del dep a buscar
            TODepartment actual;
            actual = dep.searchDepartment("conversion");

            Assert.AreEqual(actual.Code, depExpected.Code);
            
        }
    }
}