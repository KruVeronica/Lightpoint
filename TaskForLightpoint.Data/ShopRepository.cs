using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Data
{
    public class ShopRepository : IShopRepository
    {
        private TaskForLightpointContext _context;
        public ShopRepository(TaskForLightpointContext context)
        {
            _context = context;
        }

        public void CreateShop(Shop shop)
        {
            _context.Add(shop);
            int save = _context.SaveChanges();
        }

        public IEnumerable<Shop> GetAllShops()
        {
            var shops = _context.Shop.ToList();
            return shops;
        }

        public Shop GetShop(Guid id)
        {
            var shop = _context.Shop
                .FirstOrDefault(m => m.Id == id);
            return shop;

        }

        public void DeleteShop(Guid id)
        {
            var shop = _context.Shop.Find(id);
            _context.Shop.Remove(shop);
            _context.SaveChanges();
        }

        public void UpdateShop(Shop shop)
        {
            _context.Update(shop);
            _context.SaveChanges();
        }

        public bool ShopExist(Guid id)
        {
            return _context.Shop.Any(e => e.Id == id);
        }

        public void CreateShopProduct(ShopProduct shopProduct)
        {
            _context.Add(shopProduct);
            _context.SaveChanges();
        }

        public IEnumerable<ShopProduct> GetAllShopsProducts()
        {
            var shopsProducts = _context.ShopProduct.Include(s => s.Product).Include(s => s.Shop);
            return shopsProducts;
        }

        public IEnumerable<ShopProduct> GetProductsByShopId(Guid id)
        {
            var products = _context.ShopProduct.Where(s => s.ShopFK == id).Include(s => s.Product).Include(s => s.Shop);
            return products.ToList();
        }

        public ShopProduct GetShopProduct(Guid id)
        {
            var shopProduct = _context.ShopProduct
                .Include(s => s.Product)
                .Include(s => s.Shop)
                .FirstOrDefault(m => m.ShopFK == id);
            return shopProduct;
        }

        public void DeleteShopProduct(Guid id)
        {
            var shopProduct = _context.ShopProduct.Find(id);
            _context.ShopProduct.Remove(shopProduct);
            _context.SaveChanges();
        }

        public void UpdateShopProduct(ShopProduct shopProduct)
        {
            _context.Update(shopProduct);
            _context.SaveChanges();
        }

        public bool ShopProductExist(Guid id)
        {
            return _context.ShopProduct.Any(e => e.ShopFK == id);
        }
    }
}
