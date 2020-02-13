using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC
{

    enum PropertyType
    {
        ID,
        Name,
        LinkText,
        CssName,
        ClassName,
        CssSelector,
        XPath
    }
    class PropertyCollections
    {
        //auto-implemented property
       

        public static IWebDriver driver { get; set; }

    }
}
