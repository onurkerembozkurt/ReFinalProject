using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="We have repair for our system";
        public static string ProductsListed = "All products are listed";
        public static string ProductCountOfCategoryError = "There can be 10 category for each product";
        public static string ProductNameAlreadyExists = "There is already same name with that product";
        public static string CategoryLimitExceded = "There is no possible to add product about over limit of category";
    
    
    }
}
