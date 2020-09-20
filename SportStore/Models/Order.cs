﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage ="Please enter the city name")]
        public string City { get; set; }

        [Required(ErrorMessage ="Please enter the state name")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage ="Please enter the country name")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
