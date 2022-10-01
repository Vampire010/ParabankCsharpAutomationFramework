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
[assembly:Parallelizable(ParallelScope.Fixtures)]
namespace Parabank.Multi_Parllell_Scroll_Frames
{
    [TestFixture("chrome")]
    [TestFixture("edge")]
   // [Parallelizable]
    public class ScrollWheelActions
    {
        public static string testurl = "https://www.google.com/";
        public string _browser;


        public ScrollWheelActions(string brwosertype)
        {
            browserLauncher.openBrowser(brwosertype, testurl);
        }

       // [SetUp]
        public void openbrowser()
        {
            browserLauncher.openBrowser(_browser, testurl);
        }
            
        [Test]
        [Parallelizable]
        public  void loginTestRun2()
        {

            IWebElement searchBox =  browserLauncher.driver.FindElement(By.Name("q"));
           searchBox.SendKeys("Selenium C#");

            Actions act = new Actions(browserLauncher.driver);
            act.SendKeys(Keys.Down).Perform();
            act.SendKeys(Keys.Down).Perform();
            act.SendKeys(Keys.Enter).Perform();

        }

       
    }
}
