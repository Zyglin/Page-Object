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
    public class PageHome 
    {

        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        private IWebElement expLink;

        [FindsBy(How = How.XPath, Using = "//div[@id='exploreourbestofferscarousel']//div[@class='carousel-caption']//a")]
        public IWebElement firstcity;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger btn-lg pt-0 pb-0 pr-20 destination-btn-fix']//")]
        public IWebElement buttonResult;


        public IWebElement ExpLink { get { return expLink; } }
        public IWebElement FirstCity { get { return firstcity; } }
        public IWebElement ButtonResult { get { return buttonResult; } }
    }

}
