﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_shop_books.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base("E_shop_books")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}