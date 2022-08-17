using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject4
{
    public class Tests
    {

        private IWebDriver driver;
        private readonly By Img = By.XPath($"/html/body/div[2]/c-wiz/div[3]/div[1]/div/div/div/div[1]/div[1]/span/div[1]/div[1]/div[1]/a[1]/div[1]/img");


        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Users\User\source\repos\TestProject4\TestProject4\drivers");
            driver.Navigate().GoToUrl("https://www.google.com/search?q=%D0%BB%D0%B8%D0%BC%D0%BE%D0%BD&rlz=1C1GCEA_enUA926UA926&sxsrf=ALiCzsZ46xKXcV151rIj9qBbxhsLufRtsQ:1660695761049&source=lnms&tbm=isch&sa=X&ved=2ahUKEwirgKvnzcz5AhUqg_0HHSOBDDAQ_AUoAXoECAIQAw&biw=1366&bih=657&dpr=1");
        }
        [Test]
        public void Test1()
        {
            var image = driver.FindElement(Img);

            try

            {
                image.Click();
            }

            catch (ArgumentNullException e) when (image == null) { }
           
        }
        [TearDown]
        public void TearDown()
        {
            

        }
    }
}