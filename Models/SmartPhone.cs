﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcSmartphone.Models
{
    public class SmartPhone
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
    public class SmartPhoneDBContext : DbContext
    {
        public DbSet<SmartPhone> SmartPhone { get; set; }
    }
}