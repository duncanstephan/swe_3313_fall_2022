using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms
{
    public partial class FormMain : FormBase
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void OnClickCreateOrder(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormCreateOrder>().Show();
        }

        public void OnClickBtnManagement(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormManagement>().Show();
        }

        public void OnClickBtnCustomerList(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormCustomerList>().Show();
        }
    }
}
