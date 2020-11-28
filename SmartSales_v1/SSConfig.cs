
using System.Configuration;

namespace SmartSales_v1
{
   class SSConfig
    {
        
        public  string getlocalConnection
        {
            get { return ConfigurationManager.ConnectionStrings["smartsalesConnectionString"].ConnectionString; ; }
        }

        public string  getRemoteConnection
        {
            get { return ConfigurationManager.ConnectionStrings["smartsalesConnectionString"].ConnectionString; ; }
        }
    
    }
}
