﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("SalesData")
        { }
        public DbSet<Model.Customer> Customers { get; set; }
        public DbSet<Model.Order> Orders { get; set; }
    }
}
