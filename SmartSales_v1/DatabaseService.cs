using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SmartSales_v1
{
    class DatabaseService
    {

        App app = new App();
        SqlConnection connection;
        DateTime currentDate = DateTime.Now;//automate date setting
        SqlDataReader reader;

        public SqlConnection refreshConnection()
        {
            connection= new SqlConnection("Data Source=DESKTOP-S0QL4PD;Initial Catalog=smartsalesdb;Integrated Security=True;Pooling=False");//set the db connection
            return connection;
        }

<<<<<<< HEAD
        public SqlDataReader read(SqlDataReader r)
        {
            reader = r;
            return reader;
=======
        public DatabaseService()
        {
            this.connection = new SqlConnection("Data Source=DESKTOP-S0QL4PD;Initial Catalog=smartsalesdb;Integrated Security=True;Pooling=False");//set the db connection
>>>>>>> refs/remotes/origin/master
        }
        public int add(SqlCommand cmd)//implementation of the sql command exwecution
        {
            try
            {
                using (connection)
                {
                    using (cmd)
                    {
                        if (connection != null)
                        {
                            connection.Open();
                            int response= cmd.ExecuteNonQuery();
                            connection.Close();
                            return response;
                        }
                        else
                        {
                            return -1;//...else return error
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return -1;
            }
<<<<<<< HEAD
           
=======
            finally
            {
                connection.Close();
            }

>>>>>>> refs/remotes/origin/master
        }
        public DataTable get(string query)//implementation of the sql command exwecution
        {
            DataTable dataTable = new DataTable();
            try
            {
                this.refreshConnection();
                using (connection)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            connection.Open();
                            da.Fill(dataTable);
                            connection.Close();
                            da.Dispose();
                            return dataTable;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return null;
            }


        }
        public User getUserByMobileNumber(string number)
        {
<<<<<<< HEAD
            User user=new User();
            try
            {
                DataTable data = this.get("SELECT  top 1 * FROM ss_users WHERE mobile_number='" + number + "' order by created_date desc");
                if (data.Rows.Count > 0)
                {
                    DataRow row= data.Rows[0];
                    user = new User()
                    {   
                        name=row.Field<string>("name"),
                        mobile_number = row.Field<string>("mobile_number"),
                        username = row.Field<string>("username"),
                        password= row.Field<string>("password"),
                        role = row.Field<string>("role"),
                        login_date = row.Field<DateTime>("login_date"),
                        created_date = row.Field<DateTime>("created_date"),
=======
            string query = "INSERT INTO ss_users(name, username, password, mobile_number, login_date, created_date)VALUES(@name,@username,@password, @mobile_number, @login_date, @created_date)";
            SqlCommand command = new SqlCommand(query, connection);
            //below lines assign the entered data to the fields created in the model class
            command.Parameters.AddWithValue("@name", user.name);
            command.Parameters.AddWithValue("@username", user.username);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@mobile_number", user.mobile_number);
            command.Parameters.AddWithValue("@login_date", currentDate);
            command.Parameters.AddWithValue("@created_date", currentDate);
>>>>>>> refs/remotes/origin/master

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
            try
            {
                DataTable data = this.get("SELECT  top 1 * FROM ss_users WHERE username='" + username + "' order by created_date desc");
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
        public DataTable getUsers()
        {
            DataTable data = new DataTable();
            try
            {
                 data = this.get("SELECT* FROM ss_users WHERE 1=1 order by created_date desc");
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
                data = this.get("SELECT* FROM ss_products WHERE 1=1 order by created_date desc");
                return data;
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return data;
            }
        }
        public int addUser(User user)
        {
            User existingUser = this.getUserByMobileNumber(user.mobile_number);
            if (existingUser.mobile_number==null)
            {
                this.refreshConnection();
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_users(name, username, password, mobile_number, login_date, created_date)VALUES(@name,@username,@password, @mobile_number, @login_date, @created_date)", connection))
                {
                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@mobile_number", user.mobile_number);
                    command.Parameters.AddWithValue("@login_date", currentDate);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = this.add(command);
                    return response;

                }
            }
            else
            {
                app.showWarning("User already exist");
                return -1;
            }
        }
    }
}
