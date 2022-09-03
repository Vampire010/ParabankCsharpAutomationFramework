using NUnit.Framework;
using Parabank.Browser_SetUp;
using Parabank.LoginPage_Objects;

namespace Parabank.TestRunner
{
    public class Logintest
    {
        public static string testurl = "https://parabank.parasoft.com/";
        public static string browserType1 = "chrome";
        public static string browserType2 = "edge";

        [Test]
        public static void loginTestRun2()
        {
            browserLauncher.openBrowser(browserType1, testurl);
            LoginPage lp = new LoginPage(browserLauncher.driver);
            lp.userdata();
           
            /* lp.EnterUsername();
            lp.EnterPassword();
            lp.ClikLoginBtn(); */
            lp.login();

            browserLauncher.driver.Close();
        }
    }
}
