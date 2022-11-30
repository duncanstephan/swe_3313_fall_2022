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

namespace CoffeePointOfSale.Forms
{
    public partial class FormAddCustomer : FormBase
    {
        private readonly ICustomerService _customerService;
        public FormAddCustomer(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void AddCustomer()
        {
            Customer customer = new Customer();//Create new customer object, then assign textbox variables to customer object.
            customer.Phone = txtPhone.Text;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.RewardPoints = 0;
            customer.setId();

            _customerService.Customers.Add(customer);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void validatePhone(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && isAllNums(phoneNumber) == true)
            {
                char[] phoneNums = phoneNumber.ToCharArray();
                phoneNums[10] = phoneNums[8];
                phoneNums[11] = phoneNums[9];
                phoneNums[9] = phoneNums[7];
                phoneNums[8] = phoneNums[6];
                phoneNums[7] = '-';
                phoneNums[6] = phoneNums[5];
                phoneNums[5] = phoneNums[4];
                phoneNums[4] = phoneNums[3];
                phoneNums[3] = '-';
            }

            try
            {
                if (isUnique(phoneNumber))
                {

                }
                else
                {
                    throw new Exception("Phone Number already exists in Customer Records.");
                }
            } catch (Exception e)
            {

            }
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
