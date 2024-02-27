﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //İş Kodları
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
/*
 * Senın iş kodlarının tamamı new leyerek 
 * yaparsan hep memory ile çalışır
 * kural neydi bir iş sınıfı
 * başka sınıfları newlemez
 * ne yapardı bunun için
 * InmemoryproductDal diyip injection yapıyorduk
 * 
 * 
 */