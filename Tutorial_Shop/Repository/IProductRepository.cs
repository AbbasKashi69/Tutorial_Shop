using Tutorial_Shop.Models.Entities;
using Tutorial_Shop.Models.ViewModels;

namespace Tutorial_Shop.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();

        Task<Product?> GetById(int id);

        Task<bool> Create(Product product);
        Task<bool> Edit(Product product);
        Task<bool> Delete(int id);

        Task<HomeIndexVm?> GetHomeIndexData();
    }
}
