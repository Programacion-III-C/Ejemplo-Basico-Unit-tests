using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;

namespace UnitTests
{
    [TestClass]
    public class UnitTestNumeros
    {
        [TestMethod]
        public void TestSuma()
        {
            Numeros n = new Numeros();

            n.numero1 = 10;
            n.numero2 = 20;

            Assert.AreEqual(n.Sumar(), 30);
        }

        [TestMethod]
        public void TestMayor()
        {
            Numeros n = new Numeros();
            n.numero1 = 10;
            n.numero2 = 21;

            Assert.AreEqual(n.RetornarMayor(), n.numero2);
        }
    }
}
