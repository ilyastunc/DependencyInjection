using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index ()
        {
            return View(_productRepository.GetAll());
        }

        public IActionResult Get()
        {
            return View(_productRepository.Get());
        }

        //Böyle yaptığımız zaman HomeController, EfProductRepository sınıfına bağımlı olmuş oluyor. Oldu da ilerde EfProductRepository yerine AdoProductRepository'i kullanmak istersek
        //bu sefer EfProductRepository gördüğümüz her yeri AdoProductRepository olarak değiştirmemiz gerekiyor. Bunun yerine Controller Interface'i bilse sadece bu sefer arka 
        //tarafta yaptığımız değişiklikler onu hiç ilgilendirmez. Çalışmaya devam eder sorunsuz bir şekilde
        
        //dependency injection kullanmadan önceki hali
        // EfProductRepository _productRepository;
        // public HomeController()
        // {
        //     _productRepository = new EfProductRepository();
        // }
        // public IActionResult Index ()
        // {
        //     return View(_productRepository.GetAll());
        // }

        // public IActionResult Get()
        // {
        //     return View(_productRepository.Get());
        // }
    }
}