using Tutorial_Shop.Models.Entities;

namespace Tutorial_Shop.Models.ViewModels
{
    public class HomeIndexVm
    {
        /// <summary>
        /// محصولات جدید
        /// </summary>
        public List<Product>? NewProducts { get; set; }

        /// <summary>
        /// پرفروش ترین ها
        /// </summary>
        public List<Product>? Sales { get; set; }

        public List<Banner> Banners { get; set; }
    }
}
