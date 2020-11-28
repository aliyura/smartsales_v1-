using System;
using System.Data;
using System.Data.SqlClient;

namespace SmartSales_v1
{
    class SSAddService
    {

        App app = new App();
        SSService service = new SSService();
      
        public int addLog(Log log)
        {

            User session = app.getSession();
            using (SqlCommand command = new SqlCommand("INSERT INTO ss_logs(description, statement, type, user_id, username)VALUES(@description, @statement, @type, @user_id, @username)"))
            {
                command.Parameters.AddWithValue("@description", log.created_date.ToString());
                command.Parameters.AddWithValue("@statement", log.statement);
                command.Parameters.AddWithValue("@type", log.type);
                command.Parameters.AddWithValue("@user_id", session.id);
                command.Parameters.AddWithValue("@username", session.username);
                int response = service.execute(command);
                return response;
            }
        }


        public int MakeVoucher(Voucher voucher)
        {
            SSGetService getService = new SSGetService();
            VoucherCategory category = getService.getVoucherByName(voucher.type);
            if (category.name != null)
            {

                DataTable data = service.get("select * from ss_account");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    int balance = row.Field<int>("balance");
                    int previusBalance = balance;

                    if (balance >= voucher.amount)
                    {

                        balance = balance - voucher.amount;
                        using (SqlCommand command = new SqlCommand("update ss_account set balance=@balance, previous_balance=@previous_balance"))
                        {
                            command.Parameters.AddWithValue("@balance", balance);
                            command.Parameters.AddWithValue("@previous_balance", previusBalance);

                            if (service.execute(command) > 0)
                            {

                                User user = app.getSession();
                                using (SqlCommand addCommand = new SqlCommand("INSERT INTO ss_vouchers(user_id,amount,amount_in_words,type,description)VALUES(@user_id,@amount,@amount_in_words,@type,@description)"))
                                {
                                    addCommand.Parameters.AddWithValue("@user_id", user.id);
                                    addCommand.Parameters.AddWithValue("@amount", voucher.amount);
                                    addCommand.Parameters.AddWithValue("@amount_in_words",app.toWordsOf(voucher.amount));
                                    addCommand.Parameters.AddWithValue("@type", voucher.type);
                                    addCommand.Parameters.AddWithValue("@description", voucher.description);

                                    return service.execute(addCommand);

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
                        return -402;
                    }

                }
                else
                {
                    return -403;
                }

            }
            else
            {
                return -404;
            }

        }
        public int addPayment(Payment payment)
        {
            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            User user = app.getSession();
            Customer customer = getService.getCustomerByName(payment.customer_name);
            if (customer.name != null)
            {

                if (payment.transaction_type == "Payment")
                {

                    Debtor debtor = getService.getDebtorById(customer.id);
                    if (debtor.name != null)
                    {


                        int clearedAmount;
                        int outstanding;

                        clearedAmount = outstanding = 0;

                        //perform the caculation
                        if (payment.transaction_amount >= debtor.amount)
                        {
                            clearedAmount = (debtor.amount);
                            outstanding = (debtor.amount - payment.transaction_amount);
                        }
                        else
                        {
                            clearedAmount = payment.transaction_amount;
                            outstanding = (debtor.amount - payment.transaction_amount);
                        }


                        //add payment entry
                        using (SqlCommand command = new SqlCommand("INSERT INTO ss_payments(cid,user_id,customer_name,transaction_amount,cleared_amount,amount_in_words,transaction_type,payment_mode,description)VALUES(@cid,@user_id,@customer_name,@transaction_amount,@cleared_amount,@amount_in_words,@transaction_type,@payment_mode,@description)"))
                        {
                            command.Parameters.AddWithValue("@cid", customer.id);
                            command.Parameters.AddWithValue("@user_id", user.id);
                            command.Parameters.AddWithValue("@customer_name", customer.name);
                            command.Parameters.AddWithValue("@transaction_amount", payment.transaction_amount);
                            command.Parameters.AddWithValue("@cleared_amount", clearedAmount);
                            command.Parameters.AddWithValue("@amount_in_words", app.toWordsOf(payment.transaction_amount));
                            command.Parameters.AddWithValue("@transaction_type", payment.transaction_type);
                            command.Parameters.AddWithValue("@payment_mode", payment.payment_mode);
                            command.Parameters.AddWithValue("@description", payment.description);

                            if (service.execute(command) > 0)
                            {
                                if (outstanding < 0)
                                {
                                    //update customer balance if any
                                    if (customer.account_balance > 0 || customer.account_balance < 0)
                                    {
                                        customer.account_balance += Math.Abs(outstanding);
                                    }
                                    else
                                    {
                                        customer.account_balance = Math.Abs(outstanding);
                                    }

                                    updateService.updateCustomerBalance(customer);
                                }

                                //update debtor balance
                                if (clearedAmount >= debtor.amount)
                                {
                                    debtor.amount = 0;
                                }
                                else
                                {
                                    debtor.amount = outstanding;
                                }


                                DataTable data = service.get("select * from ss_account");
                                if (data.Rows.Count > 0)
                                {
                                    DataRow row = data.Rows[0];
                                    int balance = row.Field<int>("balance");
                                    int previusBalance = balance;

                                    balance = balance + payment.transaction_amount;
                                    using (SqlCommand updateCommand = new SqlCommand("update ss_account set balance=@balance, previous_balance=@previous_balance"))
                                    {
                                        updateCommand.Parameters.AddWithValue("@balance", balance);
                                        updateCommand.Parameters.AddWithValue("@previous_balance", previusBalance);

                                        if (service.execute(updateCommand) > 0)
                                        {
                                            return updateService.updateDebtorBalance(debtor);
                                        }
                                        else
                                        {
                                            return -1;
                                        }
                                    }

                                }
                                else
                                {
                                    return -1;
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
                        if (payment.description == "Purchasing Payment")
                        {

                            using (SqlCommand command = new SqlCommand("INSERT INTO ss_payments(cid,user_id,customer_name,transaction_amount,cleared_amount,amount_in_words,transaction_type,payment_mode,description)VALUES(@cid,@user_id,@customer_name,@transaction_amount,@cleared_amount,@amount_in_words,@transaction_type,@payment_mode,@description)"))
                            {
                                command.Parameters.AddWithValue("@cid", customer.id);
                                command.Parameters.AddWithValue("@user_id", user.id);
                                command.Parameters.AddWithValue("@customer_name", customer.name);
                                command.Parameters.AddWithValue("@transaction_amount", payment.transaction_amount);
                                command.Parameters.AddWithValue("@cleared_amount", payment.cleared_amount);
                                command.Parameters.AddWithValue("@amount_in_words", app.toWordsOf(payment.transaction_amount));
                                command.Parameters.AddWithValue("@transaction_type", payment.transaction_type);
                                command.Parameters.AddWithValue("@payment_mode", payment.payment_mode);
                                command.Parameters.AddWithValue("@description", payment.description);

                                if (service.execute(command) > 0)
                                {
                                    DataTable data = service.get("select * from ss_account");
                                    if (data.Rows.Count > 0)
                                    {
                                        DataRow row = data.Rows[0];
                                        int balance = row.Field<int>("balance");
                                        int previusBalance = balance;

                                        balance = balance + payment.transaction_amount;
                                        using (SqlCommand updateCommand = new SqlCommand("update ss_account set balance=@balance, previous_balance=@previous_balance"))
                                        {
                                            updateCommand.Parameters.AddWithValue("@balance", balance);
                                            updateCommand.Parameters.AddWithValue("@previous_balance", previusBalance);

                                            return service.execute(updateCommand);
                                        }

                                    }
                                    else
                                    {
                                        return -1;
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
                            return -202;
                        }
                    }
                }
                else
                {

                    int clearedAmount = 0;
                    int outstanding = 0;
                    if (payment.payment_mode == "Credit")
                    {

                        Debtor debtor = getService.getDebtorByIdEvenIfZero(customer.id);
                        if (debtor.name != null)
                        {
                            debtor.amount += payment.transaction_amount;
                            int res = updateService.updateDebtorBalance(debtor);
                        }
                        else
                        {
                            this.addDebtor(customer, payment.transaction_amount);
                        }
                    }
                    else
                    {
                        Debtor debtor = getService.getDebtorByIdEvenIfZero(customer.id);
                        if (debtor.name != null)
                        {
                            if (debtor.amount >= payment.transaction_amount)
                            {
                                debtor.amount = (debtor.amount - payment.transaction_amount);
                                clearedAmount = payment.transaction_amount;
                                updateService.updateDebtorBalance(debtor);
                            }
                            else
                            {
                                clearedAmount = debtor.amount;
                                outstanding = (payment.transaction_amount - debtor.amount);
                                debtor.amount = 0;
                                updateService.updateDebtorBalance(debtor);

                                if (outstanding > 0)
                                {
                                    customer.account_balance += outstanding;
                                    updateService.updateCustomerBalance(customer);
                                }
                            }
                        }
                        else
                        {
                            customer.account_balance += payment.transaction_amount;
                            updateService.updateCustomerBalance(customer);
                        }

                    }

                    using (SqlCommand command = new SqlCommand("INSERT INTO ss_adjustments(cid,customer_name,transaction_amount,cleared_amount,transaction_type,payment_mode,description)VALUES(@cid,@customer_name,@transaction_amount,@cleared_amount,@transaction_type,@payment_mode,@description)"))
                    {
                        command.Parameters.AddWithValue("@cid", customer.id);
                        command.Parameters.AddWithValue("@customer_name", customer.name);
                        command.Parameters.AddWithValue("@transaction_amount", payment.transaction_amount);
                        command.Parameters.AddWithValue("@cleared_amount", clearedAmount);
                        command.Parameters.AddWithValue("@transaction_type", payment.transaction_type);
                        command.Parameters.AddWithValue("@payment_mode", payment.payment_mode);
                        command.Parameters.AddWithValue("@description", payment.description);


                        DataTable data = service.get("select * from ss_account");
                        if (data.Rows.Count > 0)
                        {
                            DataRow row = data.Rows[0];
                            int balance = row.Field<int>("balance");
                            int previusBalance = balance;

                            if (payment.payment_mode == "Credit")
                                balance = balance + payment.transaction_amount;
                            

                            using (SqlCommand updateCommand = new SqlCommand("update ss_account set balance=@balance, previous_balance=@previous_balance, last_modified_date=getdate()"))
                            {
                                updateCommand.Parameters.AddWithValue("@balance", balance);
                                updateCommand.Parameters.AddWithValue("@previous_balance", previusBalance);

                                if (service.execute(updateCommand) > 0)
                                {

                                    return service.execute(command);
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            else
            {
                return -404;
            }
        
        }
        public int addDebtor(Customer customer,int  amount)
        {
            SSGetService getService = new SSGetService();
            if (customer.id != -1)
            {
                Debtor debtor = getService.getDebtorByIdEvenIfZero(customer.id);
                if (debtor.name == null)
                {
                    //add the debt if not there
                    using (SqlCommand command = new SqlCommand("INSERT INTO ss_debtors(cid,name,amount,last_modified_date)VALUES(@cid,@name,@amount,getdate())"))
                    {
                        command.Parameters.AddWithValue("@cid",customer.id);
                        command.Parameters.AddWithValue("@name", customer.name);
                        command.Parameters.AddWithValue("@amount", amount );
                        int response = service.execute(command);
                        return response;
                    }
                }
                else
                {
                    //increase the debit if already there
                    amount = debtor.amount + amount;
                    using (SqlCommand command = new SqlCommand("UPDATE ss_debtors SET amount=@amount,last_modified_date=getdate() WHERE cid="+debtor.cid))
                    {
                        command.Parameters.AddWithValue("@amount", amount);
                        int response = service.execute(command);
                        return response;
                    }
                }
            }
            else
            {
                return -404;
            }

        }





        public int addSale(Sale sale)
        {
            SSGetService getService = new SSGetService();
            User user = app.getSession();
            DataTable cartData = getService.getCartData(user);
            if (cartData.Rows.Count > 0)
            {

                using (SqlCommand command = new SqlCommand("INSERT INTO ss_sales(pids,user_id,customer_id,item_count,customer_name,location,total,discount,outstanding_balance,cleared_amount,part_payment,payment_method,bank_name)VALUES(@pids,@user_id,@customer_id,@item_count,@customer_name,@location,@total,@discount,@outstanding_balance,@cleared_amount,@part_payment,@payment_method,@bank_name)"))
                {
                    command.Parameters.AddWithValue("@pids", sale.products);
                    command.Parameters.AddWithValue("@user_id", user.id);
                    command.Parameters.AddWithValue("@customer_id", sale.cid);
                    command.Parameters.AddWithValue("@customer_name", sale.customer_name);
                    command.Parameters.AddWithValue("@item_count", sale.item_count);
                    command.Parameters.AddWithValue("@location", sale.product_location);
                    command.Parameters.AddWithValue("@total", sale.total);
                    command.Parameters.AddWithValue("@discount", sale.discount);
                    command.Parameters.AddWithValue("@outstanding_balance", sale.outstanding_balance);
                    command.Parameters.AddWithValue("@cleared_amount", sale.cleared_amount);
                    command.Parameters.AddWithValue("@part_payment", sale.part_payment);
                    command.Parameters.AddWithValue("@payment_method", sale.payment_method);
                    command.Parameters.AddWithValue("@bank_name", sale.bank_name);

                    int response = service.execute(command);
                    if (response > 0)
                    {
                        using (SqlCommand salesDetailsCommand = new SqlCommand("INSERT INTO ss_sale_details(user_id, tid,pid,bid,product_name,quantity,unit_price,unit_discount,location,total,transaction_date)SELECT user_id, (select top 1 id from ss_sales l where l.user_id = " + user.id + " and l.customer_name = '" + sale.customer_name + "' order by l.transaction_date desc) tid, pid, bid, product_name, quantity, unit_price, unit_discount, location, total, created_date FROM ss_cart where user_id = " + user.id))
                        {
                            if (service.execute(salesDetailsCommand) > 0)
                            {
                                using (SqlCommand cartResetCommand = new SqlCommand("DELETE ss_cart WHERE user_id=" + user.id))
                                {
                                    if (sale.payment_method == "Credit")
                                    {
                                        Customer customer = new Customer()
                                        {
                                            id = sale.cid,
                                            name = sale.customer_name
                                        };
                                        this.addDebtor(customer, sale.total);
                                    }

                                    return service.execute(cartResetCommand);
                                };
                            }
                            else
                            {
                                return -1;
                            }

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

        public int addToCart(Cart cart)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO ss_cart(user_id,pid,product_name,quantity,location,unit_price,unit_discount, total)VALUES(@user_id,@pid,@product_name,@quantity,@location,@unit_price,@unit_discount,@total)"))
            {
                command.Parameters.AddWithValue("@user_id", cart.user_id);
                command.Parameters.AddWithValue("@pid", cart.pid);
                command.Parameters.AddWithValue("@product_name", cart.product_name);
                command.Parameters.AddWithValue("@quantity", cart.quantity);
                command.Parameters.AddWithValue("@location", cart.location);
                command.Parameters.AddWithValue("@unit_price", cart.unit_price);
                command.Parameters.AddWithValue("@unit_discount", cart.unit_discount);
                command.Parameters.AddWithValue("@total", ((cart.unit_price - cart.unit_discount) * cart.quantity));

                int response = service.execute(command);
                return response;

            }
        }
        public int replaceCart(Cart cart)
        {
            using (SqlCommand checkCommand = new SqlCommand("DELETE ss_cart WHERE product_name='" + cart.product_name + "' and user_id=" + cart.user_id + ""))
            {
                int res =  service.execute(checkCommand);
                if (res > 0)
                {

                    using (SqlCommand command = new SqlCommand("INSERT INTO ss_cart(user_id,pid,product_name,quantity,location,unit_price,unit_discount,total)VALUES(@user_id,@pid,@product_name,@quantity,@location,@unit_price,@unit_discount,@total)"))
                    {
                        command.Parameters.AddWithValue("@user_id", cart.user_id);
                        command.Parameters.AddWithValue("@pid", cart.pid);
                        command.Parameters.AddWithValue("@product_name", cart.product_name);
                        command.Parameters.AddWithValue("@quantity", cart.quantity);
                        command.Parameters.AddWithValue("@location", cart.location);
                        command.Parameters.AddWithValue("@unit_price", cart.unit_price);
                        command.Parameters.AddWithValue("@unit_discount", cart.unit_discount);
                        command.Parameters.AddWithValue("@total", ((cart.unit_price - cart.unit_discount) * cart.quantity));


                        int response = service.execute(command);
                        return response;

                    }
                }
                else
                {
                    return -1;
                }
            }
        }
        public int addUser(User user)
        {
            SSGetService getService = new SSGetService();

            User numberCheck = getService.getUserByMobileNumber(user.mobile_number);
            User usernameCheck = getService.getUserByUsername(user.username);

            if (usernameCheck.username == null)
            {
                if (numberCheck.mobile_number == null)
                {

                    using (SqlCommand command = new SqlCommand("INSERT INTO ss_users(bid,name, username, password, mobile_number,picture)VALUES(@bid,@name,@username,@password, @mobile_number,@picture)"))
                    {
                        command.Parameters.AddWithValue("@bid", user.bid);
                        command.Parameters.AddWithValue("@name", user.name);
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@password", user.password);
                        command.Parameters.AddWithValue("@mobile_number", user.mobile_number);
                        if (user.picture != null)
                            command.Parameters.Add("@picture", SqlDbType.Image, user.picture.Length).Value = user.picture;


                        int response = service.execute(command);
                        if (response > 0)
                            this.addLog(new Log()
                            {
                                type = "Add User",
                                statement = command.CommandText,
                                description = "Created user " + user.name,

                            });

                        return response;

                    }
                }
                else
                {
                    return -3;
                }
            }
            else
            {
                return -2;
            }
        }

        public int addVoucherCategory(VoucherCategory category)
        {
            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            VoucherCategory existingCategory = getService.getVoucherByName(category.name);
            if (existingCategory.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_voucher_categories(name)VALUES(@name)"))
                {
                    command.Parameters.AddWithValue("@name", category.name);
                    int response = service.execute(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Voucher Category",
                            statement = command.CommandText,
                            description = "Created voucher category " + existingCategory.name,

                        });

                    return response;

                }
            }
            else
            {
                return -101;
            }
        }
        public int addLocation(Location location)
        {
            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            Location existingLocation = getService.getLocationByCredentials(location);
            if (existingLocation.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_locations(name, type)VALUES(@name,@type)"))
                {
                    command.Parameters.AddWithValue("@name", location.name);
                    command.Parameters.AddWithValue("@type", location.type);
                    int response = service.execute(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Location",
                            statement = command.CommandText,
                            description = "Added new location" + location.name,

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

            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            Product existingProduct = getService.getProductByName(product.name);
            if (existingProduct.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_products(name,price,reorder_level,barqr_code)VALUES(@name,@price,@reorder_level,@barqr_code)"))
                {
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@reorder_level", product.reorder_level);
                    command.Parameters.AddWithValue("@barqr_code", product.barqr_code);

                    int response = service.execute(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Product",
                            statement = command.CommandText,
                            description = "Added new Product" + product.name,

                        });
                    return response;
                }
            }
            else
            {
                return -2;
            }


        }

        public int addBank(Bank bank)
        {

            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            Bank existingbank = getService.getBankByName(bank.name);
            if (existingbank.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_banks(name)VALUES(@name)"))
                {
                    command.Parameters.AddWithValue("@name", bank.name);

                    int response = service.execute(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Bank",
                            statement = command.CommandText,
                            description = "Added new Bank" + bank.name,

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


        public int addBusiness(Business business)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();
            SSRemoteService remoteService = new SSRemoteService();
            SSUpdateService updateService = new SSUpdateService();
           
            //Business existingBusiness = getService.getBusinessByName(business.business_name);
            //if (existingBusiness.name == null)
            //{

            //    Key key = remoteService.getProductKey(business.product_key);
            //    if (key.product_key != null)
            //    {
            //        if (key.status == "PA")
            //        {
                        business.status = "AC";
                        //update remote productKet status

                        //done

                        using (SqlCommand command = new SqlCommand("INSERT INTO ss_business(name,motto,address,telephone,email_address,product_key,machine_name,status,logo)VALUES(@name,@motto,@address,@telephone,@email_address,@product_key,@machine_name,@status,@logo)"))
                        {

                
                             command.Parameters.AddWithValue("@name", business.business_name);
                            command.Parameters.AddWithValue("@motto", business.motto.ToString().ToUpper());
                            command.Parameters.AddWithValue("@address", business.address);
                            command.Parameters.AddWithValue("@telephone", business.telephone);
                            command.Parameters.AddWithValue("@email_address", business.email_address);
                            command.Parameters.AddWithValue("@product_key", business.product_key);
                             command.Parameters.AddWithValue("@machine_name", business.machine_name);
                            command.Parameters.AddWithValue("@status", business.status);
                            if(business.logo!=null)
                            command.Parameters.Add("@logo", SqlDbType.Image, business.logo.Length).Value = business.logo;
               
                            int response1 = service.execute(command);
                            int response2 = 1; //service.remoteExecute(command);
                            if (response1 > 0 && response2 > 0)
                            {

                                Business currentBusiness = getService.getBusinessByName(business.business_name);
                                if (currentBusiness.business_name != null)
                                {
                                    //register admin user


                                    User user = new User()
                                    {
                                        bid=currentBusiness.id,
                                        name = business.name,
                                        username = business.username,
                                        password = business.password,
                                        mobile_number = business.telephone,
                                        role = "All",

                                    };
                                    if (business.logo != null)
                                        user.picture = business.logo;


                            int res = addService.addUser(user);
                                    if (res > 0)
                                    {
                                        this.addLog(new Log()
                                        {
                                            type = "Add Business",
                                            statement = command.CommandText,
                                            description = "Added Business" + business.business_name,

                                        });
                                        return res;
                                    }
                                    else
                                    {
                                        return -1;
                                    }
                                }
                                else
                                {
                                    return -2;
                                }
                            }
                            else
                            {
                                return -3;
                            }
                        }
            //        }
            //        else
            //        {
            //            return 201;
            //        }
            //    }
            //    else
            //    {
            //        return -404;
            //    }
            //}
            //else
            //{
            //    return -200;
            //}

        }

        public int addCustomerGroup(Group group)
        {

            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            Group existingGroup = getService.getGroupByName(group.name);
            if (existingGroup.name == null)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ss_customer_groups(name)VALUES(@name)"))
                {
                    command.Parameters.AddWithValue("@name", group.name);

                    int response = service.execute(command);
                    if (response > 0)
                        this.addLog(new Log()
                        {
                            type = "Add Group",
                            statement = command.CommandText,
                            description = "Added new Group" + group.name,

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

            using (SqlCommand command = new SqlCommand("INSERT INTO ss_customers(name,address,phone_number,altphone_number,credit_limit,account_balance,customer_group)VALUES(@name,@address,@phone_number,@altphone_number,@credit_limit,@account_balance,@customer_group)"))
            {

                command.Parameters.AddWithValue("@name", customer.name);
                command.Parameters.AddWithValue("@address", customer.address);
                command.Parameters.AddWithValue("@phone_number", customer.phone_number);
                command.Parameters.AddWithValue("@altphone_number", customer.altphone_number);
                command.Parameters.AddWithValue("@credit_limit", customer.credit_limit);
                command.Parameters.AddWithValue("@account_balance", 0);
                command.Parameters.AddWithValue("@customer_group", customer.customer_group);

                int response = service.execute(command);
                if (response > 0)
                    this.addLog(new Log()
                    {
                        type = "Add Customer",
                        statement = command.CommandText,
                        description = "Added new customer" + customer.name,

                    });
                return response;
            }

        }

        public int addStock(Stock stock)
        {
            SSGetService getService = new SSGetService();
            SSUpdateService updateService = new SSUpdateService();

            Product existingProduct = getService.getProductByName(stock.name);

            if (existingProduct.name != null)
            {
                Location existingLocation = getService.getLocationByName(stock.location);
                if (existingLocation.name != null)
                {

                    string batchName;
                    string batchFormat = DateTime.Now.ToString("MMyyyy");
                    DataTable batchData = getService.getDataWithFilter(app.objects["batches"]," name like '%"+batchFormat+"' order by created_date desc");
                    if (batchData.Rows.Count > 0)
                    {
                        DataRow row = batchData.Rows[0];
                        string name = row.Field<string>("name");
                        string val = name.Substring(name.IndexOf('B') + 1, name.IndexOf('-') - 1);
                        if (app.isAllDigits(val))
                            batchName = "B"+(int.Parse(val) + 1) +"-"+ batchFormat;
                        else
                            batchName = "";
                    }
                    else
                    {
                        batchName = "B1-" + batchFormat;
                    }
                    string batchKey = app.generateId(20);

                    if (batchName != null && batchName!="")
                    {
                        using (SqlCommand batchCommand = new SqlCommand("INSERT INTO ss_batches(name,reference_key,pid,total,balance,sold)VALUES(@name,@reference_key,@pid,@total,@balance,@sold)"))
                        {
                            batchCommand.Parameters.AddWithValue("@name", batchName);
                            batchCommand.Parameters.AddWithValue("@reference_key", batchKey);
                            batchCommand.Parameters.AddWithValue("@pid", existingProduct.id);
                            batchCommand.Parameters.AddWithValue("@total", stock.quantity);
                            batchCommand.Parameters.AddWithValue("@balance", stock.quantity);
                            batchCommand.Parameters.AddWithValue("@sold", 0);

                            int batchResponse = service.execute(batchCommand);
                            if (batchResponse > 0)
                            {
                                Batch batch = getService.getBatchByKey(batchKey);
                                if (batch.key != null)
                                {

                                    using (SqlCommand command = new SqlCommand("INSERT INTO ss_stocks(pid,bid,quantity,cost,description,last_modified_date)VALUES(@pid,@bid,@quantity,@cost,@description, getdate())"))
                                    {
                                        command.Parameters.AddWithValue("@pid", existingProduct.id);
                                        command.Parameters.AddWithValue("@bid", batch.id);
                                        command.Parameters.AddWithValue("@quantity", stock.quantity);
                                        command.Parameters.AddWithValue("@cost", stock.cost);
                                        command.Parameters.AddWithValue("@description", stock.description);
                                        int response = service.execute(command);
                                        if (response > 0)
                                        {
                                            return response;
                                        }
                                        else
                                        {
                                            return -1;
                                        }
                                    }
                                }
                                else
                                {
                                    return -1;

                                }

                            }
                            else
                            {
                                return -402;
                            }
                        }
                    }
                    else
                    {
                        return -500;
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
        }
    }
}

    

