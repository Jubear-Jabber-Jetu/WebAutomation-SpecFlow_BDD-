using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace Tvhut.StepDefinitions
{
    [Binding]
    public class StepDefinition2 : BaseTest
    {
        [Given(@"Go to the TV HUT webpage")]
        public void GivenGoToTheTVHUTWebpage()
        {
            NavigateToBaseUrl();
        }

        [When(@"I list all available Home Appliance")]
        public void WhenIListAllAvailableHomeAppliance()
        {

            IWebElement homeApplianceLink = driver.FindElement(By.XPath("//span[@class='links-text'][normalize-space()='Home Appliance']"));
            homeApplianceLink.Click();
        }

        [Then(@"I select one of them")]
        public void ThenISelectOneOfThem()
        {

            IReadOnlyCollection<IWebElement> refineItems = driver.FindElements(By.CssSelector(".refine-item"));

            if (refineItems.Count > 0)
            {
                int randomIndex = new Random().Next(0, refineItems.Count);
                IWebElement randomBlock = refineItems.ElementAt(randomIndex);
                randomBlock.Click();
            }
            else
            {

            }
        }

    }
}
