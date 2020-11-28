
using System;
using System.Drawing;
using System.Drawing.Printing;

namespace SmartSales_v1
{


    class ComboBoxItem
    {

        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }

    class Range
    {

        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }

    class Log
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int username { get; set; }
        public string description { get; set; }
        public string statement { get; set; }
        public string type { get; set; }
        public DateTime created_date { get; set; }

    }


    class Percentage
    {
        public int percentage { get; set; }
        public int total { get; set; }
        public int left { get; set; }
    }

    class Cart
    {
        public int id { get; set; }
        public int pid { get; set; }
        public int bid { get; set; }
        public int user_id { get; set; }
        public string product_name { get; set; }
        public string location { get; set; }
        public int quantity { get; set; }
        public int unit_price { get; set; }
        public int unit_discount { get; set; }
    }
    class User
    {
        public int id { get; set; }
        public int bid { get; set; }
        public string name { get; set; }

        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mobile_number { get; set; }
        public string role { get; set; }
        public byte[] picture { get; set; }
        public DateTime login_date { get; set; }
        public DateTime created_date { get; set; }

    }


    class Payment
    {
        public int id { get; set; }
        public int cid { get; set; }
        public string customer_name { get; set; }
        public int transaction_amount { get; set; }
        public int cleared_amount { get; set; }
        public string description  { get; set; }
        public string payment_mode { get; set; }
        public string transaction_type { get; set; }
        public DateTime transaction_date { get; set; }
    }

    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int reorder_level { get; set; }
        public string barqr_code { get; set; }
        public DateTime created_date { get; set; }

    }
    class Batch
    {
        public int  id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public int pid { get; set; }
        public int total { get; set; }
        public int balance { get; set; }
        public int sold { get; set; }
        public int cost { get; set; }
        public DateTime created_date { get; set; }

    }
    class Stock
    {
        public int id { get; set; }
        public string name { get; set; }
        public int bid { get; set; }
        public string location { get; set; }
        public int quantity { get; set; }
        public int cost { get; set; }
        public string description { get; set; }
        public DateTime created_date { get; set; }
    }
    class Location
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
        public int credit_limit { get; set; }
        public string customer_group { get; set; }
        public int account_balance { get; set; }
        public DateTime created_date { get; set; }
    }
    class Debtor
    {
        public int id { get; set; }
        public int cid { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }
    class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created_date { get; set; }
    }
    class Sale
    {
        public int id { get; set; }
        public int cid { get; set; }
        public string customer_name { get; set; }
        public string products { get; set; }
        public string product_location { get; set; }
        public int item_count { get; set; }
        public int total { get; set; }
        public int discount { get; set; }
        public int outstanding_balance { get; set; }
        public int cleared_amount { get; set; }
        public string payment_method { get; set; }
        public int part_payment { get; set; }
        public string bank_name { get; set; }
        public DateTime created_date { get; set; }
    }


    class Voucher
    {
        public int id { get; set; }
        public int amount { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public DateTime transaction_date { get; set; }
    }

    class VoucherCategory
    {
        public int id { get; set; }
        public string  name{ get; set; }
        public DateTime created_date { get; set; }
    }




    public class Key
    {

        public int id { get; set; }
        public string product_key { get; set; }
        public string status { get; set; }

    }


        public class Business
    {

        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string motto { get; set; }
        public string business_name { get; set; }
        public string status { get; set; }
        public string email_address { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public string product_key { get; set; }
        public string machine_name { get; set; }
        public byte[] logo { get; set; }
        public DateTime created_date { get; set; }
    }

}
