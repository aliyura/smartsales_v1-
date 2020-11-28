using System;
using System.Data;
using System.Windows.Forms;

namespace SmartSales_v1
{
    class SSGetService
    {

        App app = new App();
       //automate date setting
        SSService service = new SSService();

        public Percentage getProductPercentage()
        {
            Percentage percentage = new Percentage();
            try { 
                DataTable data = service.get("SELECT top 10 * FROM  ss_batches WHERE 1=1 ");
                if (data.Rows.Count > 0)
                {
                    int total = 0;
                    int sold = 0;
                    foreach (DataRow row in data.Rows)
                    {
                        total += row.Field<int>("total");
                        sold += row.Field<int>("sold");
                    }
                    if (sold == 0)
                        sold = 1;
                    percentage = new Percentage()
                    {
                        total = total,
                        left = sold,
                        percentage = (total - sold) / sold
                    };
                }
                return percentage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return percentage;
            }
        }
        public Percentage getDebtorsPercentage()
        {
            Percentage percentage = new Percentage();
            try
            {
                DataTable data = service.get("select top 10 sum(d.amount) debit, sum(p.cleared_amount) credit from ss_debtors d, ss_payments p where d.cid = p.cid");
                if (data.Rows.Count > 0)
                {
                    int total = 0;
                    int sold = 0;
                    foreach (DataRow row in data.Rows)
                    {
                        total += row.Field<int>("debit");
                        sold += row.Field<int>("credit");
                    }

                    if (sold == 0)
                        sold = 1;
                    percentage = new Percentage()
                    {
                        total = total,
                        left = sold,
                        percentage = (total - sold) / sold
                    };
                }
                return percentage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return percentage;
            }
        }
        public Percentage getBalancesPercentage()
        {
            Percentage percentage = new Percentage();
            try
            {
                DataTable data = service.get("select * from ss_customers");
                if (data.Rows.Count > 0)
                {
                    int total = 0;
                    int sold = 0;
                    foreach (DataRow row in data.Rows)
                    {
                        total += row.Field<int>("credit_limit");
                        sold += row.Field<int>("account_balance");
                    }

                    if (sold == 0)
                        sold = 1;
                    percentage = new Percentage()
                    {
                        total = total,
                        left = sold,
                        percentage = (total - sold) / sold
                    };
                }
                return percentage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return percentage;
            }
        }

        public DataTable getCartData(User user)
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT * FROM  ss_cart WHERE user_id="+ user.id+ "");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }

