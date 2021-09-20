/* Project = CrossBrowser Testing
 * created by = SIVA RANJANI
 * created on = 19/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace cross_browser_testing
{
        [TestFixture]
        [Parallelizable]
        public class BasicTest : Base.BaseClass
        {

            public static IEnumerable<string> BrowserToRunWith()
            {
                string[] browser = { "chrome", "firefox" };
                foreach (string b in browser)
                {
                    yield return b;
                }
            }
            [Test]
            [TestCaseSource("BrowserToRunWith")]
            public static void Login_To_Facebook(string browsername)
            {
                BrowserTest(browsername);
                driver.Url = "https://www.facebook.com/";
            // entering the credentials 
                IWebElement email = driver.FindElement(By.Name("email"));
                email.SendKeys("8667361462");
                System.Threading.Thread.Sleep(1000);

                IWebElement password = driver.FindElement(By.Id("pass"));
                password.SendKeys("siva123");
                System.Threading.Thread.Sleep(1000);
            //click on the login button 
                IWebElement login = driver.FindElement(By.Name("login"));
                login.Click();
                System.Threading.Thread.Sleep(6000);
            }
        }
    
}
