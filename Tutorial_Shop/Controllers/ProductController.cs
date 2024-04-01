using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_Shop.Models;
using Tutorial_Shop.Repository;

namespace Tutorial_Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetById(id);
            if (product is null)
                return NoContent();

            return View(product);
        }

        //private readonly ApplicationDbContext _db;

        //public ProductController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Details(int id)
        //{
        //    var product = await _db.Products.SingleOrDefaultAsync(s => s.Id == id);
        //    if (product is null)
        //        return NoContent();

        //    return View(product);
        //}
    }
}
