using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

using OpenQA.Selenium.Interactions;
using Parabank.Browser_SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Parabank.ActionsAPI
{
    [TestFixture]
    [Parallelizable]
    public class MultiWinHandle
    {
        public static string testurl = "https://www.snapdeal.com/";
        public static string browserType1 = "chrome";
        public static string browserType2 = "edge";
        public string _browser;

        public MultiWinHandle(string browserType)
        { 
               _browser= browserType;

        }

        [SetUp]
        public void openBrowser()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();


        }

        // [Test]
        public static void loginTestRun2()
        {

            IWebElement menesFashion = browserLauncher.driver.FindElement(By.XPath("//*[@id='leftNavMenuRevamp']/div[1]/div[2]/ul/li[1]/a/span[2]"));


            Actions act = new Actions(browserLauncher.driver);

            act.MoveToElement(menesFashion).Perform();

            IWebElement dst = browserLauncher.driver.FindElement(By.XPath("//*[@id='category1Data']/div[2]/div/div/p[9]/a/span"));
            dst.Click();

        }
    }
}
