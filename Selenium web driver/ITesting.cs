using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_web_driver
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void Login_test()
        {
            driver.Url = "https://meenaclick.com/passport/login";
            IWebElement element = driver.FindElement(By.ClassName("ant - input ant - input - lg ng - pristine ng - invalid ng - star - inserted ng - touched"));
            element.SendKeys("alfayedarnob007@gmail.com");
            IWebElement password = driver.FindElement(By.ClassName("ant-input ant-input-lg ng-pristine ng-invalid ng-star-inserted ng-touched"));
            password.SendKeys("arnob1234");
            
            String at = driver.Title;

            String et = "meena click";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/app-root/layout-passport/nz-layout/div/passport-login/div/div/div/div/div[2]/form/nz-form-item[3]/nz-form-control/div/div/button[1]"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}