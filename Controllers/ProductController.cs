using CoffeShopListLab_Solution.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShopListLab_Solution.Controllers
{
    public class ProductController : Controller
    {

        private CoffeeStockDbContext _stockDbContext = new CoffeeStockDbContext();

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ProductList() {
            List<Product> products = _stockDbContext.Products.ToList();
            return View(products);
        }

        public IActionResult Return() {
        
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public IActionResult Description(int coffeeId)
        {
            Product product = _stockDbContext.Products.FirstOrDefault(coffee => coffee.Id == coffeeId);
            return View(product);
        }
    }
}
