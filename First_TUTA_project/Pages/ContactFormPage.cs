using First_TUTA_project.Custom;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace First_TUTA_project.Pages
{
    public class ContactFormPage : Base
    {
        IWebElement firstname => driver.FindElement(By.Name("first_name"));
        IWebElement lastname => driver.FindElement(By.Name("last_name"));
        IWebElement email => driver.FindElement(By.XPath("(//input[@class='feedback-input'])[3]"));
        //IF you want to use css selector - example
        // IWebElement email => driver.FindElement(By.CssSelector(".feedback-input:nth-of-type(3)"));
        IWebElement comments => driver.FindElement(By.XPath("//textarea[@class='feedback-input']"));
        IWebElement submit => driver.FindElement(By.XPath("(//input[@class='contact_button'])[2]"));
        //IF you want to use css selector - example
        // IWebElement email => driver.FindElement(By.CssSelector(".contact_button:nth-of-type(2)"));

        IWebElement successMessage => driver.FindElement(By.CssSelector("h1"));

        public void Contact_Form(string Name, string Lastname, string Email, string Comments)
        {
            driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/Contact-Us/contactus.html");
            firstname.SendKeys(Name);
            lastname.SendKeys(Lastname);
            email.SendKeys(Email);
            comments.SendKeys(Comments);
            submit.Click();
            Console.WriteLine("Submit button is clicked");
            Console.WriteLine(successMessage);

        }
    }
}
