using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            var x = 0;
            while (x> -1)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                driver.Url = "https://student.almanac-learning.com";
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='navbarNav3']/ul/li[6]/a")).Click();
                driver.FindElement(By.XPath("/html/body/app-root/div/div/app-account/div/div/div/div[2]/div[1]/div[1]/div[1]/a")).Click();
                driver.FindElement(By.XPath("//*[@id='cred-userid-inputtext']")).SendKeys("shahnawm@tcd.ie");
                driver.FindElement(By.Id("cred-password-inputtext")).SendKeys("Shah@nawaz123");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='submit-button']")).Click();
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("/html/body/app-root/div/div/app-menu-bar/div/ul/li[3]/a")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='form1']")).SendKeys("measure");
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/app-root/div/div/app-search/div[1]/div/div/div/form/button")).Click();
                Thread.Sleep(6000);
                var list = driver.FindElements(By.ClassName("card-fav"));
                var count = list.Count;
                list[x].Click();
                if (x == count)
                    break;
                Thread.Sleep(9000);
                IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

                jse.ExecuteScript("document.getElementsByClassName('btn btn-yes btn-sm')[1].click();");
                Thread.Sleep(1000);
                jse.ExecuteScript("document.getElementsByClassName('btn btn-primary btn-sm')[0].click();");
                Thread.Sleep(15000);
                x++;
                driver.Close();
            }
              }
    }
}
