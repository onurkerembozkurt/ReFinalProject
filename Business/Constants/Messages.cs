using Core.Entities.Concrete;
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
        public static string AuthorizationDenied="There is no authorization";

        public static string AccessTokenCreated = "The access token is created";
        public static string UserRegistered = "The user is registered";
        public static string PasswordError = "The password is not match"; 
        public static string UserNotFound = "The user is not found";
        public static string SuccessfulLogin = "Successfully log in ";
        public static string UserAlreadyExists = "The user is already exists";
    }
}
