using Business.Concrete;
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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine($"{item.ProductId}  {item.CategoryId}  {item.ProductName} {item.UnitPrice} {item.UnitsInStock} ");
            }
            Console.WriteLine("");
            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine($"{item.ProductId}  {item.CategoryId}  {item.ProductName} {item.UnitPrice} {item.UnitsInStock} ");
            }
        }
    }
}
