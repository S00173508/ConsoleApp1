using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class SeleniumTest2
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSeleniumTest2Test()
        {
            driver.Navigate().GoToUrl("http://localhost:52647/Home/Index");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Name("Cal")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Result'])[1]/following::input[1]")).Click();
            try
            {
                Assert.AreEqual("5", driver.FindElement(By.XPath("//input[@value='5']")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        [Test]
        public void TheSeleniumTest2Test2()
        {
            driver.Navigate().GoToUrl("http://localhost:52647/Home/Index");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("29");
            driver.FindElement(By.Name("Cal")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Result'])[1]/following::input[1]")).Click();
            try
            {
                Assert.AreEqual("6", driver.FindElement(By.XPath("//input[@value='6']")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        [Test]
        public void TheSeleniumTest2Test3()
        {
            driver.Navigate().GoToUrl("http://localhost:52647/Home/Index");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("58");
            driver.FindElement(By.Name("Cal")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Result'])[1]/following::input[1]")).Click();
            try
            {
                Assert.AreEqual("2.5", driver.FindElement(By.XPath("//input[@value='2.5']")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        [Test]
        public void TheSeleniumTest2Test4()
        {
            driver.Navigate().GoToUrl("http://localhost:52647/Home/Index");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("48");
            driver.FindElement(By.Name("Cal")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Result'])[1]/following::input[1]")).Click();
            try
            {
                Assert.AreEqual("3.5", driver.FindElement(By.XPath("//input[@value='3.5']")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        [Test]
        public void TheSeleniumTest2Test5()
        {
            driver.Navigate().GoToUrl("http://localhost:52647/Home/Index");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("0");
            driver.FindElement(By.Name("Cal")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Result'])[1]/following::input[1]")).Click();
            try
            {
                Assert.AreEqual("0", driver.FindElement(By.XPath("//input[@value='0']")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
