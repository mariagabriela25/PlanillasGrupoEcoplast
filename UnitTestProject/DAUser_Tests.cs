using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tests
{
    [TestClass()]
    public class DAUser_Tests
    {
        [TestMethod()]
        public void grantAccessTest()
        {
            DAOuser user = new DAOuser();

            Boolean expect = true; 
            Boolean actual;

            actual = user.grantAccess("pass");

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void ChangePsw()
        {
            DAOuser user = new DAOuser();

            Boolean expect = true; 
            Boolean actual;

            actual = user.ChangePsw("passold", "passnew");//poner el codigo del emp y la semana laborada

            Assert.AreEqual(expect, actual);
        }


    }
}