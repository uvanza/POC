using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;


namespace POC
{
    using WebDriver = OpenQA.Selenium.IWebDriver ;
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //IWebDriver driver = new InternetExplorerDriver();
            //IWebDriver driver = new FirefoxDriver();
            WebDriver driver = new FirefoxDriver();
            driver.Url=("https://portal.scm.ca/");


            InternetExplorerOptions options = new InternetExplorerOptions();
            options.EnableNativeEvents = false;
//            IWebDriver driver = new InternetExplorerDriver(options);

            PropertyCollections.driver = new InternetExplorerDriver(options);

            PropertyCollections.driver.Navigate().GoToUrl("https://portal.scm.ca/");
            Console.WriteLine("Open url ");
            //driver.Manage().Window.Size = new System.Drawing.Size(1550, 838);
            //PropertyCollections.driver.FindElement(By.Id("txtUserName")).SendKeys("uvx");
            seleniumSetMethods.EnterText("txtUserName", "uvx", PropertyType.ID);
            //PropertyCollections.driver.FindElement(By.Id("txtPassword")).SendKeys("Prabhu@151");
            seleniumSetMethods.EnterText("txtPassword", "Prabhu@151", PropertyType.ID);
            //driver.FindElement(By.XPath("//fieldset[@class='simple']//table/tbody[1]/tr[4]/td[2]/input[2]")).Click();

            

            // driver.FindElement(By.CssSelector("#ctl00_ctl00_companySelect > img")).Click();
            // driver.FindElement(By.Id("ctl00_ctl00_lvCompanies_ctrl11_lbCompany")).Click();
            seleniumSetMethods.Click("//fieldset[@class='simple']//table/tbody[1]/tr[4]/td[2]/input[2]", PropertyType.XPath);

        }

        
        //[SetUp]
        //public void initialized() {
            
        //    //driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("http://portal.scm.ca");
        //}

        //[Test]
        //public void operation() {
        //    driver.FindElement(By.Id("txtUserName")).SendKeys("uvx");
        //    driver.FindElement(By.Id("txtPassword")).SendKeys("Prabhu@151");

        //    driver.FindElement(By.Id("btnLogin")).Click();
        //}
        //[TearDown]
        //public void cleanu() {
        //    driver.Close();

        //}
    }
}
