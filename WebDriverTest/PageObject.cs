using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverTest
{
    public class Main:IDisposable
    {
        private  IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        public IWebElement ExpLink;

        [FindsBy(How = How.XPath, Using = "//div[@id='exploreourbestofferscarousel']//div[@class='carousel-caption']//a")]
        public IWebElement Firstcity;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger btn-lg pt-0 pb-0 pr-20 destination-btn-fix']//")]
        public IWebElement ButtonResult;



        public Main()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
            PageFactory.InitElements(driver, this);
        }

      

        public void Search()
        {
            driver.Navigate().GoToUrl("https://www.turkishairlines.com/");
            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(15));
            ExpLink.Click();
            Firstcity.Click();
            if(ButtonResult != null)
            {
                Assert.AreEqual("Забронировать перелёт", ButtonResult.Text);
            }

        }

        public void Dispose()
        {
            driver.Quit();
            driver = null;
        }
    }
   
}
