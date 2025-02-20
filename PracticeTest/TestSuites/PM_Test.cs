using OpenQA.Selenium;

namespace PracticeTest.TestSuites
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
        }
    }
}