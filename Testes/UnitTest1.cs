using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using M17E_INTRO_12H.Classes;
namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        /*Testa se o login devolve verdadeiro*/
        [TestMethod]
        public void TestMethod1()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "admin@gmail.com";
            utilizadores.palavra_passe = "54321";
            Assert.IsTrue(utilizadores.VerificaLogin());
        }
        /*Testa se o login devolve falso*/
        [TestMethod]
        public void TestMethod2()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "seila@gmail.com";
            utilizadores.palavra_passe = "54321";
            Assert.IsFalse(utilizadores.VerificaLogin());
        }
        /*Testa se o login devolve verdadeiro*/
        [TestMethod]
        public void TestMethod3()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "ADMIN@gmail.com";
            utilizadores.palavra_passe = "54321";
            Assert.IsTrue(utilizadores.VerificaLogin());
        }
        /*Testa SQL INJECTION*/
        [TestMethod]
        public void TestMethod4()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "a' OR 1=1 --";
            utilizadores.palavra_passe = "";
            Assert.IsTrue(utilizadores.VerificaLogin());
        }
    }
}
