using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SmartSales_v1
{
    class SSGetService
    {

        App app = new App();
        DateTime currentDate = DateTime.Now;//automate date setting
        SSService service = new SSService();


        public DataTable getDataFrom(string table)
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT * FROM "+ table + " WHERE 1=1 order by id asc");
                return data;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
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
                criteria = "name like '%" + q + "%' or price like '%" + q + "%' or cost like '%" + q + "%' ";
            else if (table == app.objects["customers"])
                criteria = "name like '%" + q + "%' or address like '%" + q + "%' or phone_number like '%" + q + "%' or credit_limit like '%" + q + "%' or customer_group like '%" + q + "%'";


            try
            {
                data = service.get("SELECT * FROM " + table + " WHERE "+ criteria + " order by id asc");
                return data;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return data;
            }
        }

        public User getUserByMobileNumber(string number)
        {
            User user = new User();
            DateTime currentDate = DateTime.Now;
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
                        login_date = row.Field<DateTime>("login_date"),
                        created_date = row.Field<DateTime>("created_date"),
                    };
                }

                return user;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return user;
            }
        }
        public User getUserByUsername(string username)
        {
            User user = new User();
            DateTime currentDate = DateTime.Now;
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
                        login_date = row.Field<DateTime>("login_date"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return user;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return user;
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
                        cost = row.Field<Int32>("cost"),
                        barqr_code = row.Field<string>("barqr_code"),
                        created_date = row.Field<DateTime>("created_date"),

                    };
                }
                return product;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return product;
            }
        }

        public Location getLocationByName(string name)
        {
            Location existingLocation = new Location();
            DateTime currentDate = DateTime.Now;
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
                app.showError(ex.Message);
                return existingLocation;
            }
        }
        public Location getLocationByCredentials(Location location)
        {
            Location existingLocation = new Location();
            DateTime currentDate = DateTime.Now;
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
                app.showError(ex.Message);
                return existingLocation;
            }
        }

        public Bank getBankByName(string name)
        {
            Bank existingBank = new Bank();
            DateTime currentDate = DateTime.Now;
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
                app.showError(ex.Message);
                return existingBank;
            }
        }


        public Group getGroupByName(string name)
        {
            Group existingGroup = new Group();
            DateTime currentDate = DateTime.Now;
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
                app.showError(ex.Message);
                return existingGroup;
            }
        }
    }
}