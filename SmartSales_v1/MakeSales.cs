using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace SmartSales_v1
{
    public partial class MakeSales : Form
    {
        public Point mouseLocation;
        public int pressCounter = 0;
        Hint h = new Hint();
        App app = new App();
        SSGetService getService = new SSGetService();
        SSAddService addService = new SSAddService();
        SSDeletionSerice delService = new SSDeletionSerice();
        SSUpdateService updateService = new SSUpdateService();

        public MakeSales()
        {
            InitializeComponent();
            InitializeDropdown();
            refreshCart();
        }

        private void InitializeDropdown()
        {

            DataTable data = getService.getDataFrom(app.objects["banks"]);
            if (data.Rows.Count > 0)
                foreach (DataRow row in data.Rows)
                    bankListDropdown.Items.Add(row.Field<string>("name"));

            DataTable locations = getService.getDataFrom(app.objects["locations"]);
            if (locations.Rows.Count > 0)
                foreach (DataRow row in locations.Rows)
                   locationDropdown.Items.Add(row.Field<string>("name"));
        }

        private  void onProductSelected(string search)
        {
            Product product = new Product();
            List<Batch> stockBatches = new List<Batch>();
            int availableQuantity = 0;
            int reqQuantity = 0;
            pressCounter = 0;
            processButton.Text = "Process";

            DataTable productData = getService.getDataWithFilter(app.objects["products"], "name='"+ search + "'");
            if (productData.Rows.Count > 0)
            {

                if (quantityField.Text != null && quantityField.Text != "" && quantityField.Text != "Quantity")
                    reqQuantity = app.toDecimalOf(quantityField.Text);

                DataRow productRow = productData.Rows[0];
                product.id = productRow.Field<int>("id");
                product.name = productRow.Field<string>("name");
                product.price = productRow.Field<int>("price");
                product.barqr_code = productRow.Field<string>("barqr_code");

                DataTable stockData =  getService.getDataWithFilter(app.objects["batches"], "pid="+product.id+ " and balance>0 order by created_date asc");
                if (stockData.Rows.Count > 0)
                {

                    foreach (DataRow batchRow in stockData.Rows)
                    {
                        availableQuantity = availableQuantity + batchRow.Field<int>("balance");
                        stockBatches.Add(new Batch() {
                            id = batchRow.Field<int>("id"),
                            name = batchRow.Field<string>("name"),
                            pid = batchRow.Field<int>("pid"),
                            total = batchRow.Field<int>("total"),
                            balance = batchRow.Field<int>("balance"),
                        }); ;
                    }

                    if (reqQuantity <= availableQuantity)
                    {

                        unitPricefield.Text = app.toMoneyOf(product.price);
                        selectedProductNameField.Text = product.name;
                        cumulativeBatchBalance.Text = app.toMoneyOf(availableQuantity);
                        activeBatchqunatityBalanceField.Text = app.toMoneyOf(stockBatches[0].balance);
                        DataTable stuckData = getService.getDataWithFilter(app.objects["stocks"], "bid='"+ stockBatches[0].id+"' order by created_date asc");
                        if (stuckData.Rows.Count > 0)
                            unitCostField.Text = app.toMoneyOf(stuckData.Rows[0].Field<int>("cost"));
                   
                    
                    }
                    else
                    {
                        app.showWarning("The requeted Quantity is not availble, the remaining is " + availableQuantity.ToString());
                    }

                }
                else
                {
                    app.showWarning(product.name+" is out of stock!");
                }


            }

        }

        private void onPrepareSelectedProduct()
        {
            int unitPrice, unitDiscount, quantity;
            unitPrice = unitDiscount = quantity = 0;
            pressCounter = 0;
            processButton.Text = "Process";

    
            if (unitDiscountfield.Text != "" && unitDiscountfield.Text != "Unit Discount")
                unitDiscount = app.toDecimalOf(unitDiscountfield.Text);
            if (unitPricefield.Text != "" && unitPricefield.Text != "Unit Price")
                unitPrice = app.toDecimalOf(unitPricefield.Text);
            if (quantityField.Text != ""  && quantityField.Text != "Quantity")
                quantity = app.toDecimalOf(quantityField.Text);

            User user = app.getSession();
            Cart cart = new Cart()
            {
                user_id = user.id == 0 ? 1 : user.id,
                product_name = productNameField.Text,
                location = locationDropdown.Text,
                quantity =  quantity,
                unit_price =unitPrice,
                unit_discount = unitDiscount,
            };


            if (locationDropdown.Text == "" || locationDropdown.Text == "Select Location" || locationDropdown.Text == null)
                app.notifyTo(statusLabel, "Select the product location!", "warning");
            else if (quantityField.Text == "" || quantityField.Text == "Qunatity" ||  quantityField.Text == null)
                app.notifyTo(statusLabel, "Enter the product quantity!", "warning");
            else if (cart.product_name == "" || quantityField.Text == "Prodcut Name" || productNameField.Text == null)
                app.notifyTo(statusLabel, "Enter the product name!", "warning");
            else if (unitPricefield.Text == "" || quantityField.Text == "Unit Price" || unitPricefield.Text == null)
                app.notifyTo(statusLabel, "The unit price not avaialble!", "warning");
            else {

                if (cart.product_name != "" && quantityField.Text != ""  && unitPricefield.Text != "" && locationDropdown.Text!="" && cart.product_name != "Product Name" && quantityField.Text != "Quantity" && unitPricefield.Text != "Unit Price" && locationDropdown.Text!="Select Location")
                {

                    DataTable currentProduct = getService.getDataWithFilter(app.objects["products"], "name='" +cart.product_name +"'");
                    if (currentProduct.Rows.Count > 0)
                    {
                        //finding the currect product id and setting as selected
                        cart.pid = currentProduct.Rows[0].Field<int>("id");


                        DataTable data = getService.getDataWithFilter(app.objects["cart"], "user_id=" + cart.user_id + " and product_name='" + cart.product_name + "'");
                        if (data.Rows.Count > 0)
                        {
                            DialogResult result = MessageBox.Show(cart.product_name + " already selected, do you want to replace it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                int response = addService.replaceCart(cart);
                                if (response > 0)
                                {
                                
                                    this.refreshCart();
                                    app.notifyTo(statusLabel, "Updated Successfully", "success");
                                }
                                else
                                {
                                    app.notifyTo(statusLabel, "Unable to update the cart", "success");
                                }
                            }
                        }
                        else
                        {
                            int response = addService.addToCart(cart);
                            if (response > 0)
                            {
                                this.refreshCart();
                
                            }
                            else
                            {
                                app.notifyTo(statusLabel, "Unable to add data to the cart", "success");
                            }

                        }
                    }
                    else
                    {
                        app.showWarning("The selected product is no longer availble");
                    }
                }
            }
        }

        private void refreshCart()
        {
            try
            {
                User user = app.getSession();
                DataTable cartData = getService.getCartData(user);
                pressCounter = 0;
                processButton.Text = "Process";


                if (cartData.Rows.Count > 0)
                {
                    cartGridView.Rows.Clear();
                    int totalPayable = 0;

                    for (int i = 0; i < cartData.Rows.Count; i++)
                    {

                        DataRow row = cartData.Rows[i];
                        int price = row.Field<int>("unit_price");
                        int discount = row.Field<int>("unit_discount");

                        if (discount > 0)
                            price = price - discount;


                        Cart cart = new Cart()
                        {
                            quantity = row.Field<int>("quantity"),
                            product_name = row.Field<string>("product_name"),
                            unit_price = price,
                            unit_discount = discount,
                            location = row.Field<string>("location"),
                        };

                        cartGridView.AllowUserToAddRows = true;
                        cartGridView.Rows.Add(1);
                      

                        cartGridView.Rows[i].Cells[0].Value = app.toMoneyOf(cart.quantity);
                        cartGridView.Rows[i].Cells[1].Value = cart.product_name;
                        cartGridView.Rows[i].Cells[2].Value = app.toMoneyOf(cart.unit_price);
                        cartGridView.Rows[i].Cells[3].Value = app.toMoneyOf((cart.unit_price * cart.quantity));

                        totalPayable = totalPayable + (cart.unit_price * cart.quantity);
                        totalPayableAmountField.Text =app.toMoneyOf( totalPayable);

                        quantityField.Text = "Quantity";
                        productNameField.Text = "Product Name";
                        unitPricefield.Text = "Unit Price";
                        unitDiscountfield.Text = "Unit Discount";


                        selectedProductNameField.Text = "Selected Product";
                        activeBatchqunatityBalanceField.Clear();
                        cumulativeBatchBalance.Clear();
                        unitCostField.Clear();

                    }
                }
                else
                {
                    cartGridView.Rows.Clear();
                }
            }catch (Exception ex)
            {
                app.showWarning(ex.Message);
            } 

        }

        private void processTransaction()
        {
            if (customerNamefield.Text == "" || customerNamefield.Text == "Customer Name")
                app.notifyTo(statusLabel, "Enter the customer name!", "error");
         
            if (locationDropdown.Text == "" || locationDropdown.Text == "Select Location")
                app.notifyTo(statusLabel, "Enter the customer name!", "error");

            if (totalPayableAmountField.Text == "" || totalPayableAmountField.Text == "000,000,000")
                app.notifyTo(statusLabel, "Total amount can't be Zero!", "error");

            if (paymentMethodDropdown.Text == "" || paymentMethodDropdown.Text == "Payment Method")
                app.notifyTo(statusLabel, "Please select payment method", "error");


            if (customerNamefield.Text != "" && customerNamefield.Text != "Customer Name" && locationDropdown.Text != "" && locationDropdown.Text != "Select Location"
                && totalPayableAmountField.Text != "" && totalPayableAmountField.Text != "000,000,000" && paymentMethodDropdown.Text != "" && paymentMethodDropdown.Text != "Payment Method")
            {
                int amount, payable, balance, deposit, discount;
                payable = balance = amount = deposit = discount = 0;
                int partPyament = 0;
                bool isProcessed = false;


                int itemCount = 0;
                string productsList = "";
                string bankName = "";

                statusLabel.Text = "";
                pressCounter = pressCounter + 1;


                //check if bank not selected make it null
                if (bankListDropdown.Text != "Select Bank" && bankListDropdown.Text != "")
                    bankName = bankListDropdown.Text;

                //preparing part payment
                if (partPaymentLabel.Text == "Part Payment" && app.isAllDigits(partPaymentField.Text))
                    partPyament = app.toDecimalOf(partPaymentField.Text);

                //getting user information
                User user = app.getSession();
                DataTable cartData = getService.getCartData(user);
                if (cartData.Rows.Count > 0)
                {

                    //adding product list to variable
                    foreach (DataRow row in cartData.Rows)
                    {
                        int pid = row.Field<int>("id");
                        productsList += pid + "|";
                        itemCount = itemCount + 1;
                    }

                    if (productsList.EndsWith("|"))
                        productsList = productsList.Substring(0, productsList.Length - 1);

                    if (totalPayableAmountField.Text != "000,000,000" && totalPayableAmountField.Text != "" && totalPayableAmountField.Text != null)
                        amount = app.toDecimalOf(totalPayableAmountField.Text);

                    if (generalDiscountField.Text != "Discount" && generalDiscountField.Text != "")
                        discount = app.toDecimalOf(generalDiscountField.Text);


                    foreach (DataRow row in cartData.Rows)
                    {
                        int availableQuantity = 0;
                        int pid = row.Field<int>("pid");
                        int reqQuantity = row.Field<int>("quantity");
                        string productName = row.Field<string>("product_name");
                        int wipQuantity = reqQuantity;
                        List<Batch> stockBatches = new List<Batch>();

                        DataTable stockData = getService.getDataWithFilter(app.objects["batches"], "pid=" + pid + " and balance>0 order by created_date asc");
                        if (stockData.Rows.Count > 0)
                        {
                            //get the total quantity available in each batch
                            foreach (DataRow batchRow in stockData.Rows)
                                availableQuantity = availableQuantity + batchRow.Field<int>("balance");

                            if (availableQuantity >= reqQuantity)
                            {

                                //set batches to batch model
                                foreach (DataRow batchRow in stockData.Rows)
                                {
                                    stockBatches.Add(new Batch()
                                    {
                                        id = batchRow.Field<int>("id"),
                                        name = batchRow.Field<string>("name"),
                                        pid = batchRow.Field<int>("pid"),
                                        total = batchRow.Field<int>("total"),
                                        balance = batchRow.Field<int>("balance"),
                                    });
                                }


                                // manage batches
                                foreach (Batch batch in stockBatches)
                                {

                                    if (reqQuantity <= batch.balance)
                                    {
                                        batch.balance = (batch.balance - reqQuantity);
                                        batch.sold = reqQuantity;
                                        if (pressCounter > 1)
                                        {
                                            updateService.updateBatchBalance(batch);
                                            updateService.updateCartProductBatch(batch, pid);
                                            
                                        }
                                        isProcessed = true;
                                        break;
                                    }
                                    else
                                    {
                                        if (wipQuantity >= batch.balance)
                                        {
                                            wipQuantity = wipQuantity - batch.balance;
                                            batch.balance = 0;
                                            batch.sold = batch.balance;
                                            if (pressCounter > 1)
                                            {
                                                updateService.updateBatchBalance(batch);
                                                updateService.updateCartProductBatch(batch, pid);
                                            }
                                        }
                                        else
                                        {
                                            batch.balance = batch.balance - wipQuantity;
                                            batch.sold = wipQuantity;
                                            wipQuantity = 0;
                                            if (pressCounter > 1)
                                            {
                                                updateService.updateBatchBalance(batch);
                                                updateService.updateCartProductBatch(batch, pid);
                                            }

                                        }
                                        if (wipQuantity <= 0)
                                        {
                                            isProcessed = true;
                                            break;
                                        }
                                    }
                                }

                            }
                            else
                            {
                                app.showWarning("Oops! " + productName + " is no longer available");
                            }
                        }
                    }

                    if (isProcessed)
                    {


                        int customerId = -1;
                        int customerOpeningBalance = 0;
                        int paymentAmount = 0;
                        DataTable customerData = getService.getDataWithFilter(app.objects["customers"], "name='" + customerNamefield.Text + "'");
                        Sale currentSale = new Sale();
                        Customer customer= new Customer();

                        //get customer of exist or set -1 if not exist
                        if (customerData.Rows.Count > 0)
                        {
                            DataRow row = customerData.Rows[0];
                            customer = new Customer()
                            {
                                id = row.Field<int>("id"),
                                name = row.Field<string>("name"),
                                credit_limit = row.Field<int>("credit_limit"),
                                account_balance = row.Field<int>("account_balance"),
                            };

                            customerOpeningBalance = customer.account_balance;
                            customerId = customer.id;
                        }
                        else
                        {
                            customer.id = customerId;
                        }


                        if (paymentMethodDropdown.Text == "Cash" || paymentMethodDropdown.Text == "Bank")
                        {
                                payable = amount;
                                balance = 0;
                                payable = (payable - discount);
                                paymentAmount = payable;

                                currentSale = new Sale()
                                {
                                    cid = customerId,
                                    customer_name = customerNamefield.Text,
                                    products = productsList,
                                    product_location = locationDropdown.Text,
                                    item_count= itemCount,
                                    total = payable,
                                    discount = discount,
                                    outstanding_balance = balance,
                                    cleared_amount = (amount - discount),
                                    payment_method = paymentMethodDropdown.Text,
                                    part_payment = partPyament,
                                    bank_name = bankListDropdown.Text,
                                };
                        }
                        else if (paymentMethodDropdown.Text == "Credit")
                        {
                            if (customer.id!=-1)
                            {
                                if (partPaymentField.Text != "" && partPaymentField.Text != "0")
                                    deposit =int.Parse(partPaymentField.Text);

                                payable = amount - discount;
                                balance = payable - deposit;
                                paymentAmount = deposit;
                             
                                currentSale = new Sale()
                                {
                                    cid = customerId,
                                    customer_name = customerNamefield.Text,
                                    products = productsList,
                                    product_location = locationDropdown.Text,
                                    item_count= itemCount,
                                    total = payable,
                                    discount = discount,
                                    outstanding_balance = balance,
                                    cleared_amount = deposit,
                                    payment_method = paymentMethodDropdown.Text,
                                    part_payment = deposit,
                                    bank_name = bankListDropdown.Text,
                                };
                            }
                            else
                            {
                                app.showWarning("The Customer " + customerNamefield.Text + " is not a regular customer");
                            }
                        }
                        else if (paymentMethodDropdown.Text == "Wallet")
                        {


                            if (partPaymentField.Text != "" && partPaymentField.Text != "0")
                                deposit = int.Parse(partPaymentField.Text);


                            if (customer.id != -1)
                            {

                                if (partPaymentField.Text != "" && partPaymentField.Text != "0")
                                    deposit = int.Parse(partPaymentField.Text);


                                if (customer.account_balance >= (amount - discount))
                                {
                                    payable = 0;
                                    balance = 0;
                                    customer.account_balance = (customer.account_balance - (amount - discount));
                                    paymentAmount = (amount - discount);
                                }
                                else if (customer.account_balance > 0 && customer.account_balance < amount)
                                {
                                    payable = (amount - discount);
                                    balance = payable - customer.account_balance;
                                    customer.account_balance = (customer.account_balance - payable);
                                    paymentAmount = customer.account_balance;
                                }
                                else
                                {
                                    payable = (amount - discount);
                                    balance = payable;
                                    customer.account_balance = customerOpeningBalance;
                                }
                            }
                            else
                            {
                                payable = (amount - discount);
                                balance = payable;
                            }

                            currentSale = new Sale()
                            {
                                cid = customerId,
                                customer_name = customerNamefield.Text,
                                products = productsList,
                                product_location = locationDropdown.Text,
                                item_count= itemCount,
                                total = payable,
                                discount = discount,
                                outstanding_balance = balance,
                                cleared_amount = deposit,
                                payment_method = paymentMethodDropdown.Text,
                                part_payment = deposit,
                                bank_name = bankListDropdown.Text,
                            };
                        }
                        totalToPayField.Text = app.toMoneyOf(payable);
                        balanceField.Text = app.toMoneyOf(balance);

                        if (pressCounter > 1)
                        {

                            if (paymentMethodDropdown.Text == "Wallet")
                            {

                                if (customer.id != -1)
                                {
                                    if (customerOpeningBalance - (amount - discount) >= 0)
                                    {
                                        if (customerOpeningBalance >= (amount - discount))
                                        {

                                            if (customerOpeningBalance >= customer.account_balance)
                                            {
                                                processButton.Enabled = false;
                                                updateService.updateCustomerBalance(customer);
                                                int response = addService.addSale(currentSale);
                                                if (response > 0)
                                                {
                                                    Customer currentCustomer = getService.getCustomerByName(customerNamefield.Text);
                                                    Sale lastSale = getService.getLastPurchase(user.id, customerNamefield.Text);
                                                    Report report = new Report(currentCustomer.id, lastSale.id, "#invoice");
                                                    report.ShowDialog();
                                                    this.clearCart();
                                                }
                                                else if (response == -404)
                                                    app.showWarning("No items in your cart");
                                                else
                                                    app.showWarning("Oops! Transaction failed");

                                                processButton.Enabled = true;
                                            }
                                            else
                                            {
                                                app.showWarning("Oops! Unable to deduct " + (amount - discount) + " from the customer account");
                                            }

                                        }
                                        else
                                        {
                                            app.showWarning("Insufficient funds, the customer balance is " + customer.account_balance + " and the payable amount is " + (amount - discount) + "!");
                                        }
                                    }
                                    else
                                    {
                                        app.showWarning("Oops! Credit limit exceeded, the remaining balance of " + customerNamefield.Text + " is " + customerOpeningBalance + " and the current payable amount is " + (amount - discount) + "");
                                    }
                                }
                                else
                                {
                                    app.showWarning("The Customer " + customerNamefield.Text + " is not a regular customer");

                                }

                            }
                            else if (paymentMethodDropdown.Text == "Credit")
                            {

                                if (customer.credit_limit >= currentSale.outstanding_balance)
                                {

                                    processButton.Enabled = false;
                                    int response = addService.addSale(currentSale);

                                    processButton.Enabled = true;
                                    if (response > 0)
                                    {

                                        if (paymentAmount > 0)
                                        {
                                            Payment payment = new Payment()
                                            {
                                                customer_name = currentSale.customer_name,
                                                transaction_amount = paymentAmount,
                                                payment_mode = currentSale.payment_method,
                                                description = "Purchasing Payment",
                                                transaction_type = "Payment",
                                            };

                                            //adding payment for each transaction
                                            int res = addService.addPayment(payment);
                                            if (res > 0)
                                            {
                                                Customer currentCustomer = getService.getCustomerByName(customerNamefield.Text);
                                                Sale lastSale = getService.getLastPurchase(user.id, customerNamefield.Text);
                                                Report report = new Report(currentCustomer.id, lastSale.id, "#invoice");
                                                report.ShowDialog();
                                                this.clearCart();

                                            }
                                            else
                                            {
                                                if (res == -404)
                                                {
                                                    app.notifyTo(statusLabel, "The customer " + customerNamefield.Text + " is  not found", "warning");
                                                }
                                                else if (res == -202)
                                                {
                                                    app.showWarning("The customer " + payment.customer_name + " is not Owing!");
                                                }
                                                else
                                                {
                                                    app.notifyTo(statusLabel, "Transaction failed, please try latter ", "warning");
                                                }
                                            }
                                        }
                                        else
                                        {

                                            Customer currentCustomer = getService.getCustomerByName(customerNamefield.Text);
                                            Sale lastSale = getService.getLastPurchase(user.id, customerNamefield.Text);
                                            Report report = new Report(currentCustomer.id, lastSale.id, "#invoice");
                                            report.ShowDialog();
                                            this.clearCart();
                                        }

                                    }
                                    else if (response == -404)
                                        app.showWarning("No items in your cart");
                                    else
                                        app.showWarning("Oops! Transaction failed");

                                }
                                else
                                {
                                    app.showWarning("Oops! The customer credit limit is not up to the current outstanding balance, credit limit is "+customer.credit_limit+" and the debt is "+currentSale.outstanding_balance+".");
                                }

                            }
                            else
                            {


                                processButton.Enabled = false;
                                int response = addService.addSale(currentSale);

                                processButton.Enabled = true;
                                if (response > 0)
                                {

                                    if (paymentAmount > 0)
                                    {
                                        Payment payment = new Payment()
                                        {
                                            customer_name = currentSale.customer_name,
                                            transaction_amount = paymentAmount,
                                            payment_mode = currentSale.payment_method,
                                            description = "Purchasing Payment",
                                            transaction_type = "Payment",
                                        };

                                        //adding payment for each transaction
                                        int res = addService.addPayment(payment);
                                        if (res > 0)
                                        {
                                            Customer currentCustomer = getService.getCustomerByName(customerNamefield.Text);
                                            Sale lastSale = getService.getLastPurchase(user.id, customerNamefield.Text);
                                            Report report = new Report(currentCustomer.id, lastSale.id, "#invoice");
                                            report.ShowDialog();
                                            this.clearCart();

                                        }
                                        else
                                        {
                                            if (res == -404)
                                            {
                                                app.notifyTo(statusLabel, "The customer " + customerNamefield.Text + " is  not found", "warning");
                                            }
                                            else if (res == -202)
                                            {
                                                app.showWarning("The customer " + payment.customer_name + " is not Owing!");
                                            }
                                            else
                                            {
                                                app.notifyTo(statusLabel, "Transaction failed, please try latter ", "warning");
                                            }
                                        }
                                    }
                                    else
                                    {

                                        Customer currentCustomer = getService.getCustomerByName(customerNamefield.Text);
                                        Sale lastSale = getService.getLastPurchase(user.id, customerNamefield.Text);
                                        Report report = new Report(currentCustomer.id, lastSale.id, "#invoice");
                                        report.ShowDialog();

                                        this.clearCart();
                                    }
                                }
                                else if (response == -404)
                                    app.showWarning("No items in your cart");
                                else
                                    app.showWarning("Oops! Transaction failed");
                            }

                        }
                        else
                        {
                            processButton.Text = "Continue";
                            pressCounter = 2;
                        }
                    }
                    else
                    {
                        app.showWarning("Oops! Failed to update batch details");
                    }
                }
                else
                {
                    app.showWarning("Oops! No items found in your cart");
                }
            }
        }

        private void  clearCart()
        {
            customerNamefield.Text = "Customer Name";
            locationDropdown.Text = "Select Location";
            quantityField.Text = "Quantity";
            productNameField.Text = "Product Name";
            unitPricefield.Text = "Unit Price";
            unitDiscountfield.Text = "Unit Discount";
            totalPayableAmountField.Text = "000,000,000";
            totalToPayField.Text = "000,000,000";
            balanceField.Text = "000,000,000";
            selectedProductNameField.Text = "Selected Product";
            generalDiscountField.Text = "Discount";
            bankListDropdown.Text = "Select Bank";
            paymentMethodDropdown.Text = "Payment Method";
            partPaymentField.Text = "0";
            partPaymentLabel.Hide();
            partPaymentPanel.Hide();


            activeBatchqunatityBalanceField.Clear();
            cumulativeBatchBalance.Clear();
            unitCostField.Clear();


            User user = app.getSession();
            delService.resetCart(user);

            this.refreshCart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void quantityfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(quantityField, 1, "Quantity");
        }

        private void quantityfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(quantityField, 0, "Quantity");
        }
        private void unitPricefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(unitPricefield, 1, "Unit Price");
        }

        private void unitPricefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(unitPricefield, 0, "Unit Price");
        }

        private void unitDiscountfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(unitDiscountfield, 1, "Unit Discount");
        }

        private void unitDiscountfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(unitDiscountfield, 0, "Unit Discount");
        }

        private void customerNamefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 1, "Customer Name");
        }

        private void customerNamefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 0, "Customer Name");
        }

        private void customerNamefield_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerNamefield.AutoCompleteCustomSource.Add("");

        }
        private void customerNamefield_Enter_1(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 1, "Customer Name");
        }

        private void customerNamefield_Leave_1(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 0, "Customer Name");
        }

        private void paymentMethodDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            pressCounter = 0;

            if (paymentMethodDropdown.Text == "Bank")
            {
                bankListDropdown.Enabled = true;
            }
            else
            {
                bankListDropdown.Enabled = false;
            }
             
            
            if (paymentMethodDropdown.Text == "Credit")
            {
                partPaymentField.Enabled = true;
                partPaymentField.ReadOnly = false;
                partPaymentPanel.Visible = true;
               partPaymentLabel.Text = "Part Payment";
               partPaymentLabel.Show();
            }
            else if (paymentMethodDropdown.Text == "Credit")
            {
                partPaymentField.Text = "0";
                partPaymentField.Enabled = true;
                partPaymentField.ReadOnly = false;
                partPaymentPanel.Visible = true;
                partPaymentLabel.Text = "Part Payment";
                partPaymentLabel.Show();
            }
            else if (paymentMethodDropdown.Text == "Wallet")
            {
                partPaymentField.Enabled = false;
                partPaymentField.ReadOnly = true;
                partPaymentPanel.Visible = true;
                partPaymentLabel.Text = "Wallet Balance";
                partPaymentLabel.Show();

                DataTable data = getService.getDataWithFilter(app.objects["customers"], "name='" + customerNamefield.Text + "'");
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    partPaymentField.Text = row.Field<int>("account_balance").ToString();
                }

            }
            else
            {
                partPaymentField.Enabled = true;
                partPaymentField.ReadOnly = false;
                partPaymentField.Text = "0";
                partPaymentLabel.Hide();
                partPaymentPanel.Hide();
            }
        }
        private void locationField_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(locationDropdown, 1, "Select Location");
        }
        private void locationField_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(locationDropdown, 0, "Select Location");
        }
        private void customerNamefield_TextChanged(object sender, EventArgs e)
        {
            processButton.Text = "Process";
            pressCounter = 0;
            app.buildSalesDropdown(this, sender, customerNamePanel, "customers");

            if (customerNamefield.Text != "" && customerNamefield.Text != "Customer Name")
            {
                if (paymentMethodDropdown.Text == "Wallet")
                {
                    partPaymentField.Enabled = false;
                    partPaymentField.ReadOnly = true;
                    partPaymentPanel.Visible = true;
                    partPaymentLabel.Text = "Wallet Balance";
                    partPaymentLabel.Show();

                    DataTable data = getService.getDataWithFilter(app.objects["customers"], "name='" + customerNamefield.Text + "'");
                    if (data.Rows.Count > 0)
                    {
                        DataRow row = data.Rows[0];
                        partPaymentField.Text = row.Field<int>("account_balance").ToString();
                    }

                }
                else
                {
                    partPaymentField.Enabled = true;
                    partPaymentField.ReadOnly = false;
                    partPaymentField.Text = "0";
                    partPaymentLabel.Hide();
                    partPaymentPanel.Hide();

                }
            }
        }

        private void locationField_TextChanged(object sender, EventArgs e)
        {
            app.buildSalesDropdown(this, sender, locationPanel, "locations");
        }

        private void productNameField_TextChanged(object sender, EventArgs e)
        {
            pressCounter = 0;
            app.buildSalesDropdown(this, sender, productNamePanel, "products");
            this.onProductSelected(productNameField.Text);
        }

        private void productNameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(productNameField, 1, "Product Name");
        }

        private void productNameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(productNameField, 0, "Product Name");
        }

        private void addProductTrigger_Click(object sender, EventArgs e)
        {
            app.open(new UpdateProduct());
        }

        private void quantityField_TextChanged(object sender, EventArgs e)
        {
            pressCounter = 0;
            this.onProductSelected(productNameField.Text);
        }

        private void addToListTrigger_Click(object sender, EventArgs e)
        {
            this.onPrepareSelectedProduct();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (cartGridView.SelectedRows.Count > 0)
            {
                User user = app.getSession();
                int index = cartGridView.SelectedRows[0].Index;
                DataGridViewRow row = cartGridView.Rows[index];
                string productName=row.Cells[1].Value.ToString();
                delService.deleteSelectedCartProduct(user.id,productName);
                this.refreshCart();
            }
        }

        private void clearTrigger_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to reset the cart?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.clearCart();
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
       
            this.processTransaction();
        }

        private void partPaymentField_Enter(object sender, EventArgs e)
        {
            h.manageHint(partPaymentField,1,"0");
        }

        private void partPaymentField_Leave(object sender, EventArgs e)
        {
            h.manageHint(partPaymentField, 0, "0");
        }

        private void generalDiscountField_Enter(object sender, EventArgs e)
        {
            h.manageHint(generalDiscountField, 1, "Discount");
        }

        private void generalDiscountField_Leave(object sender, EventArgs e)
        {
            h.manageHint(generalDiscountField, 0, "Discount");
        }

        private void partPaymentField_TextChanged(object sender, EventArgs e)
        {
            processButton.Text = "Process";
            pressCounter = 0;
        }

        private void addLocationTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddLocation());
        }

        private void generalDiscountField_TextChanged(object sender, EventArgs e)
        {
            processButton.Text = "Process";
            pressCounter = 0;
        }

        private void unitDiscountfield_TextChanged(object sender, EventArgs e)
        {
            processButton.Text = "Process";
            pressCounter = 0;
        }

        private void bankListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            pressCounter = 0;
        }

        private void locationDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            pressCounter = 0;
        }

        private void unitPricefield_TextChanged(object sender, EventArgs e)
        {
            pressCounter = 0;
        }

        private void MakeSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                addToListTrigger.PerformClick();
        }

        private void productNameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                addToListTrigger.PerformClick();
        }

        private void quantityField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                addToListTrigger.PerformClick();
        }

        private void unitDiscountfield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                addToListTrigger.PerformClick();
        }
    }
}
