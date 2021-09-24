using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
namespace UnitTests
{
    [TestClass]
    public class UnitTestUsuarioModelo
    {
        [TestMethod]
        public void TestAutenticacionCorrecto(){
            UsuarioModelo u = new UsuarioModelo();
            u.NombreUsuario = "admin";
            u.Password = "123456";
            try{
                u.Autenticar();
                Assert.IsTrue(true);
            }
            catch{
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestAutenticacionIncorrecto(){
            UsuarioModelo u = new UsuarioModelo();
            u.NombreUsuario = "nada";
            u.Password = "nada";
            try{
                u.Autenticar();
                Assert.IsTrue(false);
            }
            catch{
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestCreacionUsuarioNuevo()
        {
            UsuarioModelo u = new UsuarioModelo();
            u.NombreUsuario = "jose";
            u.Password = "1234";
            try
            {
                u.Crear();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestCreacionUsuarioExistente()
        {
            UsuarioModelo u = new UsuarioModelo();
            u.NombreUsuario = "admin";
            u.Password = "1234";
            try
            {
                u.Crear();
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
