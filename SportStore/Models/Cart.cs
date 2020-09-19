using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Cart
    {
        private List<CartLine> cartLines = new List<CartLine>();

        public virtual void AddItem(Product product,int quantity)
        {
            CartLine line = cartLines
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();
            if (line == null)
            {
                cartLines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product)
        {
            cartLines.RemoveAll(l => l.Product.Id == product.Id);
        }

        public virtual decimal ComputeTotalValue() =>
            cartLines.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => cartLines.Clear();

        public virtual IEnumerable<CartLine> Lines => cartLines;
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
