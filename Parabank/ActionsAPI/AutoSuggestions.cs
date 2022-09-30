using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Parabank.Browser_SetUp;
using System;
using System.Collections.Generic;

using System.Threading;


namespace Parabank.ActionsAPI
{
    internal class AutoSuggestions
    {
        public static string testurl = "https://www.google.co.in/";
        public static string browserType1 = "chrome";

        [Test]
        public static void loginTestRun2()
        {
            browserLauncher.openBrowser(browserType1, testurl);
           // Thread.Sleep(2000);
            browserLauncher.driver.FindElement(By.Name("q")).SendKeys("Selenium C#");
            IList<IWebElement> autoSuggest = browserLauncher.driver.FindElements(By.TagName("ul"));


            foreach (WebElement a in autoSuggest)
            {
                Console.WriteLine(a);

            }


            // Thread.Sleep(5000);

            Actions act = new Actions(browserLauncher.driver);
            act.SendKeys(Keys.Down).Perform();
            act.SendKeys(Keys.Down).Perform();

            act.SendKeys(Keys.Enter).Perform();

           

        }
    }
}
