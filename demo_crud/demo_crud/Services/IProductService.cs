using demo_crud.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_crud.Services
{
    interface IProductService
    {
        bool InsertProduct(string name, float price, int quantity);

        bool UpdateProduct(int id, string name, float price, int quantity);

        bool DeleteProduct(int id);

        List<Product> GetAll();

        Product GetById(int id);
    }
}
