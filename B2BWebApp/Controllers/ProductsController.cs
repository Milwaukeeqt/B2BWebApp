using System.Threading.Tasks;
using System;
using B2BWebApp.Models;
using B2BWebApp.Service;
using B2BWebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace B2BWebApp.Controllers
{
    public class ProductsController : Controller
    {
        [Route("/collection")]
        public async Task<IActionResult> Index()
        {
            var service = new ProductService();

            int productsPerPage = 15;
            int productCount = await service.Count();
            int pageCount = (int)Math.Ceiling((double)(productCount / productsPerPage));

            Products response = await service.GetLimitedListAsync(productsPerPage);

            return View("Index", new ProductsViewModel { Products = response, PageCount = pageCount });
        }

        [HttpPost]
        public async Task<IActionResult> GetNextPage(int currentPage)
        {
            var service = new ProductService();

            currentPage++;

            Products response = await service.GetPageAsync(15, currentPage);

            return PartialView("_ProductPagePartial", response.ProductList);
        }

        public async Task<IActionResult> GetByCategory(string type)
        {
            var service = new ProductService();

            Products response = await service.GetAllAsync();

            List<Product> filtered = response.ProductList.FindAll(p => p.Tags.Equals(type));

            return View("Index", filtered);
        }
    }
}