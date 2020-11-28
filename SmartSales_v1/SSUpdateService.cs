using System;
using System.Data.SqlClient;

namespace SmartSales_v1
{
    class SSUpdateService
    {
        App app = new App();
        SSService service = new SSService();
    

        public int updateLastLoginDate(User user)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();


            using (SqlCommand command = new SqlCommand("UPDATE ss_users SET login_date=CURRENT_TIMESTAMP WHERE id=" + user.id + ""))
                {
                    int response = service.execute(command);
                    addService.addLog(new Log()
                    {
                        type = "User logged in",
                        statement = user.username,
                        description = "User logged in " + user.name,
                       
                    });
                  return response;
                }
          
        }

        public int manageWalletBalance(Payment payment)
        {
            SSGetService getService = new SSGetService();
       
            Customer customer = getService.getCustomerByName(payment.customer_name);
            if (customer.name != null)
            {
                if (payment.payment_mode == "Credit")
                    customer.account_balance += payment.transaction_amount;
                else if (payment.payment_mode == "Debit")
                    customer.account_balance -= payment.transaction_amount;
                else
                    customer.account_balance = 0;

               return  this.updateCustomerBalance(customer);
            }
            else
            {
                return -404;
            }
        }
        public int updatePrice(Product product)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();

            Product existingProduct = getService.getProductByName(product.name);
            if (existingProduct.name != null)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ss_products SET price=@price WHERE id="+existingProduct.id+""))
                {
                    command.Parameters.AddWithValue("@price", product.price);
                    int response = service.execute(command);
                    if (response > 0)
                        addService.addLog(new Log()
                        {
                            type = "Updated Price",
                            statement = command.CommandText,
                            description = "Updated [" + existingProduct.id + "] Product",
                            
                        });
                    return response;
                }
            }
            else
            {
                return -404;
            }
        }

        public int updateCost(Batch batch)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();

            Batch existingBatch = getService.getBatchByName(batch.name);
            if (existingBatch.name != null)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ss_stocks SET cost=@cost WHERE bid=" + existingBatch.id + ""))
                {
                    command.Parameters.AddWithValue("@cost", batch.cost);
                    int response = service.execute(command);
                    if (response > 0)
                        addService.addLog(new Log()
                        {
                            type = "Updated Cost",
                            statement = command.CommandText,
                            description = "Updated [" + existingBatch.id + "] Batch",

                        });
                    return response;
                }
            }
            else
            {
                return -404;
            }
        }
        public int updateCustomerBalance(Customer customer)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();

            Customer existingCustomer = getService.getCustomerById(customer.id);
            if (existingCustomer.name != null)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ss_customers SET account_balance=@balance, last_modified_date=getdate() WHERE id=" + existingCustomer.id + ""))
                {
                    command.Parameters.AddWithValue("@balance", customer.account_balance);
                    int response = service.execute(command);
                    if (response > 0)
                        addService.addLog(new Log()
                        {
                            type = "Updated customer balance",
                            statement = command.CommandText,
                            description = "Updated [" + existingCustomer.id + "] Customer",

                        });
                    return response;
                }
            }
            else
            {
                return -404;
            }
        }
        public int updateDebtorBalance(Debtor debtor)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();

            Debtor existingDebtor = getService.getDebtorByIdEvenIfZero(debtor.cid);
            if (existingDebtor.name != null)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ss_debtors SET amount=@balance,last_modified_date=getdate() WHERE cid=" + existingDebtor.cid + ""))
                {
                    command.Parameters.AddWithValue("@balance", debtor.amount);
                    int response = service.execute(command);
                    if (response > 0)
                        addService.addLog(new Log()
                        {
                            type = "Updated customer debit balance to "+debtor.amount,
                            statement = command.CommandText,
                            description = "Updated [" + existingDebtor.cid + "] Debit Amount",

                        });
                    return response;
                }
            }
            else
            {
                return -404;
            }
        }

        public int updateBatchBalance(Batch batch)
        {
            SSGetService getService = new SSGetService();
            SSAddService addService = new SSAddService();

            using (SqlCommand command = new SqlCommand("UPDATE ss_batches SET balance=@balance, sold=@sold WHERE id=" + batch.id + ""))
                {
                    command.Parameters.AddWithValue("@balance", batch.balance);
                    command.Parameters.AddWithValue("@sold", batch.sold);
                int response = service.execute(command);
                    if (response > 0)
                        addService.addLog(new Log()
                        {
                            type = "Updated batch  balance",
                            statement = command.CommandText,
                            description = "Updated [" + batch.id + "] Batch",

                        });
                    return response;
                }
        }
        public int updateCartProductBatch(Batch batch, int pid)
        {
            using (SqlCommand command = new SqlCommand("UPDATE ss_cart SET bid=@bid WHERE pid=" + pid + ""))
            {
                command.Parameters.AddWithValue("@bid", batch.id);
                int response = service.execute(command);
                return response;
            }
        }
    }
}
