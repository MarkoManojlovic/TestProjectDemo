using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = TestProjectDemo.Driver.WebDriver;

namespace TestProjectDemo.Page
{
    public class Example
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement PhoneNumber => driver.FindElement(By.Id("phone"));
        public IWebElement SaveButton => driver.FindElement(By.Id("save"));
        



        public void Country(string option)
        {
            SelectElement drop = new SelectElement(driver.FindElement(By.Id("country")));
            drop.SelectByText(option);
        }
    }
}
