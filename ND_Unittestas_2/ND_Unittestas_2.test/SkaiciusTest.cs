using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ND_Unittestas_2.test
{
    [TestClass]
    public class SkaiciusTest
    {
        [TestMethod]
        public void TikrinamArPaduotasSkaiciusYraLyginis()
        {
            // Arrange

            //Act
            bool arLyginis = Program.PalygintiArSkaiciusLyginis(2);
            //Assert
            Assert.AreEqual(arLyginis, true);
        }

        [TestMethod]
        public void TikrinamArPaduotasSkaiciusYraNelyginis()
        {
            // Arrange

            //Act
            bool arLyginis = Program.PalygintiArSkaiciusLyginis(3);
            //Assert
            Assert.AreEqual(arLyginis, false);
        }
    }
}
