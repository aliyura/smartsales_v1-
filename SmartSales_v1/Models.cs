
using System;
﻿using System.Drawing.Printing;

namespace SmartSales_v1
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mobile_number { get; set; }
        public string role { get; set; }
        public DateTime login_date { get; set; }
        public DateTime created_date { get; set; }

    }


    class Stock
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int cost { get; set; }
        public int reorder_level { get; set; }
        public int barqr_code { get; set; }
        public DateTime created_date { get; set; }

    }
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public DateTime created_date { get; set; }
    }
    class Stores
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime created_date { get; set; }

    }
    class Bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created_date { get; set; }
    }
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string altphone_number { get; set; }
        public string credit_limit { get; set; }
        public string customer_group { get; set; }
        public DateTime created_date { get; set; }
    }
}
