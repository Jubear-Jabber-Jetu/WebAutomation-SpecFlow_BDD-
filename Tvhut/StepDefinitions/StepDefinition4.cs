using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V115.WebAuthn;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Tvhut.StepDefinitions;

namespace YourNamespace
{
    [Binding]
    public class RegisterAccountSteps : BaseTest
    {
        private WebDriverWait wait;

    //    public object ExpectedConditions { get; private set; }

        [Given(@"User is on the registration page")]
        public void GivenUserIsOnTheRegistrationPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/register");
        }

        [When(@"User fills in the registration form with valid information")]
        public void WhenUserFillsInTheRegistrationFormWithValidInformation()
        {
            driver.FindElement(By.Id("input-firstname")).SendKeys("John");
            driver.FindElement(By.Id("input-lastname")).SendKeys("Doe");
            driver.FindElement(By.Id("input-email")).SendKeys("johndoe@example.com");
            driver.FindElement(By.Id("input-telephone")).SendKeys("1234567890");
            driver.FindElement(By.Id("input-password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("input-confirm")).SendKeys("P@ssw0rd");
        }
    

        [When(@"User agrees to the Privacy Policy")]
        public void WhenUserAgreesToThePrivacyPolicy()
        {
            driver.FindElement(By.Name("agree")).Click();
        }

        [Then(@"User submits the registration form")]
        public void ThenUserSubmitsTheRegistrationForm()
        {
             driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }


    }
}
