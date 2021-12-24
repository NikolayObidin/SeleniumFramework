using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSeleniumAdvanced
{
    class Generator
    {
        public static AddMyProduct Generate()
        {
            return new AddMyProduct()
                .WithProductName("Borovichok Mushroom")
                .WithCategoryId("Produce")
                .WithSupplierId("Grandma Kelly's Homestead")
                .WithUnitPrice("4")
                .WithQuantityPerUnit("10 boxes x 20 bags")
                .WithUnitsInStock("2")
                .WithUnitsInOrder("2")
                .WithReorderLevel("2");
        }
    }
}
