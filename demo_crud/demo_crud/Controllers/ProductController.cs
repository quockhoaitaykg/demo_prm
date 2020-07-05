using demo_crud.Models;
using demo_crud.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo_crud.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService service;

        public ProductController()
        {
            service = new ProductServiceImp();
        }

        [HttpPost]
        public bool InsertProduct(string name, float price, int quantity)
        {
            return service.InsertProduct(name, price, quantity);
        }
        [HttpPut]
        public bool UpdateProduct(int id, string name, float price, int quantity)
        {
            return service.UpdateProduct(id, name, price, quantity);
        }

        [HttpDelete]
        public bool DeleteProduct(int id)
        {
            return service.DeleteProduct(id);
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet]
        public Product GetById(int id)
        {
            return service.GetById(id);
        }
    }
}