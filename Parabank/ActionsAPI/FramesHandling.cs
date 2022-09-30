using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Parabank.Browser_SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parabank.ActionsAPI
{
    public class FramesHandling
    {
        public static string testurl = @"C:\Users\giris\source\repos\ParabankCsharpAutomationFramework\Parabank\Frames_Html\SCENARIO_1.html";
        public static string browserType1 = "chrome";
        public static string browserType2 = "edge";

        [Test]
        public static void loginTestRun2()
        {
            browserLauncher.openBrowser(browserType1, testurl);

            //Switch to Frame 1
            browserLauncher.driver.SwitchTo().Frame(0);
            browserLauncher.driver.FindElement(By.Id("Fname1")).SendKeys("Smith");

            //Switch to Main Frame  
            browserLauncher.driver.SwitchTo().DefaultContent();
            IWebElement IFrame2 = browserLauncher.driver.FindElement(By.XPath("//*[@id='Frame2']"));
            browserLauncher.driver.SwitchTo().Frame(IFrame2);
            browserLauncher.driver.FindElement(By.Id("Fname2")).SendKeys("John");

            //Switch to  Frame 3 *--
            browserLauncher.driver.SwitchTo().DefaultContent();
            browserLauncher.driver.SwitchTo().Frame("Frame3");
            browserLauncher.driver.FindElement(By.Id("Fname3")).SendKeys("Ken");

          

        }
    }
}