        public DataTable getProducts(string type)
        {
            string criteria = "b.balance>0";
            if (type == "#sold")
                criteria = "b.balance=0";

            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT s.id, s.bid batch_id, b.name batch_name, p.name product_name, p.barqr_code, p.price, s.cost, p.reorder_level, s.quantity, b.balance quantity_balance, s.last_modified_date FROM ss_stocks S, ss_batches b, ss_products p WHERE s.bid = b.id and b.pid = p.id and "+criteria+" order by s.last_modified_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable getProductWithFilter(string type, string filter)
        {
            string criteria = "b.balance>0";
            if (type == "#sold")
                criteria = "b.balance=0";

            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT s.id, s.bid batch_id, b.name batch_name, p.name product_name, p.barqr_code, p.price, s.cost, p.reorder_level, s.quantity, b.balance quantity_balance, s.last_modified_date FROM ss_stocks S, ss_batches b, ss_products p WHERE s.bid = b.id and b.pid = p.id and " + criteria + " and "+ filter + " order by s.last_modified_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataSet getProductDataset(string type)
        {
            string criteria = "b.balance>0";
            if (type == "#sold")
                criteria = "b.balance=0";

            DataSet data = new DataSet();
            try
            {
                data = service.getDataset("SELECT s.id, s.bid batch_id, b.name batch_name, p.name product_name, p.barqr_code, p.price, s.cost, p.reorder_level, s.quantity, b.balance quantity_balance, s.last_modified_date FROM ss_stocks S, ss_batches b, ss_products p WHERE s.bid = b.id and b.pid = p.id and " + criteria + " order by s.last_modified_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataSet getSalesDataset()
        {
            DataSet data = new DataSet();
            try
            {
                data = service.getDataset("select p.name, s.total from ss_batches b, ss_sale_details s, ss_products p where b.pid = s.pid and s.pid = p.id");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable searchProducts(string q, string type)
        {
            string criteria = "b.balance>0 and  (b.name like '%" + q + "%' or p.name like '%" + q + "%' or p.barqr_code like '%" + q + "%'  or p.price like '%" + q + "%' or s.cost like '%" + q + "%' or p.reorder_level like '%" + q + "%' or s.quantity like '%" + q + "%'  or b.balance like '%" + q + "%')";
            if (type == "#sold")
                criteria = "b.balance=0 and (b.name like '%" + q + "%' or p.name like '%" + q + "%' or p.barqr_code like '%" + q + "%'  or p.price like '%" + q + "%' or s.cost like '%" + q + "%' or p.reorder_level like '%" + q + "%' or s.quantity like '%" + q + "%'  or b.balance like '%" + q + "%')";
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT distinct s.id, s.bid batch_id, b.name batch_name, p.name product_name, p.barqr_code, p.price, s.cost, p.reorder_level, s.quantity, b.balance quantity_balance, s.last_modified_date FROM ss_stocks S, ss_batches b, ss_products p WHERE s.bid = b.id and b.pid = p.id and "+ criteria + " order by s.last_modified_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }

        public DataTable searchProductWithFilter(string q, string type, string filter)
        {
            string criteria = "b.balance>0 and  (b.name like '%" + q + "%' or p.name like '%" + q + "%' or p.barqr_code like '%" + q + "%'  or p.price like '%" + q + "%' or s.cost like '%" + q + "%' or p.reorder_level like '%" + q + "%' or s.quantity like '%" + q + "%'  or b.balance like '%" + q + "%')";
            if (type == "#sold")
                criteria = "b.balance=0 and (b.name like '%" + q + "%' or p.name like '%" + q + "%' or p.barqr_code like '%" + q + "%'  or p.price like '%" + q + "%' or s.cost like '%" + q + "%' or p.reorder_level like '%" + q + "%' or s.quantity like '%" + q + "%'  or b.balance like '%" + q + "%')";
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT distinct s.id, s.bid batch_id, b.name batch_name, p.name product_name, p.barqr_code, p.price, s.cost, p.reorder_level, s.quantity, b.balance quantity_balance, s.last_modified_date FROM ss_stocks S, ss_batches b, ss_products p WHERE s.bid = b.id and b.pid = p.id and " + criteria + " and "+ filter + " order by s.last_modified_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable getSales()
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT customer_name,total,discount,outstanding_balance,cleared_amount,part_payment,payment_method,bank_name,transaction_date FROM  ss_sales WHERE 1=1 order by transaction_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable getSaleWithFilter(string filter)
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT customer_name,total,discount,outstanding_balance,cleared_amount,part_payment,payment_method,bank_name,transaction_date FROM  ss_sales WHERE "+ filter + " order by transaction_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable searchSales(string q)
        {
            DataTable data = new DataTable();
            string  criteria = "customer_name like '%" + q + "%' or total like '%" + q + "%' or discount like '%" + q + "%'  or outstanding_balance like '%" + q + "%' or payment_method like '%" + q + "%' or bank_name like '%" + q + "%' or part_payment like '%" + q + "%'";
            try
            {
                data = service.get("SELECT  customer_name,total,discount,outstanding_balance,cleared_amount,part_payment,payment_method,bank_name,transaction_date  FROM ss_sales WHERE " + criteria + " order by transaction_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable searchSaleWithFilter(string q, string filter)
        {
            DataTable data = new DataTable();
            string criteria = "(customer_name like '%" + q + "%' or total like '%" + q + "%' or discount like '%" + q + "%'  or outstanding_balance like '%" + q + "%' or payment_method like '%" + q + "%' or bank_name like '%" + q + "%' or part_payment like '%" + q + "%')";
            try
            {
                data = service.get("SELECT  customer_name,total,discount,outstanding_balance,cleared_amount,part_payment,payment_method,bank_name,transaction_date  FROM ss_sales WHERE " + criteria + " and "+ filter + " order by transaction_date desc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }


        public DataTable getDataWithFilter(string table, string filter)
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM  " + table + " WHERE " + filter;
                data = service.get(query);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable getData(string query)
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get(query);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }
        public DataTable getDataFrom(string table)
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT * FROM  " + table + " WHERE 1=1 order by id asc");

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }


        public DataTable searchDataWithFilter(string table, string q, string filter)
        {
            DataTable data = new DataTable();
            string criteria = "1=1";

            if (table == app.objects["users"])
                criteria = "name like '%" + q + "%' or username like '%" + q + "%' or mobile_number like '%" + q + "%' ";
            else if (table == app.objects["banks"])
                criteria = "name like '%" + q + "%'";
            else if (table == app.objects["locations"])
                criteria = "name like '%" + q + "%' or type like '%" + q + "%'";
            else if (table == app.objects["products"])
                criteria = "name like '%" + q + "%' or price like '%" + q + "%'";
            else if (table == app.objects["customers"])
                criteria = "name like '%" + q + "%' or address like '%" + q + "%' or phone_number like '%" + q + "%' or credit_limit like '%" + q + "%' or customer_group like '%" + q + "%'";
            else if (table == app.objects["sales"])
                criteria = "name like '%" + q + "%' or username like '%" + q + "%'";

            try
            {
                data = service.get("SELECT * FROM " + table + " WHERE " + criteria + " and "+ filter + " order by id asc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }


        public DataTable searchDataFrom(string table, string q)
        {
            DataTable data = new DataTable();
            string criteria = "1=1";

            if (table == app.objects["users"])
                criteria = "name like '%" + q + "%' or username like '%" + q + "%' or mobile_number like '%" + q + "%' ";
            else if(table == app.objects["banks"])
                criteria = "name like '%" + q + "%'";
            else if (table == app.objects["locations"])
                criteria = "name like '%" + q + "%' or type like '%" + q + "%'";
            else if (table == app.objects["products"])
                criteria = "name like '%" + q + "%' or barqr_code like '%" + q + "%' or price like '%" + q + "%'";
            else if (table == app.objects["customers"])
                criteria = "name like '%" + q + "%' or address like '%" + q + "%' or phone_number like '%" + q + "%' or credit_limit like '%" + q + "%' or customer_group like '%" + q + "%'";
            else if (table == app.objects["payments"] || table == app.objects["adjustments"])
                criteria = "customer_name like '%" + q + "%' or transaction_type like '%" + q + "%' or payment_mode like '%" + q + "%' or transaction_amount like '%" + q + "%' or description like '%" + q + "%'";

            try
            {
                data = service.get("SELECT * FROM " + table + " WHERE "+ criteria + " order by id asc");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }


        public User getUserByMobileNumber(string number)
        {
            User user = new User();
           
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_users WHERE mobile_number='" + number + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    user = new User()
                    {
                        name = row.Field<string>("name"),
                        mobile_number = row.Field<string>("mobile_number"),
                        username = row.Field<string>("username"),
                        password = row.Field<string>("password"),
                        role = row.Field<string>("role"),
                        picture = row.Field<byte[]>("picture"),
                        login_date = row.Field<DateTime>("login_date"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;
            }
        }
        public User getUserByUsername(string username)
        {
            User user = new User();
           
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_users WHERE username='" + username + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    user = new User()
                    {
                        name = row.Field<string>("name"),
                        mobile_number = row.Field<string>("mobile_number"),
                        username = row.Field<string>("username"),
                        password = row.Field<string>("password"),
                        role = row.Field<string>("role"),
                        picture = row.Field<byte[]>("picture"),
                        login_date = row.Field<DateTime>("login_date"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;
            }
        }
        public User getUserById(int Id)
        {
            User user = new User();

            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_users WHERE id=" + Id + " order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    user = new User()
                    {
                        name = row.Field<string>("name"),
                        mobile_number = row.Field<string>("mobile_number"),
                        username = row.Field<string>("username"),
                        password = row.Field<string>("password"),
                        role = row.Field<string>("role"),
                        picture = row.Field<byte[]>("picture"),
                        login_date = row.Field<DateTime>("login_date"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;
            }
        }
        public Payment getLastPayment(int uid, int cid)
        {
            Payment payment = new Payment();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_payments WHERE user_id="+uid+" and  cid=" + cid + " order by transaction_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    payment = new Payment()
                    {
                        id = row.Field<int>("id"),
                    };
                }
                return payment;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return payment;
            }
        }

        public Voucher getLastVoucher(int uid)
        {
            Voucher voucher = new Voucher();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_vouchers WHERE user_id=" + uid + " order by transaction_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    voucher = new Voucher()
                    {
                        id = row.Field<int>("id"),
                    };
                }
                return voucher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return voucher;
            }
        }

        public Sale getLastPurchase(int uid, string customerName)
        {
            Sale sale = new Sale();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_sales WHERE user_id=" + uid + " and customer_name='"+customerName+ "' order by transaction_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    sale = new Sale()
                    {
                        id = row.Field<int>("id"),
                    };
                }
                return sale;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return sale;
            }
        }

        public Customer getCustomerById(int id)
        {
            Customer customer = new Customer();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_customers WHERE id="+id+" order by created_date asc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    customer = new Customer()
                    {
                        id = row.Field<int>("id"),
                        name = row.Field<string>("name"),
                        credit_limit = row.Field<int>("credit_limit"),
                        account_balance = row.Field<int>("account_balance"),
                    };
                }
                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return customer;
            }
        }
        public Customer getCustomerByName(string name)
        {
            Customer customer = new Customer();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_customers WHERE name='"+name+"' order by created_date asc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    customer = new Customer()
                    {
                        id = row.Field<int>("id"),
                        name = row.Field<string>("name"),
                        credit_limit = row.Field<int>("credit_limit"),
                        account_balance = row.Field<int>("account_balance"),
                    };
                }
                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return customer;
            }
        }
        public Debtor getDebtorById(int id)
        {
            Debtor debtor = new Debtor();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_debtors WHERE cid=" + id + " and amount>0 order by created_date asc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    debtor = new Debtor()
                    {
                        id = row.Field<int>("id"),
                        cid = row.Field<int>("cid"),
                        name = row.Field<string>("name"),
                        amount = row.Field<int>("amount"),
                        last_modified_date = row.Field<DateTime>("last_modified_date"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return debtor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return debtor;
            }
        }

        public Debtor getDebtorByIdEvenIfZero(int id)
        {
            Debtor debtor = new Debtor();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_debtors WHERE cid=" + id + " order by created_date asc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    debtor = new Debtor()
                    {
                        id = row.Field<int>("id"),
                        cid = row.Field<int>("cid"),
                        name = row.Field<string>("name"),
                        amount = row.Field<int>("amount"),
                        last_modified_date = row.Field<DateTime>("last_modified_date"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return debtor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return debtor;
            }
        }
        public Product getProductByName(string name)
        {
            Product product = new Product();
 
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_products WHERE name='" + name + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    product = new Product()
                    { 
                        id = row.Field<Int32>("id"),
                        name = row.Field<string>("name"),
                        price = row.Field<Int32>("price"),
                        reorder_level = row.Field<Int32>("reorder_level"),
                        barqr_code = row.Field<string>("barqr_code"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return product;
            }
        }


        public Batch getBatchByName(string name)
        {
            Batch batch = new Batch();

            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_batches WHERE name='" + name + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    batch = new Batch()
                    {
                        id = row.Field<Int32>("id"),
                        name = row.Field<string>("name"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return batch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return batch;
            }

        }


        public Business getBusinessByName(string name)
        {
            Business business = new Business();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_business WHERE name='" + name + "' order by created_date asc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    business = new Business()
                    {
                        id = row.Field<Int32>("id"),
                        business_name = row.Field<string>("name"),
                        address = row.Field<string>("address"),
                        telephone = row.Field<string>("telephone"),
                        email_address = row.Field<string>("email_address"),
                        product_key = row.Field<string>("product_key"),
                        status = row.Field<string>("status"),
                        logo = row.Field<byte[]>("logo"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return business;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return business;
            }

        }

        public Business getBusinessById(int id)
        {
            Business business = new Business();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_business WHERE id=" + id + " order by created_date asc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    business = new Business()
                    {
                        id = row.Field<Int32>("id"),
                        business_name = row.Field<string>("name"),
                        address = row.Field<string>("address"),
                        telephone = row.Field<string>("telephone"),
                        email_address = row.Field<string>("email_address"),
                        product_key = row.Field<string>("product_key"),
                        status = row.Field<string>("status"),
                        logo = row.Field<byte[]>("logo"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return business;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return business;
            }

        }

        public VoucherCategory getVoucherByName(string name)
        {
            VoucherCategory category = new VoucherCategory();

            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_voucher_categories WHERE name='" + name + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    category = new VoucherCategory()
                    {
                        id = row.Field<Int32>("id"),
                        name = row.Field<string>("name"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return category;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return category;
            }
        }

        public Batch getBatchByKey(string key)
        {
            Batch batch = new Batch();
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_batches WHERE reference_key='" + key + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    batch = new Batch()
                    {
                        id = row.Field<Int32>("id"),
                        key = row.Field<string>("reference_key"),
                        name = row.Field<string>("name"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return batch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return batch;
            }
        }

        public Location getLocationByName(string name)
        {
            Location existingLocation = new Location();
           
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_locations WHERE name='" + name + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    existingLocation = new Location()
                    {
                        name = row.Field<string>("name"),
                        type = row.Field<string>("type"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return existingLocation;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return existingLocation;
            }
        }
        public Location getLocationByCredentials(Location location)
        {
            Location existingLocation = new Location();
           
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_locations WHERE name='" + location.name + "' and type='" + location.type + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    existingLocation = new Location()
                    {
                        name = row.Field<string>("name"),
                        type = row.Field<string>("type"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return existingLocation;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return existingLocation;
            }
        }

        public Bank getBankByName(string name)
        {
            Bank existingBank = new Bank();
           
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_banks WHERE name='" + name + "'");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    existingBank = new Bank()
                    {
                        name = row.Field<string>("name"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return existingBank;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return existingBank;
            }
        }


        public Group getGroupByName(string name)
        {
            Group existingGroup = new Group();
           
            try
            {
                DataTable data = service.get("SELECT  top 1 * FROM ss_customer_groups WHERE name='" + name + "'");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    existingGroup = new Group()
                    {
                        name = row.Field<string>("name"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }
                return existingGroup;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return existingGroup;
            }
        }
    }
}