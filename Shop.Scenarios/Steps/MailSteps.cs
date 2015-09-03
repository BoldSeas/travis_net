using System;
using System.Data;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace Shop.Scenarios.Steps
{
    [Binding]
    public class MailSteps
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

        [When(@"I want to send mail to '(.*)', '(.*)'")]
        public void WhenIWantToSendMailTo(string receiver1, string receiver2, Table table)
        {
            driver.Navigate().GoToUrl("http://localhost:1490/");
            driver.FindElementById("Receiver").SendKeys(String.Format("{0};{1}", receiver1, receiver2));
            driver.FindElementById("Title").SendKeys(table.Rows[0]["title"]);
            driver.FindElementById("Content").SendKeys(table.Rows[0]["content"]);
            driver.FindElementById("send").Click();
        }

        [Then(@"'(.*)' received mail")]
        public void ThenReceivedMail(string receiver)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
