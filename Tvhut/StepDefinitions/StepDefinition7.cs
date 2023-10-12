using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvhut.StepDefinitions
{
    [Binding]
    public class StepDefinition7: BaseTest
    {



        [Given(@"Have to go to the Base page")]
        public void GivenHaveToGoToTheBasePage()
        {
            NavigateToBaseUrl();
        }

        [When(@"In search bar search for NVDIA geForce RTX (.*) and (.*) GB ram")]
        public void WhenInSearchBarSearchForNVDIAGeForceRTXAndGBRam(int rtxVersion, int ramAmoun)
        {
            string query = $"high-performance gaming laptop with NVIDIA GeForce RTX {3080} and {32}GB RAM";
            IWebElement searchInput3 = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            searchInput3.Clear();
            searchInput3.SendKeys(query);
            searchInput3.SendKeys(Keys.Return);
        }

        [Then(@"See does any product appears or not")]
        public void ThenSeeDoesAnyProductAppearsOrNot()
        {
            driver.FindElements(By.TagName("*")).All(e => !e.Displayed);
            driver.Quit();
        }




    }
}












