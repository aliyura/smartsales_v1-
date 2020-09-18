using System;
using System.Data;
using System.Data.SqlClient;

namespace SmartSales_v1
{
    class SSService
    {

        App app = new App();
        SqlConnection connection;
        DateTime currentDate = DateTime.Now;//automate date setting
        string connecionStrring = "Data Source=DESKTOP-S0QL4PD;Initial Catalog=smartsalesdb;Integrated Security=True;Pooling=False";


        public SSService()
        {
            connection = this.getConnection();
        }
        public SqlConnection getConnection()
        {
            return  new SqlConnection(connecionStrring);//set the db connection
        }


        public int add(SqlCommand cmd)//implementation of the sql command exwecution
        {
            try
            {
                connection = this.getConnection();
                cmd.Connection = connection;
                using (connection)
                {
                    using (cmd)
                    {
                        if (connection != null)
                        {
                            connection.Open();
                            int response = cmd.ExecuteNonQuery();
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
            finally
            {
                connection.Close();
            }
        }
        public DataTable get(string query)//implementation of the sql command exwecution
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection = this.getConnection();
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
    }

}
