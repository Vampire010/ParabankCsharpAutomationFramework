using OpenQA.Selenium;
using Parabank.TestDataAccess;
using SeleniumExtras.PageObjects;
using System;

namespace Parabank.LoginPage_Objects
{
    public class LoginPage
    {
         string entrUserName;
         string entrPassword;

        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//*[@id='loginPanel']/form/div[1]/input")]
        [CacheLookup]
        private IWebElement UserName{ get;set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='loginPanel']/form/div[2]/input")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='loginPanel']/form/div[3]/input")]
        [CacheLookup]
        private IWebElement LogInButton { get; set; }

        //PageFactory
        public LoginPage(IWebDriver driver)
        { 
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        public void EnterUsername()
        {
            UserName.SendKeys(entrUserName);
        }
        public void EnterPassword()
        {
            Password.SendKeys(entrPassword);
        }
        public void ClikLoginBtn()
        {
            LogInButton.Click();
        }
      
        public void userdata()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\giris\source\repos\ParabankCsharpAutomationFramework\Parabank\TestDataAccess\TestData.xlsx");

            for (int i = 1; i < 2; i++)
            {
                this.entrUserName = ExcelOperations.ReadData(i, "Username");
                Console.WriteLine("Username: " + entrUserName);

                this.entrPassword = ExcelOperations.ReadData(i, "Password");
                Console.WriteLine("Password: " + entrPassword);
            }

        }

      
    }
}
