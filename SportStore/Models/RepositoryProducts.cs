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

        public Product DeleteProduct(int id)
        {
            Product dbEntry=
                context.Products.FirstOrDefault(p => p.Id == id);

            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveProduct(Product product)
        {
            if (product.Id == 0) 
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products
                    .FirstOrDefault(p => p.Id == product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Category = product.Category;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                }
            }
            context.SaveChanges();
        }
    }
}
