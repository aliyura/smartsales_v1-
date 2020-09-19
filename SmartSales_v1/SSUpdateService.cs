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
        SSAddService addService = new SSAddService();
    
        public int updatePrice(Product product)
        {
            DateTime currentDate = DateTime.Now;
            Product existingProduct = getService.getProductByName(product.name);
            if (existingProduct.name != null)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ss_products SET price=@price, cost=@cost WHERE id="+existingProduct.id+""))
                {
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@cost", product.cost);
                    int response = service.add(command);
                    if (response > 0)
                        addService.addLog(new Log()
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
