using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Selenium.PageObjects;

namespace Selenium.Tests
{
    [TestFixture]
    class Login : Page
    {
        private HomePage home = new HomePage();
        private LoginPage login = new LoginPage();

        [Test]
        public void LoginPositive()
        {
            login.fillLoginForm("test@test.com", "test");
            Assert.That(home.getTitle(), Is.EqualTo("Bienvenido"));
        }

        [Test]
        public void LoginNegative()
        {
            login.fillLoginForm("test1@test.com", "test1");
            Assert.That(login.getAlert(), Is.EqualTo("Usuario o Contraseña invalido"));
        }
    }
}
