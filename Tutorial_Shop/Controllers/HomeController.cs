using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_Shop.Models;
using Tutorial_Shop.Models.ViewModels;
using Tutorial_Shop.Repository;

namespace Tutorial_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var homeIndexVm = await _productRepository.GetHomeIndexData();
            return View(homeIndexVm);
        }

        //private readonly ApplicationDbContext _db;

        //public HomeController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    HomeIndexVm homeIndexVm = new HomeIndexVm();
        //    homeIndexVm.NewProducts = await _db.Products.ToListAsync();
        //    homeIndexVm.Sales = await _db.Products.ToListAsync();
        //    homeIndexVm.Banners = await _db.Banners.ToListAsync();

        //    return View(homeIndexVm);
        //}


    }
}
