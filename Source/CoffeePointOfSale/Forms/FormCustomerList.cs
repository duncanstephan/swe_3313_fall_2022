using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : FormNoCloseBase
    {

        private readonly ICustomerService _customerService;
        public static FormCustomerList instance;
        private string? orderCustomerKey;
        private string? customerCSV;
        public string? getCustomerCSV { get { return customerCSV; } }
        public FormCustomerList(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            instance = this;

            FormCustomerList_Load();
        }

        private void FormCustomerList_Load()
        {
            string c0 = "";
            string c1 = "";
            string c2 = "";
            var customerlist = _customerService.Customers.GetListOfCustomers();

            for (int i = 0; i < _customerService.Customers.List.Count; i++)
            {
                Customer customer = customerlist[i];
                

                c0 = customer.Phone;
                c1 = customer.FirstName;
                c2 = customer.LastName;

                string[] row = new string[] {c0, c1, c2, "Order"};

                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Return to Main Menu
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void button2_Click(object sender, EventArgs e) //Opens formAddCustomer
        {
            Close();
            FormFactory.Get<FormAddCustomer>().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//Order buttons in customer list
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                orderCustomerKey = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                customerCSV = validateKey(orderCustomerKey);

                Close();
                FormFactory.Get<FormCreateOrder>().Show();
            }
        }

        private string validateKey(string key)
        {
            var customerlist = _customerService.Customers.GetListOfCustomers();
            string temp = "";

            for (int i = 0; i < _customerService.Customers.List.Count; i++)
            {
                if (key == customerlist[i].Phone)
                {
                    temp = customerlist[i].ToString();
                }
            }

            return temp;
        }
    }
}
