/* Project = CrossBrowser Testing
 * created by = SIVA RANJANI
 * created on = 19/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cross_browser_testing.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;


        public static void BrowserTest(String browserName)
        {

            //check for the browser value and invoke the called browser
            if (browserName.Equals("chrome"))
            {

                driver = new ChromeDriver();
            }
            if (browserName.Equals("firefox"))
            {

                driver = new FirefoxDriver();
            }

            //print which browser is started
            Console.WriteLine(browserName + " Started");
            driver.Manage().Window.Maximize();

        }
        [TearDown]
        public void shutdown()
        {
            driver.Close();
        }
    }
}
