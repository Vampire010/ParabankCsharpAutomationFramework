using NUnit.Framework;
using Parabank.Browser_SetUp;
using Parabank.LoginPage_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            lp.EnterUsername("JohnDee123");
            lp.EnterPassword("PswdJohnDee123");
            lp.ClikLoginBtn();
            browserLauncher.driver.Close();
        }
    }
}
