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
        public string productName { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int cost { get; set; }
        public int reorderLevel { get; set; }
    }
    class Stock
    {
        public string stockName { get; set; }
        public string location { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }

    }
}
