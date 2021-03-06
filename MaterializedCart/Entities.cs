﻿using System;
using Newtonsoft.Json;
using Microsoft.Azure.Documents;
using System.Collections.Generic;

namespace CartView
{
    public class Cart
    {
        public string CartId;
        public double TotalAmount;
        public List<Item> Items = new List<Item>();

        public Cart(string id)
        {
            this.CartId = id;
        }
    }

    public class Item
    {
        public string Id { get; set; }
        public double Price { get; set; }
        public string ETag { get; set; }
    }
}
