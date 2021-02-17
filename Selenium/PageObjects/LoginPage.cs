using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    class LoginPage : Page
    {
        private By emailInput = By.CssSelector("#email"); 
        private By passwordInput = By.CssSelector("#password");
        private By submitBtn = By.CssSelector("button[type='submit']");
        private By alert = By.CssSelector(".alert strong");

        public void fillLoginForm(string email, string password)
        {
            base.SendKeys(emailInput, email);
            base.SendKeys(passwordInput, password);
            base.Click(submitBtn);
        }

        public string getAlert()
        {
            return base.GetValue(alert);
        }
    }
}
