using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC
{
    class EAPageObject
    {
        [FindsBy()]
        public IWebElement TitleID { get; set; }
    }
}
