using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_TUTA_project.Custom
{

    public class ExplicitWait : Base
    {
        public static void ClickWhenReady(IWebElement element)
        {
             var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             wait.Until(ExpectedConditions.ElementToBeClickable(element));
             element.Click();
        }
    }
}
