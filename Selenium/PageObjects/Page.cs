using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.PageObjects
{
    class Page : NUnitTest
    {
        public void SendKeys(By selector, string text)
        {
            NUnitTest.Driver.FindElement(selector).SendKeys(text);
        } 
        
        public string GetValue(By selector)
        {
            return NUnitTest.Driver.FindElement(selector).Text;
        }

        public void Click(By selector)
        {
            NUnitTest.Driver.FindElement(selector).Click();
        }
    }
}
