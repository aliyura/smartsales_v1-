using System;
using System.Data.SqlClient;

namespace SmartSales_v1
{
    class SSUpdateService
    {
        App app = new App();
        DateTime currentDate = DateTime.Now;//automate date setting
        SSService service = new SSService();
        SSGetService getService = new SSGetService();
        public int addLog(Log log)
        {
            DateTime currentDate = DateTime.Now;
            using (SqlCommand command = new SqlCommand("INSERT INTO ss_logs(description, statement, type, created_date)VALUES(@description, @statement, @type, @created_date)"))
            {
                command.Parameters.AddWithValue("@description", log.created_date);
                command.Parameters.AddWithValue("@statement", log.statement);
                command.Parameters.AddWithValue("@type", log.type);
                command.Parameters.AddWithValue("@created_date", currentDate);
                int response = service.add(command);
                return response;

            }
        }
        public int updatePrice(PriceUpdate priceUpdate)
        {
            DateTime currentDate = DateTime.Now;
            Product existingProduct = getService.getProductByName(priceUpdate.name);
            if (existingProduct.name != null)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ss_product SET (current_price,current_cost,new_price,new_cost) VALUES(@current_price,@current_cost,@new_price,@new_cost)"))
                {
                    command.Parameters.AddWithValue("@current_price", priceUpdate.current_price);
                    command.Parameters.AddWithValue("@current_cost", priceUpdate.current_cost);
                    command.Parameters.AddWithValue("@new_cost", priceUpdate.new_cost);
                    command.Parameters.AddWithValue("@new_price", priceUpdate.new_price);
                    int response = service.add(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Updated Price",
                            statement = command.CommandText,
                            description = "Updated [" + existingProduct.id + "] Product",
                            created_date = currentDate
                        });
                    return response;
                }
            }
            else
            {
                return -404;
            }
        }
    }
}
