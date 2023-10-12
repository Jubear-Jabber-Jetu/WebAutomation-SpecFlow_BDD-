using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Tvhut.StepDefinitions
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string baseUrl;
      
        public void SetBaseUrl(string url)
        {
            baseUrl = url;
        }

        public void NavigateToBaseUrl()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/account");
        }
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
