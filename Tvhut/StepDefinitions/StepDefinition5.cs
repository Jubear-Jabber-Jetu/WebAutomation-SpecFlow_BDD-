using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvhut.StepDefinitions
{
    [Binding]
    public class StepDefinition5 : BaseTest
    {
        [Given(@"I am on the tvhut\.com webpage")]
        public void GivenIAmOnTheTvhut_ComWebpage()
        {
            NavigateToBaseUrl();
        }

        [When(@"I search for laptop")]
        public void WhenISearchForLaptop()
        {

            string router = "router";
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            searchInput.Clear();
            searchInput.SendKeys(router);
            searchInput.SendKeys(Keys.Return);
        }
    }
}
