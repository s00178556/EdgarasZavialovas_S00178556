using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdgarasZavialovas_S00178556;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPercentage()
        {
            //arrange
            Phone p1 = new Phone();
            decimal expectedPrice = 600m;

            //act
            p1.percentagePrice(50m);

            //assert
            Assert.AreEqual(expectedPrice, p1.Price);
        }
    }
}
