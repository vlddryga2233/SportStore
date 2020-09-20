﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
namespace SportStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;

        public OrderController(IOrderRepository rep,Cart crt)
        {
            repository = rep;
            cart = crt;
        }
        public ViewResult Checkout() => View(new Order());

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0) 
            {
                ModelState.AddModelError("", "Sorry,your cart is empty");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}
