using System;
using System.Collections.Generic;
using System.Text;
using TaskForLightpoint.Data;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Services
{
    public class ShopService : IShopService
    {
        private IShopRepository _shopRepository;
        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public void CreateShop(Shop shop)
        {
            _shopRepository.CreateShop(shop);
        }

        public IEnumerable<Shop> GetAllShops()
        {
            var shops = _shopRepository.GetAllShops();
            return shops;
        }

        public Shop GetShop(Guid id)
        {
            var shop = _shopRepository.GetShop(id);
            return shop;
        }

        public void DeleteShop(Guid id)
        {
            _shopRepository.DeleteShop(id);
        }

        public void UpdateShop(Shop shop)
        {
            _shopRepository.UpdateShop(shop);
        }

        public bool ShopExist(Guid id)
        {
            bool ifExist = _shopRepository.ShopExist(id);
            return ifExist;
        }

        public void CreateShopProduct(ShopProduct shopProduct)
        {
            _shopRepository.CreateShopProduct(shopProduct);
        }

        public IEnumerable<ShopProduct> GetAllShopsProducts()
        {
            var shopsProducts = _shopRepository.GetAllShopsProducts();
            return shopsProducts;
        }

        public ShopProduct GetShopProduct(Guid id)
        {
            var shopProduct = _shopRepository.GetShopProduct(id);
            return shopProduct;
        }

        public void DeleteShopProduct(Guid id)
        {
            _shopRepository.DeleteShopProduct(id);
        }

        public void UpdateShopProduct(ShopProduct shopProduct)
        {
            _shopRepository.UpdateShopProduct(shopProduct);
        }

        public bool ShopProductExist(Guid id)
        {
            bool ifExist = _shopRepository.ShopProductExist(id);
            return ifExist;
        }

        public IEnumerable<ShopProduct> GetProductsByShopId(Guid id)
        {
            var products = _shopRepository.GetProductsByShopId(id);
            return products;
        }
    }
}
