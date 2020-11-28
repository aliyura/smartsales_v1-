using System;
using System.Data.SqlClient;

namespace SmartSales_v1
{
    class SSDeletionSerice
    {
        App app = new App();
        SSService service = new SSService();
    
        public int resetCart(User user)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM ss_cart WHERE user_id=" + user.id + ""))
            {
                int response =  service.execute(command);
                return response;
            }

        }
        public int deleteSelectedCartProduct(int userId, string productName)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM ss_cart WHERE user_id=" + userId + " and product_name='"+ productName+ "'"))
            {
                int response =  service.execute(command);
                return response;
            }
        }


    }
}
