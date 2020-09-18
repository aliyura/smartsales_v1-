using System;
using System.Data.SqlClient;


namespace SmartSales_v1
{
    class SSAddService
    {

        App app = new App();
        DateTime currentDate = DateTime.Now;//automate date setting
        SSService service = new SSService();
        SSGetService getService = new SSGetService();



        
        public int addUser(User user)
        {
            DateTime currentDate = DateTime.Now;
            User existingUser = getService.getUserByMobileNumber(user.mobile_number);
            if (existingUser.mobile_number == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_users(name, username, password, mobile_number, login_date, created_date)VALUES(@name,@username,@password, @mobile_number, @login_date, @created_date)"))
                {
                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@mobile_number", user.mobile_number);
                    command.Parameters.AddWithValue("@login_date", currentDate);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    return response;

                }
            }
            else
            {
                app.showWarning("User already exist");
                return -1;
            }
        }
        public int addLocation(Location location)
        {
            DateTime currentDate = DateTime.Now;
            Location existingLocation = getService.getLocationByCredentials(location);
            if (existingLocation.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_locations(name, type,created_date)VALUES(@name,@type,@created_date)"))
                {
                    command.Parameters.AddWithValue("@name", location.name);
                    command.Parameters.AddWithValue("@type", location.type);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    return response;
                }
            }
            else
            {
                app.showWarning("Location already exist");
                return -1;
            }
        }

        public int addBank(Bank bank)
        {
            DateTime currentDate = DateTime.Now;
            Bank existingBank = getService.getBankByName(bank.name);
            if (existingBank.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_banks(name,created_date)VALUES(@name,@created_date)"))
                {
                    command.Parameters.AddWithValue("@name", bank.name);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    app.showWarning(response.ToString());
                    return response;
                }
            }
            else
            {
                app.showWarning("Bank already exist");
                return -1;
            }
        }

        public int addProduct(Product product)
        {
            DateTime currentDate = DateTime.Now;
            Product existingProduct= getService.getProductByName(product.name);
            if (existingProduct.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_products(name,price,reorder_level,cost,barqr_code,created_date)VALUES(@name,@price,@reorder_level,@cost,@barqr_code,@created_date)"))
                {
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@reorder_level", product.reorder_level);
                    command.Parameters.AddWithValue("@cost", product.cost);
                    command.Parameters.AddWithValue("@barqr_code", product.barqr_code);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    app.showWarning(response.ToString());
                    return response;
                }
            }
            else
            {
                app.showWarning("Product already exist");
                return -1;
            }
        }



    }
}
