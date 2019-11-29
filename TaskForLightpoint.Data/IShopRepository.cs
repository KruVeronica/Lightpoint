using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Data
{
    public interface IShopRepository
    {
        void CreateShop(Shop shop);
        IEnumerable<Shop> GetAllShops();
        Shop GetShop(Guid id);
        void DeleteShop(Guid id);
        void UpdateShop(Shop shop);
        bool ShopExist(Guid id);

        void CreateShopProduct(ShopProduct shopProduct);
        IEnumerable<ShopProduct> GetAllShopsProducts();
        ShopProduct GetShopProduct(Guid id);
        void DeleteShopProduct(Guid id);
        void UpdateShopProduct(ShopProduct shopProduct);
        bool ShopProductExist(Guid id);
        IEnumerable<ShopProduct> GetProductsByShopId (Guid id);
    }
}
