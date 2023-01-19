using First_TUTA_project.Custom;
using First_TUTA_project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace First_TUTA_project
{
    [Ignore("ignore this suite test")]
    public class Tests : Hooks
    {

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            driver.Navigate().GoToUrl("https://www.google.lt/");
            driver.Navigate().Back();//Clicks back to previous page
            var Button = driver.FindElement(By.Id("idExample"));
            Button.Click();
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");

            var Button2 = driver.FindElement(By.ClassName("buttonClass"));
            Button2.Click();
        }
      
    }

        public class LoginForm : Hooks
        {

            [Ignore("ignore this test")]
            [TestCase("webdriver", "webdriver123")]
            [TestCase("webdriver2", "webdriver123")]
            public void Test1(string Name, string Password)
            {
                driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/Login-Portal/index.html?");
                var username = driver.FindElement(By.Id("text"));
                var password = driver.FindElement(By.Id("password"));
                var button = driver.FindElement(By.Id("login-button"));
                username.SendKeys(Name);
                password.SendKeys(Password);
                button.Click();

                var alertText = driver.SwitchTo().Alert();
                Console.WriteLine(alertText.Text);

                Assert.That(alertText.Text, Is.EqualTo("validation succedded"));
                driver.SwitchTo().Alert().Accept();
            }

            [Test]
            [Ignore("ignore this test")]
            public void Contact_Form()
            {
                driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/Contact-Us/contactus.html");
                var firstname = driver.FindElement(By.Name("first_name"));
                var lastname = driver.FindElement(By.Name("last_name"));
                var email = driver.FindElement(By.XPath("(//input[@class='feedback-input'])[3]"));
                var comments = driver.FindElement(By.XPath("//textarea[@class='feedback-input']"));
                var submit = driver.FindElement(By.XPath("(//input[@class='contact_button'])[2]"));

                firstname.SendKeys("Dovydas");
                lastname.SendKeys("Tamulis");
                email.SendKeys("dovydastt@gmail.com");
                comments.SendKeys("Tamulis");
                submit.Click();
            }

            [Test]
            [Ignore("ignore this test")]
            public void LoaderTest()
            {
                driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/Ajax-Loader/index.html");
                var button = driver.FindElement(By.Id("button1"));
                
                // Implicit Example
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 

                // Explicit Example
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("button1"))).Click();

                // Explicit Example - reusable method for button click 
                //Uncomment line 115 - it represents same action as lines 109-110

                //ExplicitWait.ClickWhenReady(button);
            }
        }
      
        public class PageObjectExample:Hooks
        {
            [Test]
            public void Contact_Page()
            {
                ContactFormPage ContactPage = new ContactFormPage();
                ContactPage.Contact_Form("Dovydas", "Tamulis", "dovydastt@gmail.com", "komentaras");
            }
        }
 }


   
