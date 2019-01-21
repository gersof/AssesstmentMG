using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Assessment.Business.Test
{
    [TestClass]
    public class EmployeesComponentTest
    {
        public EmployeesComponentTest()
        {
            ConfigurationManager.AppSettings["BaseUrlEmployees"] = "http://masglobaltestapi.azurewebsites.net/api/";
        }

        [TestMethod]
        public async Task GetAll_Success()
        {
            var result = await new EmployeesComponent().GetAll(null);
            Assert.IsTrue(result.Count() == 2);
        }

        [TestMethod]
        public async Task GetEmployee_Success()
        {
            var result = await new EmployeesComponent().GetAll(1);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"Id does not exist.")]
        public async Task GetEmployee_Fail()
        {
            var result = await new EmployeesComponent().GetAll(77);
        }
    }
}
