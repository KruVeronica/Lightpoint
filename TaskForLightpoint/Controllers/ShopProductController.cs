using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskForLightpoint.Data;
using TaskForLightpoint.Models;
using TaskForLightpoint.Services;

namespace TaskForLightpoint.Controllers
{
    public class ShopProductController : Controller
    {

        private readonly IShopService _shopService;

        private readonly IProductService _productService;

        public ShopProductController(IShopService shopService, IProductService productService)
        {
            _shopService = shopService;
            _productService = productService;
        }

        // GET: ShopProduct
        public async Task<IActionResult> Index()
        {
            return View(_shopService.GetAllShopsProducts());
        }

        // GET: ShopProduct/Products/5
        public async Task<IActionResult> Products(Guid id)
        {
            ViewBag.Asd = id;
            return View("Index", _shopService.GetProductsByShopId(id));
        }

        // GET: ShopProduct/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopProduct = _shopService.GetShopProduct(id.Value);
            if (shopProduct == null)
            {
                return NotFound();
            }

            return View(shopProduct);
        }

        // GET: ShopProduct/Create
        public IActionResult Create(Guid id)
        {
            ViewData["ProductFK"] = new SelectList(_productService.GetAllProducts().Result, "Id", "Description");
            ViewData["ShopFK"] = new SelectList(_shopService.GetAllShops(), "Id", "Adress", id);
            ViewBag.ShopId = id;
            return View();
        }

        // POST: ShopProduct/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopFK,ProductFK")] ShopProduct shopProduct)
        {
            if (ModelState.IsValid)
            {
                shopProduct.Id = Guid.NewGuid();
                _shopService.CreateShopProduct(shopProduct);
                return RedirectToAction("Products", new { id = shopProduct.ShopFK });
            }
            ViewData["ProductFK"] = new SelectList(_productService.GetAllProducts().Result, "Id", "Description", shopProduct.ProductFK);
            ViewData["ShopFK"] = new SelectList(_shopService.GetAllShops(), "Id", "Adress", shopProduct.ShopFK);
            return View(shopProduct);
            //return RedirectToAction(nameof(Index));
        }

        // GET: ShopProduct/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopProduct = _shopService.GetShopProduct(id.Value);
            if (shopProduct == null)
            {
                return NotFound();
            }
            ViewData["ProductFK"] = new SelectList(_productService.GetAllProducts().Result, "Id", "Description", shopProduct.ProductFK);
            ViewData["ShopFK"] = new SelectList(_shopService.GetAllShops(), "Id", "Adress", shopProduct.ShopFK);
            return View(shopProduct);
        }

        // POST: ShopProduct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ShopFK,ProductFK")] ShopProduct shopProduct)
        {
            if (id != shopProduct.ShopFK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _shopService.UpdateShopProduct(shopProduct);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopProductExists(shopProduct.ShopFK))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductFK"] = new SelectList(_productService.GetAllProducts().Result, "Id", "Description", shopProduct.ProductFK);
            ViewData["ShopFK"] = new SelectList(_shopService.GetAllShops(), "Id", "Adress", shopProduct.ShopFK);
            return View(shopProduct);
        }

        // GET: ShopProduct/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopProduct = _shopService.GetShopProduct(id.Value);
            if (shopProduct == null)
            {
                return NotFound();
            }

            return View(shopProduct);
        }

        // POST: ShopProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _shopService.DeleteShopProduct(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ShopProductExists(Guid id)
        {
            return _shopService.ShopProductExist(id);
        }
    }
}
