using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Repository
{
    public class EfProductRepository : IProductRepository
    {
        public Product Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        //aşağısı interface'siz hali
        // public Product Get()
        // {
        //     var product = new Product() { Id=1, Name="Product 1"};
        //     return product;
        // }

        // public List<Product> GetAll()
        // {
        //     var products = new List<Product>()
        //     {
        //         new Product() { Id=1, Name="Product 1"},
        //         new Product() { Id=2, Name="Product 2"},
        //         new Product() { Id=3, Name="Product 3"},
        //         new Product() { Id=4, Name="Product 4"}
        //     };

        //     return products;
        // }
    }
}