using NUnit.Framework;
using OpenQA.Selenium;
using Parabank.Browser_SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parabank.ActionsAPI
{
    public class ScrollwheelActions
    {
        public static string testurl = "https://www.amazon.in/ref=nav_logo";
        public static string browserType1 = "chrome";

       // [Test]
        public static void loginTestRun2()
        {
            browserLauncher.openBrowser(browserType1, testurl);
            ((IJavaScriptExecutor)browserLauncher.driver).ExecuteScript("window.scrollTo(0,800)");
            Thread.Sleep(4000);
            ((IJavaScriptExecutor)browserLauncher.driver).ExecuteScript("window.scrollTo(800,0)");

        }
    }
}
