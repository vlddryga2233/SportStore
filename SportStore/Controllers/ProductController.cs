using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModel;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int pagesize = 4;

        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public ViewResult List(int page = 1)
            => View(new ProductListVIewModel
            {
                Products = repository.Products
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * pagesize)
                    .Take(pagesize),
                PageInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pagesize,
                    TotalItems = repository.Products.Count()
                }   
            });
           
    }
}
