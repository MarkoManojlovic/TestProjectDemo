

using OpenQA.Selenium;
using WebDriver = TestProjectDemo.Driver.WebDriver;

namespace TestProjectDemo.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDriver.Instance;
        public IWebElement FullName => driver.FindElement(By.Id("name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));

        public void LoginOnPage(string name, string pass)
        {
            FullName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Click();
        }
    }
}
