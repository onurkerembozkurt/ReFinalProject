using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        /*Bu nesneyi bütün
         * metotların dışında tanımladığım
         * için bu tür tanımladığımız değsikene
         * global degisken deniyor o yüzden _ 
         * tanımlarız
         * buna aynı zamanda referans tip
         * ve naming convention diyoruz
         */
        public InMemoryProductDal()
        {
            //Oracle,Sql Server,Postegres,MongoDb
            _products = new List<Product>() {
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
            new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           
            /*
             * Senin arayüzden
             * gönderdiğin product ın 
             * bilgilerin aynı olması 
             * önemli değil
             * yani bilgi dediğim
             * product id nin bir olması gibi
             * veya ürününün isminin bilgisayar olması 
             * gibi
             * arayüzdeki class la 
             * list in içindeki class aynı degil
             * yani heap te 5 tane adres 
             * var
             * bilgiler aynı olsa ne olur olmasa ne olur
             * aynı referans numarasına sahip değilse
             * hiçbir önemi yok
             * arayüzden bir tane ürün newleyip gönderdiğinde
             * mesala metotun imzasına yazdığın
             * ürünün sallıyorum 200 yani aynı değiller
             * string ve int veya bool olsa silerdi çünkğ
             * değer tip ile çalışıyor
             * biz ürünleri silerken primary key i kullanırız
             * Karşımıza güzel bi sistem çıkıyor Linq
             * 
             */
            //Product productToDelete=null;
            //foreach (var p in _products)
            //{
            //    if (p.ProductId==product.ProductId)
            //    {
            //        productToDelete = p;

            //    }
            //}
            //_products.Remove(productToDelete);

            //Linq ne işe yarıyor kısmına gelirsek

            //Language Integrated Query
            //=> lambda deniyor
            //Single Or Default Foreach yap demek

           Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where kosulu icindeki sarta uyan tum elemanları
            //yenı lıste halıne getırıp onu dondurur

            return _products.Where(p => categoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;
            

        }
        //Bizim için çok güzel yapan
        // Gerçek hayat projelerinde entity framework
        //nhybirnate  depper gibi projeleri kullanırız

    }
}
