using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;


namespace SmartSales_v1
{
    class SSGetService
    {

        App app = new App();
        SqlConnection connection;
        DateTime currentDate = DateTime.Now;//automate date setting
        SSService service = new SSService();
       
        public SSGetService()
        {
            this.connection = service.refreshConnection();
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

                    string query = "INSERT INTO ss_users(name, username, password, mobile_number, login_date, created_date)VALUES(@name,@username,@password, @mobile_number, @login_date, @created_date)";
                    SqlCommand command = new SqlCommand(query, connection);
                    //below lines assign the entered data to the fields created in the model class
                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@mobile_number", user.mobile_number);
                    command.Parameters.AddWithValue("@login_date", currentDate);
                    command.Parameters.AddWithValue("@created_date", currentDate);

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


        public DataTable getUsers()
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT* FROM ss_users WHERE 1=1 order by created_date desc");
                return data;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return data;
            }
        }
        public DataTable getProducts()
        {
            DataTable data = new DataTable();
            try
            {
                data = service.get("SELECT* FROM ss_products WHERE 1=1 order by created_date desc");
                return data;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return data;
            }
        }

    }
}