﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class LipsumHomePage
    {
        public const string URL = "https://lipsum.com";
        public const string InputBytes = "141";

        public LipsumHomePage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"bytes\"]")]
        internal IWebElement BytesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"amount\"]")]
        internal IWebElement AmountField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"generate\"]")]
        internal IWebElement GenerateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"lipsum\"]")]
        internal IWebElement GeneratedIpsum { get; set; }
    }
}
