using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace HWSeleniumAdvanced.PageObjects
{
    class CreateNewProductPage : AbstractPage
    {
        public CreateNewProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id=\"ProductName\"]")]
        private IWebElement productname;

        [FindsBy(How = How.XPath, Using = "//select[@id=\"CategoryId\"]")]
        private IWebElement categoryId;

        [FindsBy(How = How.XPath, Using = "//select[@id=\"SupplierId\"]")]
        private IWebElement supplierId;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"UnitPrice\"]")]
        private IWebElement unitPrice;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"QuantityPerUnit\"]")]
        private IWebElement quantityPerUnit;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"UnitsInStock\"]")]
        private IWebElement unitsInStock;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"UnitsOnOrder\"]")]
        private IWebElement unitsOnOrder;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"ReorderLevel\"]")]
        private IWebElement reorderLevel;

        [FindsBy(How = How.XPath, Using = "//input[@type=\"submit\"]")]
        private IWebElement submitCreate;
        
        public void CreateProduct(AddMyProduct product)
        {
            new SelectElement(categoryId).SelectByText(product.getCategoryId());
            new SelectElement(supplierId).SelectByText(product.getSupplierId());

            IAction actions = new Actions(driver)
            .SendKeys(productname, product.getProductName())
            .SendKeys(unitPrice, product.getUnitPrice())
            .SendKeys(quantityPerUnit, product.getQuantityPerUnit())
            .SendKeys(unitsInStock, product.getUnitsInStock())
            .SendKeys(unitsOnOrder, product.getUnitsInOrder())
            .SendKeys(reorderLevel, product.getReorderLevel())
            .Click(submitCreate);
            actions.Perform();
        }
    }
}
