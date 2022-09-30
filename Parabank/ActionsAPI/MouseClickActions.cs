using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Parabank.Browser_SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parabank.ActionsAPI
{
    class MouseClickActions
    {
        public static string testurl = "https://demo.guru99.com/test/drag_drop.html";
        public static string browserType1 = "chrome";
        public static string browserType2 = "edge";

        //[Test]
        public static void loginTestRun2()
        {
            browserLauncher.openBrowser(browserType1, testurl);

            IWebElement src = browserLauncher.driver.FindElement(By.XPath("//*[@id='fourth']/a"));
            IWebElement dst = browserLauncher.driver.FindElement(By.XPath("//*[@id='amt7']"));


            Actions act = new Actions(browserLauncher.driver);

            act.DragAndDrop(src,dst).Perform();

        }
    }
}
