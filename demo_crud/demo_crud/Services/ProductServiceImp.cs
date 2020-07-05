using demo_crud.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace demo_crud.Services
{
    public class ProductServiceImp : IProductService
    {
        private ProductEntities db = new ProductEntities();

        
        public bool InsertProduct(string name,  float price, int quantity)
        {

            try
            {
                Product product = new Product();
                product.Name = name;
                product.Price = price;
                product.Quantity = quantity;
                db.Products.Add(product);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool UpdateProduct(int id, string name, float price,int quantity)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(x => x.Id == id);
                if (product == null)
                {
                    return false;
                }
                if (!name.IsEmpty())
                {
                    product.Name =  name;
                }
                if (!price.ToString().IsEmpty() )
                {
                    product.Price = price;
                }
                if (!quantity.ToString().IsEmpty())
                {
                    product.Quantity = quantity;
                }
                db.Products.AddOrUpdate(product);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteProduct(int id)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(x => x.Id == id);
                if (product == null)
                {
                    return false;
                }
                product.Id = id;
                db.Products.Remove(product);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}