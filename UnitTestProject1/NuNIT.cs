using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTestProject1
{
    class NuNIT
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        [TestMethod]
        public void OpenAppTest()
        {
            driver.Url = "https://student.almanac-learning.com";
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
