using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartSales_v1
{
    class DatabaseService
    {

        SqlConnection connection;
        App app = new App();
        string currentDate = DateTime.Now.ToString("yyyy.MM.dd");

        public  DatabaseService()
        {
            this.connection= new SqlConnection("Data Source=DESKTOP-S0QL4PD;Initial Catalog=smartsalesdb;Integrated Security=True;Pooling=False");
        }
        public int execute(SqlCommand cmd)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    using (cmd)
                    {
                        if (connection != null)
                            return cmd.ExecuteNonQuery();
                        else
                            return -1;

                    }
                }
            }
            catch (SqlException ex)
            {
                app.showError(ex.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }
           
        }

        public int addUser(User user)
        {
            string query = "INSERT INTO ss_users(name, username, password, mobile_number, login_date, created_date)VALUES(@name,@username,@password, @mobile_number, @login_date, @created_date)";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@name", user.name);
            command.Parameters.AddWithValue("@username", user.username);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@mobile_number", user.mobile_number);
            command.Parameters.AddWithValue("@login_date", currentDate);
            command.Parameters.AddWithValue("@created_date", currentDate);


            int response = this.execute(command);
            return response;

        }

    }
}
