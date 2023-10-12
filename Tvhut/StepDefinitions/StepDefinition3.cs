using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tvhut.StepDefinitions
{
    [Binding]
    internal class StepDefinition3 : BaseTest
    {
        [Given(@"the user is on the website")]
        public void GivenTheUserIsOnTheWebsite()
        {
            NavigateToBaseUrl();
        }

        [When(@"User clicks on the Offer link")]
        public void WhenUserClicksOnTheLink()
        {
            IWebElement offerlink = driver.FindElement(By.XPath("//s[normalize-space()='Latest Offer']"));
            offerlink.Click();
        }
        [Then(@"the user should see the tabs")]
        public void ThenTheUserShouldSeeTheTabs()
        {
           driver.FindElements(By.TagName("*")).All(e => !e.Displayed);
           driver.Quit();
        }
    }
}
