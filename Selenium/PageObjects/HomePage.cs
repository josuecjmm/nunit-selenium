using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    class HomePage : Page
    {
        private By title = By.CssSelector("h1");

        public string getTitle()
        {
            return base.GetValue(title);
        }
    }
}
