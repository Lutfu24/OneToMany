using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            List<Category> categories = _context.Categories.ToList();

            ShopViewModel shopViewModel = new()
            {
                Products = products,
                Categories = categories
            };

            return View(shopViewModel);
        }
    }
}
