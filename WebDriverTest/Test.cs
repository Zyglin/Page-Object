using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverTest
{
    [TestFixture]
    public class TestClass
    {

        private IWebDriver driver;
        const string url = "https://www.turkishairlines.com/";

        [Test]
        public void Test_spechialoffer()
        {
            driver.Navigate().GoToUrl(url);
            PageHome pageHome = new FindElements();
            PageFactory.InitElements(driver, pageHome);
            pageHome.ExpLink.Click();
            pageHome.FirstCity.Click();           
                Assert.IsNotNull(pageHome.ButtonResult, "Here is no any data about flight");
                Assert.AreEqual("Забронировать перелёт", pageHome.ButtonResult.Text, "flight status is incorrect")
          
        }
    }
}
