using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Repository
{
    public interface IProductRepository
    {
        Product Get(); //başında access modifier olmaz. public gibi
        List<Product> GetAll();
    }
}