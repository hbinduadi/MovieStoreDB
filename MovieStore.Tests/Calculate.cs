using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Business;
using MovieStore.Tests;


namespace MovieStore.Tests
{
    [TestClass]
    public class Calculate
    {
        [TestMethod]
        public void GetTaxPass()
        {
            //Arrange
            var Tc = new TaxCalculate();

            //Act 
            var taxAmt = Tc.GetTaxCalc(100);

            //Assert
            Assert.AreEqual(taxAmt, 8.00);
        }
        [TestMethod]
        public void GetTaxFail()
        {
            //Arrange
            var Tc = new TaxCalculate();

            //Act 
            var taxAmt = Tc.GetTaxCalc(100);

            //Assert
            Assert.AreNotEqual(taxAmt, 8.1);
        }

    }
}
