using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace HWSeleniumAdvanced.PageObjects
{
    class AllProductsPage : AbstractPage
    {
        [FindsBy(How = How.LinkText, Using = "Create new")]
        private IWebElement createNew;

        [FindsBy(How = How.XPath, Using = "//a[contains (text(), 'Bor')]")]
        private IWebElement myProduct;

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(), 'Rem')])[last()]")]
        private IWebElement delete;

        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public BusinessLogic NewProduct()
        {
            IAction actions = new Actions(driver)
            .Click(createNew);
            actions.Perform();
            return new BusinessLogic(driver);
        }

        public CheckProductPage CheckProduct()
        {
            IAction actions = new Actions(driver).Click(myProduct);
            actions.Perform();
            return new CheckProductPage(driver);
        }

        public void Delete()
        {
            IAction actions = new Actions(driver).Click(delete);
            actions.Perform();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
