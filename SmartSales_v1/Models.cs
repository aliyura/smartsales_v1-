using System.Drawing.Printing;

namespace SmartSales_v1
{
    class User
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mobile_number { get; set; }
        public string role { get; set; }

    }

    class Product
    {
        public string product_Name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int cost { get; set; }
        public int reorder_Level { get; set; }
    }
    class Stock
    {
        public string stock_Name { get; set; }
        public string location { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }

    }
    class Bank
    {
        public string bank_name { get; set; }
    }
    class Customer
    {
        public string customer_name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string altphone_number { get; set; }
        public string credit_limit { get; set; }
        public string customer_group { get; set; }
    }
}
