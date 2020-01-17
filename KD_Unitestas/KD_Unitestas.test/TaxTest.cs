using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KD_Unitestas;

namespace KD_Unitestas.test
{
    [TestClass]
    public class TaxTest
    {
        [TestMethod]
        public void TaxTuriButi5ProcentaiKaiSumaMazesneUz40000()
        {
            //Arrange

            //Act
            decimal result = Program.Tax(40000);

            //Assert
            Assert.AreEqual(result, 2000);
        }

        [TestMethod]
        public void TaxTuriButi15ProcentaiKaiSumaDidesneUz50000IrMazesneUz100000()
        {
            //Arrange

            //Act
            decimal result = Program.Tax(50000);

            //Assert
            Assert.AreEqual(result, 7500);
        }

        [TestMethod]
        public void TaxTuriButi25ProcentaiKaiSumaDidesneUz100000()
        {
            //Arrange

            //Act
            decimal result = Program.Tax(150000);

            //Assert
            Assert.AreEqual(result, 37500);
        }

        [TestMethod]
        public void TaxTuriButi0KaiSuma0()
        {
            //Arrange

            //Act
            decimal result = Program.Tax(0);

            //Assert
            Assert.AreEqual(result, 0);
        }
    }
}
