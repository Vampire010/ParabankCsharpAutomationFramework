using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Parabank.Browser_SetUp;
using System;
using System.Threading;

namespace Parabank.Multi_Parllell_Scroll_Frames
{
    public class MultipleWinHandles
    {
        public static string testurl = "https://www.snapdeal.com/";
        public static string browserType1 = "chrome";
        public static string browserType2 = "edge";

       // [Test]
        public static void loginTestRun2()
        {
            browserLauncher.openBrowser(browserType1, testurl);

            IWebElement menesFashion = browserLauncher.driver.FindElement(By.XPath("//*[@id='leftNavMenuRevamp']/div[1]/div[2]/ul/li[1]/a/span[2]"));


            Actions act = new Actions(browserLauncher.driver);

            act.MoveToElement(menesFashion).Perform();

            IWebElement MensJackets = browserLauncher.driver.FindElement(By.XPath("//*[@id='category1Data']/div[2]/div/div/p[9]/a/span"));
            MensJackets.Click();

           


            //store the ID of Parent Window
            string PrentWinID = browserLauncher.driver.CurrentWindowHandle;
            Console.WriteLine("Prent Window Id: " + PrentWinID);

            //store total number of windows opend
            int Windowsopend = 1;
            Console.WriteLine("total number of windows opend: " + Windowsopend);

            Assert.AreEqual(browserLauncher.driver.WindowHandles.Count, Windowsopend);




            IWebElement Bomber_Jacket = browserLauncher.driver.FindElement(By.XPath("/html/body/div[10]/div[9]/div[2]/div[2]/div[9]/section[1]/div[4]/div[3]/div[1]/a/p"));
            Bomber_Jacket.Click();

            WebDriverWait Wait = new WebDriverWait(browserLauncher.driver,TimeSpan.FromSeconds(10));
            Wait.Until(wd => wd.WindowHandles.Count == 2);


            //Switch to child Window
            browserLauncher.driver.SwitchTo().Window(browserLauncher.driver.WindowHandles[1]);
            //store the ID of Parent Window
            string ChildWinID = browserLauncher.driver.CurrentWindowHandle;
            Console.WriteLine("Child Window Id: " + ChildWinID);

            Thread.Sleep(4000);
            //switch to parent win
            browserLauncher.driver.SwitchTo().Window(browserLauncher.driver.WindowHandles[0]);


            //browserLauncher.driver.Close();
        }
    }
}
