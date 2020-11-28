using System;
using System.Data;
using System.Data.SqlClient;

namespace SmartSales_v1
{
    class SSService
    {

        App app = new App();
        SSConfig config = new SSConfig();
        SqlConnection connection;
      
        public SSService()
        {
            connection = this.getConnection();
        }

        public  bool isConnencted()
        {
             try
            {
                SqlConnection con = new SqlConnection(config.getlocalConnection);//set the db connection
                con.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }

        }
        public SqlConnection getConnection()
        {
            return  new SqlConnection(config.getlocalConnection);//set the db connection
        }
        public SqlConnection getRemoteConnection()
        {
            return new SqlConnection(config.getRemoteConnection);//set the db connection
        }
        public int execute(SqlCommand cmd)//implementation of the sql command exwecution
        {
            try
            {
                connection = this.getConnection();
                cmd.Connection = connection;
                using (connection)
                {
                    using (cmd)
                    {
                        if (this.isConnencted())
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
                if (this.isConnencted())
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
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                app.showError(ex.Message);
                return null;
            }
        }

        public DataTable remoteGet(string query)//implementation of the sql command exwecution
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection = this.getRemoteConnection();
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

        public int remoteExecute(SqlCommand cmd)//implementation of the sql command exwecution
        {
            try
            {
                connection = this.getRemoteConnection();
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
        public DataSet getDataset(string query)//implementation of the sql command exwecution
        {
            DataSet dataSet = new DataSet();
            try
            {
                if (this.isConnencted())
                {
                    connection = this.getConnection();
                    using (connection)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {

                                connection.Open();
                                da.Fill(dataSet);
                                connection.Close();
                                da.Dispose();
                                return dataSet;
                            }
                        }
                    };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return dataSet;
            }


        }
        }

    }
