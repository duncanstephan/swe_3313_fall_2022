using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Services.Customer;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CoffeePointOfSale.Forms
{
    public partial class FormAddCustomer : FormBase
    {
        private readonly ICustomerService _customerService;
        public static FormAddCustomer instance;
        public FormAddCustomer(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            instance = this;
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void AddCustomer()
        {
            Customer customer = new Customer();//Create new customer object, then assign textbox variables to customer object.
            customer.Phone = validatePhone(txtPhone.Text);
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.RewardPoints = 0;
            customer.setId();

            _customerService.Customers.Add(customer);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer();
            Close();
            FormFactory.Get<FormCustomerList>().Show();
        }

        private string validatePhone(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && isAllNums(phoneNumber) == true)//If phone number was not formatted with dashes, adds them. Converts to char array, moves things down, replaces original string with new string.
            {
                char[] phoneNums = phoneNumber.ToCharArray();
                char[] newNums = new char[12];
                newNums[10] = phoneNums[8];
                newNums[11] = phoneNums[9];
                newNums[9] = phoneNums[7];
                newNums[8] = phoneNums[6];
                newNums[7] = '-';
                newNums[6] = phoneNums[5];
                newNums[5] = phoneNums[4];
                newNums[4] = phoneNums[3];
                newNums[3] = '-';
                newNums[2] = phoneNums[2];
                newNums[1] = phoneNums[1];
                newNums[0] = phoneNums[0];

                phoneNumber = "";
                foreach (char c in newNums)
                {
                    phoneNumber += c;
                }
            }

            try
            {
                if (isUnique(phoneNumber))
                {

                }
                else
                {
                    throw new Exception();
                }
            } catch (Exception e)
            {
                var o = phoneNumber;
                GCHandle gch = GCHandle.Alloc(o, GCHandleType.Pinned);
                IntPtr ptr = gch.AddrOfPinnedObject();
                
                string temp = "Error Code " + ptr + ": Phone Number already exists in Customer Records.";
                Debug.WriteLine(temp);
            }

            return phoneNumber;
        }

        private bool isAllNums(string numbers)
        {
            return numbers.All(Char.IsDigit);
        }

        private bool isUnique(string phoneNum)
        {
            int trip = 0;
            foreach (Customer c in _customerService.Customers.List)
            {
                if (phoneNum == c.Phone)
                {
                    trip = -1;
                }
            }

            if (trip != -1)
            {
                return true;
            } else 
            { 
                return false; 
            }
        }
    }
}
