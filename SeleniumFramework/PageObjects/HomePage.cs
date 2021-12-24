using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace HWSeleniumAdvanced.PageObjects
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div/a[@href=\"/Product\"]")]
        private IWebElement allProducts;

        [FindsBy(How = How.LinkText, Using = "Logout")]
        private IWebElement logout;

        public AllProductsPage AllProducts()
        {
            IAction actions = new Actions(driver)
            .Click(allProducts);
            actions.Perform();
            return new AllProductsPage(driver);
        }
        public void Logout()
        {
            Actions builder = new Actions(driver);
            builder.Click(logout).Perform();
        }
    }
}
