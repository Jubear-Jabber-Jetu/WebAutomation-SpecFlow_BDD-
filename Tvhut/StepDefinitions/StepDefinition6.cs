using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvhut.StepDefinitions
{
    [Binding]
    public class StepDefinition6: BaseTest
    {
     
        [Given(@"Be in the base page")]
        public void GivenBeInTheBasePage()
        {
            NavigateToBaseUrl();
        }

        [When(@"Lets search for (.*)k TV - (.*)")]
        public void WhenLetsSearchForKTV_(int p0, int p1)
        {
            string query = "4K 55";
            IWebElement searchInput2 = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            searchInput2.Clear();
            searchInput2.SendKeys(query);
            searchInput2.SendKeys(Keys.Return);
        }
        [Then(@"Lets check the result")]
        public void ThenLetsCheckTheResult()
        {
            driver.FindElements(By.TagName("*")).All(e => !e.Displayed);

        }


    }
}
