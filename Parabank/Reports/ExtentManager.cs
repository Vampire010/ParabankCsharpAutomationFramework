using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
namespace Parabank.Reports
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string reportpath = "C:/Users/giris/source/repos/ParabankCsharpAutomationFramework/Parabank/Reports/indexTest.html";
                htmlReporter = new ExtentHtmlReporter(reportpath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);

                //Additional Information
                extent.AddSystemInfo("OS","WINDOWS 10");
                extent.AddSystemInfo("HOST NAME" , "GIRISH");
                extent.AddSystemInfo("ENV","ALPHA");
                extent.AddSystemInfo("USERNAME" , "GIRISH RATHODE");


                string extentconfigpath = "C:/Users/giris/source/repos/ParabankCsharpAutomationFramework/Parabank/Reports/MyOwnReport.html";
                htmlReporter.LoadConfig(extentconfigpath);
            }
            return extent;
        }
     }
}
