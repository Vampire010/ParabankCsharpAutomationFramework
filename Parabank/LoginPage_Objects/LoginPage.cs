using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Parabank.LoginPage_Objects
{
    public class LoginPage
    {
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


        public LoginPage(IWebDriver driver)
        { 
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        public void EnterUsername(string entrUserName)
        {
            UserName.SendKeys(entrUserName);
        }
        public void EnterPassword(string entrPassword)
        {
            Password.SendKeys(entrPassword);
        }
        public void ClikLoginBtn()
        {
            LogInButton.Click();
        }

    }
}
