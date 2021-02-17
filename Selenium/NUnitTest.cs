using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium
{
    class NUnitTest
    {
        public static string Url = "http://food-shop-admin.herokuapp.com/";
        public static IWebDriver Driver; 

        [SetUp]
        public void Initialize ()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Url = Url;
        }


        [TearDown]
        public void Close ()
        {
            Driver.Close(); 
        }
    }
}
