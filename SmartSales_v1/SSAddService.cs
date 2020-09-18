using System;
using System.Data.SqlClient;


namespace SmartSales_v1
{
    class SSAddService
    {

        App app = new App();
        SqlConnection connection;
        DateTime currentDate = DateTime.Now;//automate date setting
        SSService service = new SSService();
        SSGetService getService = new SSGetService();


        public SSAddService()
        {
            this.connection = service.refreshConnection();
        }


        public int addUser(User user)
        {
            User existingUser = getService.getUserByMobileNumber(user.mobile_number);
            if (existingUser.mobile_number == null)
            {
                service.refreshConnection();
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_users(name, username, password, mobile_number, login_date, created_date)VALUES(@name,@username,@password, @mobile_number, @login_date, @created_date)", connection))
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
            Location existingLocation = getService.getLocationByCredentials(location);
            if (existingLocation.name == null)
            {
                service.refreshConnection();
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_locations(name, type,created_date)VALUES(@name,@type,@created_date)", connection))
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




    }
}
