using System.Threading.Tasks;
using B2BWebApp.Models;
using B2BWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace B2BWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public async Task<IActionResult> Index()
        {
            var service = new ProductService();

            Products response = await service.GetAllProductsAsync();

            return View("index", response.ProductList);
        }

        // GET: Products
        public async Task<IActionResult> GetByCategory(string type)
        {
            var service = new ProductService();

            Products response = await service.GetAllProductsAsync();

            List<Product> filtered = response.ProductList.FindAll(p => p.Tags == type);

            return View("index", filtered);
        }
    }
}