using Microsoft.EntityFrameworkCore;
using Tutorial_Shop.Models;
using Tutorial_Shop.Models.Entities;
using Tutorial_Shop.Models.ViewModels;

namespace Tutorial_Shop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _db.Products.SingleOrDefaultAsync(s => s.Id == id);
            if (product is null)
                return false; 

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Edit(Product product)
        {
            var oldProduct = await _db.Products.SingleOrDefaultAsync(s=> s.Id == product.Id);
            if(oldProduct is null)
                return false;

            oldProduct.Name = product.Name;
            oldProduct.Description = product.Description;

            await _db.SaveChangesAsync();
            return true;
        }

        public IQueryable<Product> GetAll()
        {
            return _db.Products.AsQueryable();
        }

        public Task<Product?> GetById(int id)
        {
            return _db.Products.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<HomeIndexVm?> GetHomeIndexData()
        {
            HomeIndexVm homeIndexVm = new HomeIndexVm();
            homeIndexVm.NewProducts = await _db.Products.ToListAsync();
            homeIndexVm.Sales = await _db.Products.ToListAsync();
            homeIndexVm.Banners = await _db.Banners.ToListAsync();

            return homeIndexVm;
        }
    }
}
