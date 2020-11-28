using System;
using System.Data;

namespace SmartSales_v1
{
    class SSRemoteService
    {

        App app = new App();
        SSService service = new SSService();

        public Key getProductKey(string productKey)
        {
            Key key = new Key();

            try
            {
                DataTable data = service.remoteGet("SELECT  top 1 * FROM [example] WHERE key='" + productKey + "'");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    key = new Key()
                    {
                        id = row.Field<int>("id"),
                        status= row.Field<string>("status"),
                        product_key = row.Field<string>("product_key"),
                    };
                }
                return key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return key;
            }
        }
    }
}