using log4net;
using log4net.Repository;
using NLog.Fluent;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Base
{
    public class BaseClass
    {
        //creating object for the webdriver 
        public static IWebDriver driver;

        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));
        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
        
        [SetUp]
        public void SetUp()
        {
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);

            try
            {
                //Upcasting 
                driver = new ChromeDriver();
                //To maximize the window
                driver.Manage().Window.Maximize();

                driver.Url = "https://www.bookswagon.com/";
                log.Debug("navigating to url");

                log.Info("Exiting setup");
            }
            catch (Exception ex)
            {

                throw new CustomException(CustomException.ExceptionType.NoSuchElement, "No such element found");
            }
        
        }
        [TearDown]
        public void teardown()
        {
            //To close all the tabs 
            driver.Quit();
        }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\Book_Swagon\Book_Swagon\BS_Screenshot\payment.png");
        }
    }
}
