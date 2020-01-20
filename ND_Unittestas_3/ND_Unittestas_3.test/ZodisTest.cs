using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ND_Unittestas_3.test
{
    [TestClass]
    public class ZodisTest
    {
        [TestMethod]
        public void TestuojamArApversLabaiIlgaStringa()
        {
            // Arrange
            var zodisTest = new Zodis();
            //Act
            string apverstasZodis = zodisTest.ApverstiZodi("abcdefghijklmnqoprstuvwxyz1234567890ASESUKOSMONAUTASISMARSO");
            //Assert
            Assert.AreEqual(apverstasZodis, "OSRAMSISATUANOMSOKUSESA0987654321zyxwvutsrpoqnmlkjihgfedcba");
        }

        [TestMethod]
        public void TestuojamArApversStringaSuVienuSimboliu()
        {
            // Arrange
            var zodisTest = new Zodis();
            //Act
            string apverstasZodis = zodisTest.ApverstiZodi("$");
            //Assert
            Assert.AreEqual(apverstasZodis, "$");
        }

        [TestMethod]
        public void TestuojamArApversTusciaStringa()
        {
            // Arrange
            var zodisTest = new Zodis();
            //Act
            string apverstasZodis = zodisTest.ApverstiZodi("");
            //Assert
            Assert.AreEqual(apverstasZodis, "");
        }
    }
}
