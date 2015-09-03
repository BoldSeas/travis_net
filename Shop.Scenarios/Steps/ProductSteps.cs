using System;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace Shop.Scenarios.Steps
{
    [Binding]
    public class ProductSteps
    {
        private InternetExplorerDriver driver;

        [BeforeScenario]
        public void Setup()
        {
            driver = new InternetExplorerDriver();
        }

        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();
        }

        [When(@"I add a product '(.*)'")]
        public void WhenIAddAProduct(string name)
        {
            driver.Navigate().GoToUrl("http://localhost:1490/products/create");
            driver.FindElementById("Name").SendKeys(name);
            driver.FindElementById("save").Click();
        }

        [Then(@"I should see '(.*)' in product list")]
        public void ThenIShouldSeeInProductList(string name)
        {
            Assert.IsNotNull(driver.FindElementByLinkText(name));
        }
    }
}
