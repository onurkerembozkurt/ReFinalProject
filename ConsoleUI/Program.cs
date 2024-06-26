﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle 

        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            foreach (var item in productManager.GetProductDetails().Data)
            {
                Console.WriteLine($"{item.ProductId} {item.CategoryName} {item.ProductName}  ");
            }
            //Console.WriteLine("");
            //foreach (var item in productManager.GetByUnitPrice(50, 100))
            //{
            //    Console.WriteLine($"{item.ProductId}  {item.CategoryId}  {item.ProductName} {item.UnitPrice} {item.UnitsInStock} ");
            //}
        }
    }
}
