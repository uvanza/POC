using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC
{
    class seleniumSetMethods
    {
        public static void EnterText(string element, string value, PropertyType ElementType)
        {
            if (ElementType == PropertyType.ID)
                PropertyCollections.driver.FindElement(By.Id(element)).SendKeys(value);
            if (ElementType == PropertyType.Name)
                PropertyCollections.driver.FindElement(By.Name(element)).SendKeys(value);
            if (ElementType == PropertyType.XPath)
                PropertyCollections.driver.FindElement(By.XPath(element)).SendKeys(value);
            if (ElementType == PropertyType.CssSelector)
                PropertyCollections.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            if (ElementType == PropertyType.ClassName)
                PropertyCollections.driver.FindElement(By.ClassName(element)).SendKeys(value);

        }

        public static void Click(string element, PropertyType ElementType)
        {
            if (ElementType == PropertyType.ID)
                PropertyCollections.driver.FindElement(By.Id(element)).Click();
            if (ElementType == PropertyType.Name)
                PropertyCollections.driver.FindElement(By.Name(element)).Click();
            if (ElementType == PropertyType.XPath)
                PropertyCollections.driver.FindElement(By.XPath(element)).Click();
            if (ElementType == PropertyType.CssSelector)
                PropertyCollections.driver.FindElement(By.CssSelector(element)).Click();
            if (ElementType == PropertyType.ClassName)
                PropertyCollections.driver.FindElement(By.ClassName(element)).Click();
        }

        public static void DropDown(string element, string value, PropertyType ElementType)
        {
            if (ElementType == PropertyType.ID)
                new SelectElement(PropertyCollections.driver.FindElement(By.Id(element))).SelectByText(value);
            if (ElementType == PropertyType.Name)
                new SelectElement(PropertyCollections.driver.FindElement(By.Name(element))).SelectByText(value);
            if (ElementType == PropertyType.XPath)
                new SelectElement(PropertyCollections.driver.FindElement(By.XPath(element))).SelectByText(value);

        }

    }
}
