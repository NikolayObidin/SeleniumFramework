using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using HWSeleniumAdvanced.PageObjects;

namespace HWSeleniumAdvanced
{
    class BusinessLogic : AbstractPage
    {
        public BusinessLogic(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void CreateMyProduct(AddMyProduct product)
        {
            CreateNewProductPage Page = new CreateNewProductPage(driver);
            Page.CreateProduct(product);
        }

        public void CreateMyProduct() { }
    }
}
