namespace HWSeleniumAdvanced
{
    class AddMyProduct
    {
        private string ProductName;
        private string CategoryId;
        private string SupplierId;
        private string UnitPrice;
        private string QuantityPerUnit;
        private string UnitsInStock;
        private string UnitsInOrder;
        private string ReorderLevel;

        public AddMyProduct()
        {
        }
        public string getProductName()
        {
            return ProductName;
        }
        public string getCategoryId()
        {
            return CategoryId;
        }
        public string getSupplierId()
        {
            return SupplierId;
        }
        public string getUnitPrice()
        {
            return UnitPrice;
        }
        public string getQuantityPerUnit()
        {
            return QuantityPerUnit;
        }
        public string getUnitsInStock()
        {
            return UnitsInStock;
        }
        public string getUnitsInOrder()
        {
            return UnitsInOrder;
        }
        public string getReorderLevel()
        {
            return ReorderLevel;
        }
        public AddMyProduct WithProductName(string ProductName)
        {   
            this.ProductName = ProductName;
            return this;
        }
        public AddMyProduct WithCategoryId(string CategoryId)
        {
            this.CategoryId = CategoryId;
            return this;
        }
        public AddMyProduct WithSupplierId(string SupplierId)
        {
            this.SupplierId = SupplierId;
            return this;
        }
        public AddMyProduct WithUnitPrice(string UnitPrice)
        {
            this.UnitPrice = UnitPrice;
            return this;
        }
        public AddMyProduct WithQuantityPerUnit(string QuantityPerUnit)
        {
            this.QuantityPerUnit = QuantityPerUnit;
            return this;
        }
        public AddMyProduct WithUnitsInStock(string UnitsInStock)
        {
            this.UnitsInStock = UnitsInStock;
            return this;
        }
        public AddMyProduct WithUnitsInOrder(string UnitsInOrder)
        {
            this.UnitsInOrder = UnitsInOrder;
            return this;
        }
        public AddMyProduct WithReorderLevel(string ReorderLevel)
        {
            this.ReorderLevel = ReorderLevel;
            return this;
        }
    }
}
