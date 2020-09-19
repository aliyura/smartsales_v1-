using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace SmartSales_v1
{
    class SSAddService
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
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add User",
                            statement = command.CommandText,
                            description = "Created user " + user.name,
                            created_date = currentDate
                        });

                    return response;

                }
            }
            else
            {
                return -2;
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
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Location",
                            statement = command.CommandText,
                            description = "Added new location" + location.name,
                            created_date = currentDate
                        });
                    return response;
                }
            }
            else
            {
                return -2;
            }
        }


        public int addProduct(Product product)
        {
            DateTime currentDate = DateTime.Now;
            Product existingProduct = getService.getProductByName(product.name);
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
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Product",
                            statement = command.CommandText,
                            description = "Added new Product" + product.name,
                            created_date = currentDate
                        });
                    return response;
                }
            }
            else
            {
                return -2;
            }

 
        }

        public int updateProduct(Stock stock)
        {
            DateTime currentDate = DateTime.Now;
            Product existingProduct = getService.getProductByName(stock.name);
            if (existingProduct.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_products(name,price,reorder_level,cost,barqr_code,created_date)VALUES(@name,@price,@reorder_level,@cost,@barqr_code,@created_date)"))
                {
                    command.Parameters.AddWithValue("@name", stock.name);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Updated Product",
                            statement = command.CommandText,
                            description = "Updated ["+ existingProduct.id+ "] Product",
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
       public int addBank(Bank bank)
        {
            DateTime currentDate = DateTime.Now;
            
            Bank existingbank = getService.getBankByName(bank.name);
            if (existingbank.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_banks(name,created_date)VALUES(@name,@created_date)"))
                {
                    command.Parameters.AddWithValue("@name", bank.name);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Bank",
                            statement = command.CommandText,
                            description = "Added new Bank" + bank.name,
                            created_date = currentDate
                        });
                    return response;
                }
            }
            else
            {
                app.showWarning("Bank already exist");
                return -2;
            }
        }

        public int addCustomerGroup(Group group)
        {
            DateTime currentDate = DateTime.Now;
            Group existingGroup = getService.getGroupByName(group.name);
            if (existingGroup.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_customer_groups(name,created_date)VALUES(@name,@created_date)"))
                {
                    command.Parameters.AddWithValue("@name", group.name);
                    command.Parameters.AddWithValue("@created_date", currentDate);
                    int response = service.add(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Group",
                            statement = command.CommandText,
                            description = "Added new Group" + group.name,
                            created_date = currentDate
                        });
                    return response;
                }
            }
            else
            {
                app.showWarning("Group already exist");
                return -2;
            }
        }

        public int addCustomer(Customer customer)
        {
            DateTime currentDate = DateTime.Now;
            using (SqlCommand command = new SqlCommand("INSERT INTO ss_customers(name,address,phone_number,altphone_number,credit_limit,customer_group,created_date)VALUES(@name,@address,@phone_number,@altphone_number,@credit_limit,@customer_group,@created_date)"))
                {

                command.Parameters.AddWithValue("@name", customer.name);
                command.Parameters.AddWithValue("@address", customer.address);
                command.Parameters.AddWithValue("@phone_number", customer.phone_number);
                command.Parameters.AddWithValue("@altphone_number", customer.altphone_number);
                command.Parameters.AddWithValue("@credit_limit", customer.credit_limit);
                command.Parameters.AddWithValue("@customer_group", customer.customer_group);
                command.Parameters.AddWithValue("@created_date", currentDate);
                int response = service.add(command);
                if (response > 0)
                    this.addLog(new Log()
                    {
                        type = "Add Customer",
                        statement = command.CommandText,
                        description = "Added new customer" + customer.name,
                        created_date = currentDate
                    });
                return response;
                }
    
        }

        public int addStock(Stock stock)
        {
            Product existingProduct = getService.getProductByName(stock.name);
            if (existingProduct.name != null)
            {
                Location existingLocation = getService.getLocationByName(stock.location);
                if (existingLocation.name != null)
                {

                    string batchId = app.generateId(10, true);
                    string batchName = "BATCH" + app.genetareNumber(1, 9999).ToString();

                    using (SqlCommand command = new SqlCommand("INSERT INTO ss_stocks(pid,bid,quantity,description,created_date,last_modified_date)VALUES(@pid,@bid,@quantity,@description,@created_date,@last_modified_date)"))
                    {
                        command.Parameters.AddWithValue("@pid", existingProduct.id);
                        command.Parameters.AddWithValue("@bid", batchId);
                        command.Parameters.AddWithValue("@quantity", stock.quantity);
                        command.Parameters.AddWithValue("@description", stock.description);
                        command.Parameters.AddWithValue("@last_modified_date", currentDate);
                        command.Parameters.AddWithValue("@created_date", currentDate);
                        int response = service.add(command);
                        if (response > 0)
                        {
                            using (SqlCommand batchCommand = new SqlCommand("INSERT INTO ss_batches(id,name,pid,total,balance,sold,created_date)VALUES(@id,@name,@pid,@total,@balance,@sold,@created_date)"))
                            {
                                batchCommand.Parameters.AddWithValue("@id", batchId);
                                batchCommand.Parameters.AddWithValue("@name", batchName);
                                batchCommand.Parameters.AddWithValue("@pid", existingProduct.id);
                                batchCommand.Parameters.AddWithValue("@total", stock.quantity);
                                batchCommand.Parameters.AddWithValue("@balance", stock.quantity);
                                batchCommand.Parameters.AddWithValue("@sold", 0);
                                batchCommand.Parameters.AddWithValue("@created_date", currentDate);
                                int batchResponse = service.add(batchCommand);
                                if (batchResponse > 0)
                                    this.addLog(new Log()
                                    {
                                        type = "Add Stock",
                                        statement = command.CommandText + ";" + batchCommand.CommandText,
                                        description = "Added new Stock" + stock.name,
                                        created_date = currentDate
                                    });
                                return batchResponse;
                            }
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                else
                {
                    return -404;
                }
            }
            else
            {
                return -403;

            }
            return -1;
        }






    }
}
