﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please enter a price")]
        [Range(0.01,double.MaxValue,ErrorMessage ="Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please specify a category")]
        public string Category { get; set; }
    }
}
