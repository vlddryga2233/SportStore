using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public class OrderRepository : IOrderRepository
    {
        private ProductContext context;
        public OrderRepository(ProductContext context)
        {
            this.context = context;
        }
        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(p => p.Product);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderId==0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
