using NUnit.Framework;
using TestProjectDemo.Driver;
using TestProjectDemo.Page;

namespace TestProjectDemo
{
    public class Tests
    {
        private LoginPage _loginPage;
        private Example _examplePage;


        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _examplePage = new Example();
        }
        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }
       

        [Test]
        public void TC01LOGINONPAGEANDENTERDATA()
        {
            Login("Marko", "12345");
            _examplePage.Country("Serbia");
            _examplePage.Address.SendKeys("Beogradska 115");
            _examplePage.Email.SendKeys("markoman@gmail");
            _examplePage.PhoneNumber.SendKeys("4213131");
            _examplePage.SaveButton.Click();

            Assert.That("Saved", Is.EqualTo(_examplePage.SaveText.Text)); // moze da bude i Displayed
        }
        public void Login(string name, string pass)
        {
        _loginPage.LoginOnPage(name, pass); 
        }
    }
}