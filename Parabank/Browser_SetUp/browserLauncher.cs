using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;


namespace Parabank.Browser_SetUp
{
    internal class browserLauncher
    {
        public static IWebDriver driver;

        public static void openBrowser(string BrowserType, string url)
        {
            if (BrowserType.Equals("chrome"))
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                //driver.Manage().Window.Maximize();
            }
            else if (BrowserType.Equals("edge"))
            {
                driver = new EdgeDriver(EdgeDriverService.CreateDefaultService(".", "msedgedriver.exe"));
                driver.Navigate().GoToUrl(url);
                //driver.Manage().Window.Maximize();
            }
            else
            {
                Console.WriteLine("Invalid Browser Type");
            }

        }
    }
}
