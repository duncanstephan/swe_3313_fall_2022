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
using CreditCardValidator;
using static System.Net.Mime.MediaTypeNames;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : FormNoCloseBase
    {
        //public static FormPayment instance;
        //The Customer making the order
        Customer customer;
        public string paytorec;
        public static FormPayment instance;

        FormCreateOrder OrderScreen = new FormCreateOrder();

        //variables to send to json file for sales data
        string dateTime;
        decimal tax;
        decimal subtotal;
        decimal total;
        int pointsEarned;
        string payment;
        string paymentDetails;

        //variables to send to json file for DrinksInOrder
        string drink;
        decimal basePrice;
        decimal price;
        string customizations;

        string OrderData;
        string ordersum;
        string ptr;
        string customerCSV;
        //string that will be sent to Customers.json
        string[] salesData;
        bool anonymous = true;
        public string Tpay;
        public string Tsubp;
        public string TFpTax;

        //Boolean Variables to determine which button is clicked
        bool credit = false;
        bool rPoints = false;

        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;

        public FormPayment()
        {
            InitializeComponent();
            
        }
        public FormPayment(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            instance = this;
            _customerService = customerService;
            customer = new Customer();
            _appSettings = appSettings;
            InitializeComponent();
            customerCSV = FormCreateOrder.instance.customerKey;
            OrderData = FormCreateOrder.instance.OrderData;
            orderDataSort(OrderData);
            ordersum = FormCreateOrder.instance.ordersum;
            Tpay = FormCreateOrder.instance.Tpay;
            Tsubp = FormCreateOrder.instance.Tsubp;
            TFpTax = FormCreateOrder.instance.TFpTax;
            //ptr = FormCreateOrder.instance.

        }

        private void appendOrderData()
        {
            string temp = OrderData;
            temp += "," + customerCSV;
            OrderData = temp;
        }

        //private void BtnPayWithCredit_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    FormFactory.Get<FormReceipt>().Show();
        //    //validate credit card
        //    if (!anonymous) updatePoints();

        //    updateSalesData();

        //}

        private void btnPayWithRP_Click(object sender, EventArgs e)
        {
            rPoints = true;
            payment = "RewardPoints";
            paymentDetails = "RP";
            if (anonymous)
            {
                Hide();
                //FormFactory.Get<FormError>().Show();
            }
            //if rewards points aren't enough, show error screen
            else
            {
                updateSalesData();
                updatePoints();

            }
        }

        public void orderDataSort(string data)
        {
            ///sets data to the string sent from FormCreateOrder
            //OrderData = data;
            appendOrderData();
            salesData = data.Split(',');
            
            //Assigning SalesData Variables to the string from FormCreateOrder
            tax = Convert.ToDecimal(salesData[0]);
            subtotal = Convert.ToDecimal(salesData[1]);
            total = Convert.ToDecimal(salesData[2]);

            drink = salesData[3];
            basePrice = Convert.ToDecimal(salesData[4]);
            price = Convert.ToDecimal(salesData[5]);
            customizations = salesData[6];

            validateKey(salesData[7]);
            //customer.FirstName = salesData[8];
            //customer.LastName = salesData[9];
            //customer.RewardPoints = Convert.ToInt32(salesData[10]);
            

        }

        private void updatePoints()
        {
            //code written assuming string sent by CreateOrder is in the same order as example Excel sheet from UML design
            string[] subStrings = OrderData.Split(',');
            decimal subTotal = Convert.ToDecimal(subStrings[1]);
            int currentPoints = customer.getRewardsPoints();

            if (!anonymous && credit)
            {
                //math for adding rewards points (1pt per $1 rounding down)
                Math.Floor(subTotal);
                int newPoints = Convert.ToInt32(subTotal);
                pointsEarned = newPoints;
                Debug.WriteLine(newPoints);
                currentPoints += newPoints;
            }
            if(!anonymous && rPoints)
            {
                //math for subtracting rewards points
                Math.Floor(total);                  //round down
                int Total = Convert.ToInt32(total); //convert to int
                int rpCost = Total * 10;            //cost is 10 points for every dollar
                Debug.WriteLine(rpCost);
                if(rpCost > currentPoints)          //if the customer does not have enough points, error form shows
                {
                    Hide();
                    //FormFactory.Get<FormError>().Show();
                }
                else
                {
                    currentPoints -= rpCost;        //cost is suptracted from customer's points if they have enough
                }
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
                PaymentDetails = paymentDetails,
            };

            var drinks = new DrinksInOrder
            {
                Drink = drink,
                BasePrice = basePrice,
                Price = price,
                Description = customizations
            };

            var serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            if (anonymous)
            {
                var cust = _customerService.Customers["anonymous"];
                cust.SalesHistory.Add(order);
                order.drinksInOrder.Add(drinks);
                _customerService.Write();
            }
          
            if (!anonymous)
            {
                var RewardsCust = _customerService.Customers[customer.Phone];
                RewardsCust.SalesHistory.Add(order);
                order.drinksInOrder.Add(drinks);
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

        private void BtnPayWithCredit_Click(object sender, EventArgs e)
        {
            credit = true;
            payment = "Credit";
            ///paymentDetails = last four digits of card
            //validate credit card
            CreditCardDetector detector = new CreditCardDetector(textBox1.Text);
            bool Valid = detector.IsValid();
            if (Valid == false)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Card number not valid";
            }
            //only put data to be transfered after successful validation inside the else statment!!!
            else
            {
                Hide();
                FormFactory.Get<FormReceipt>().Show();
                if (!anonymous) updatePoints();
                //sends payment data to receipt.
                paytorec = label1.Text;
                updateSalesData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            label1.Text = ordersum;
            osubtotal.Text = "Order Subtotal :$"+Tsubp;
            taxp.Text = "Tax: $" + Tpay;
            ototalp.Text = "Order Total: $" + TFpTax;


        }

        private void validateKey(string key)
        {
            var customerlist = _customerService.Customers.GetListOfCustomers();
            string temp = "";

            for (int i = 0; i < _customerService.Customers.List.Count; i++)
            {
                if (key == customerlist[i].Phone)
                {
                    customer = customerlist[i];
                }
            }

            
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
