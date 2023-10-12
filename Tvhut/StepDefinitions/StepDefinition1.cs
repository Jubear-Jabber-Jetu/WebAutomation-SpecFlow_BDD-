using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace Tvhut.StepDefinitions
{
    [Binding]
    public class StepDefinition1 : BaseTest
    {
       

        [Given(@"User is on the website")]
        public void GivenUserIsOnTheWebsite()
        {
            NavigateToBaseUrl();
        }

        [When(@"User clicks on the Account link")]
        public void WhenUserClicksOnTheLink()
        {
            string buttonXpath = "//span/s[text()[normalize-space() = 'Log in/ Register']]";
            IWebElement accountLink = driver.FindElement(By.XPath(buttonXpath));
            accountLink.Click();

        }

        [When(@"User enters the email")]
        public void WhenUserEntersTheEmail()
        {
            string emailXpath = "//iframe[@src='index.php?route=account/login&popup=login']";
            IWebElement email = driver.FindElement(By.XPath(emailXpath)); 
            email.SendKeys("jubearjabberjetu@gmail.com");
        }

        [When(@"User enters the password")]
        public void WhenUserEntersThePassword()
        {
            string passwordXpath = "//iframe[@src='index.php?route=account/login&popup=login']";
            IWebElement password = driver.FindElement(By.XPath(passwordXpath)); 
            password.SendKeys("tP3smr4HUw5jiW2");
        }
        [When(@"User clicks the LOGIN button")]
        public void WhenUserClicksTheButton()
        {
            // Use the buttonName parameter to identify the specific button
            string buttonXpath = "//iframe[@src='index.php?route=account/login&popup=login']";
            IWebElement loginButton = driver.FindElement(By.XPath(buttonXpath));
            loginButton.Click();
        }




    }
}