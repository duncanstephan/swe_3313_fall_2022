using CoffeePointOfSale.Services.Customer;

using CoffeePointOfSale.Forms.Base;

using CoffeePointOfSale.Services.FormFactory;
using System.Text.Json;
using CoffeePointOfSale.Services.Storage;
using CoffeePointOfSale.Configuration;
using System.Text.Json.Nodes;
using CoffeePointOfSale.Configuration;
using System.ComponentModel;
using System.Diagnostics;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : FormNoCloseBase
    {
        //public static FormPayment instance;
        //The Customer making the order
        Customer customer;

        FormCreateOrder OrderScreen = new FormCreateOrder();

        //variables to send to json file for sales data
        string dateTime;
        decimal tax;
        decimal subtotal;
        decimal total;
        int pointsEarned;
        string payment;
        string paymentDetails;

        string OrderData;

        //string that will be sent to Customers.json
        string[] salesData;
        bool anonymous = true;

        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;

        public FormPayment()
        {
            InitializeComponent();
            
        }
        public FormPayment(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            OrderData = FormCreateOrder.instance.OrderData;
            orderDataSort(OrderData);

        }


        //private void btnPayWithCredit_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    FormFactory.Get<FormReceipt>().Show();
        //    //validate credit card
        //    if (!anonymous) updatePoints();

        //    updateSalesData();

        //}
        private void btnPayWithRP_Click(object sender, EventArgs e)
        {
            if (anonymous)
            {
                Hide();
                //FormFactory.Get<FormError>().Show();
            }
            //if rewards points aren't enough, show error screen
            else
            {
                updateSalesData();
                //subtract rewards points from total

            }
        }

        public void orderDataSort(string data)
        {
            ///sets data to the string sent from FormCreateOrder
            //OrderData = data;
            salesData = data.Split(',');
            
            //Assigning SalesData Variables to the string from FormCreateOrder
            tax = Convert.ToDecimal(salesData[0]);
            subtotal = Convert.ToDecimal(salesData[1]);
            total = Convert.ToDecimal(salesData[2]);
            
            //payment = salesData[6];
            //paymentDetails = salesData[7];
            //...etc, including drinksInOrder

        }

        private void updatePoints()
        {
            if (!anonymous)
            {
                //code written assuming string sent by CreateOrder is in the same order as example Excel sheet from UML design
                string[] subStrings = OrderData.Split(',');
                decimal subTotal = Convert.ToDecimal(subStrings[5]);

                //math for adding rewards points (1pt per $1 rounding down)
                Math.Floor(subTotal);
                int newPoints = Convert.ToInt32(subTotal);
                pointsEarned = newPoints;
                int currentPoints = customer.getRewardsPoints();
                currentPoints += newPoints;

            }
        }

        private void updateSalesData()
        {
            var order = new SalesHistory
            {
                DateTime = DateTime.Now.ToString(),
                Tax = tax,
                Subtotal = subtotal,
                Total = total,
                PointsEarned = pointsEarned,
                Payment = payment,
                PaymentDetails = paymentDetails
            };

            var serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var cust = _customerService.Customers["anonymous"];
            cust.SalesHistory.Add(order);
            _customerService.Write();

            if (!anonymous)
            {
                var RewardsCust = _customerService.Customers[customer.Phone];
                RewardsCust.SalesHistory.Add(order);
                _customerService.Write();
            }
        }


        //private void label1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "RewardsPayment\n\n" + "Rewards Points Needed: " + /*Points needed for order*/ "\n\n" + "Current Rewards Points: " /*+ customer.RewardPoints*/;
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Text = customer.OrderData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormReceipt>().Show();
            //validate credit card
            if (!anonymous) updatePoints();

            updateSalesData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

      

        //private void OnLoad(object sender, EventArgs e)
        //{
        //    FormCreateOrder form = new FormCreateOrder();
        //    form.GetOrderDataString();
        //}
    }
}

//FormOrder will send an encapsulated string/ToString object with Drink order info (need to have FormCreateOrder first to work on this part)
//Payment will have to understand what financial info is in that to know how many rewards points to add/subtract
//Payment to Reciept: Update rewards points in Customers.JSON,
//Customers.JSON needs to be updated to account for sales/order history
//Info is sent to this one file
//=======
//        private void FormPayment_Load(object sender, EventArgs e)
//        {

//        }

//        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void Return_Click(object sender, EventArgs e)
//        {
//            Hide();
//            FormFactory.Get<FormMain>().Show();
//        }
//    }
//}
//>>>>>>> main
