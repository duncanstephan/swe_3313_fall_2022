using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms
{
    public partial class FormMain : FormBase
    {
        public static FormMain instance;
        public int orderImport = 1;
        public FormMain()
        {
            InitializeComponent();
            instance = this;

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Hide();
            orderImport = 2;
            FormFactory.Get<FormCreateOrder>().Show();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormCustomerList>().Show();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormManagement>().Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
