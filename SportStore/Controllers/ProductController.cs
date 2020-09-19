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

        public ViewResult List(string category,int page = 1)
            => View(new ProductListVIewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category==category)
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * pagesize)
                    .Take(pagesize),
                PageInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pagesize,
                    TotalItems = category ==null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory=category
                
            });
           
    }
}
