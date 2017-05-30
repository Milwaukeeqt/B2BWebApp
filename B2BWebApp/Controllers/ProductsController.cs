using System.Threading.Tasks;
using B2BWebApp.Models.Product;
using B2BWebApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace B2BWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public async Task<IActionResult> Index()
        {
            var service = new ProductService();

            Products response = await service.GetAllProductsAsync();

            return View("index", response.products);
        }
    }
}