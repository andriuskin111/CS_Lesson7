using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ND_Strukturos_Advanced_2.test
{
    [TestClass]
    public class RinkejasTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var rinkejas = new Rinkejas();
            //Act
            int rezultatas = rinkejas.Testas(10);
            //Assert
            Assert.AreEqual(rezultatas, 20);
        }
    }
}
