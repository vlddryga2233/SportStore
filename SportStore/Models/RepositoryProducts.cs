using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class RepositoryProducts : IProductRepository
    {
        private ProductContext context;
        public RepositoryProducts(ProductContext productContext)
        {
            context = productContext;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
