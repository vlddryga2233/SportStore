using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SportStore.Models;
using SportStore.Models.ViewModel;
using SportStore.Infrastructure;

namespace SportStore.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Cart cart;

        public CartController(IProductRepository product,Cart cart)
        {
            repository = product;
            this.cart = cart;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            }) ;
        }

        public RedirectToActionResult AddToCart(int Id,string returnUrl)
        {
            Product product = repository.Products   
                .FirstOrDefault(p => p.Id == Id);

            if (product !=null)
            {
                cart.AddItem(product, 1);               
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);
            if (product!=null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }      
    }
}
