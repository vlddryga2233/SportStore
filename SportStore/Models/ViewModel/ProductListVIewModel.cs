using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models.ViewModel
{
    public class ProductListVIewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public PageInfo PageInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
