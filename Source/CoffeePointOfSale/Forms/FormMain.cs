using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    public FormMain(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
    }

    private void OnClickBtnManagement(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormManagement>().Show();
    }

    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    //<<<<<<< HEAD
    private void btnAnonOrder(object sender, EventArgs e)
    {
        Hide();
        //FormFactory.Get<FormPayment>().Show();
        //=======
    }
    private void CreateOrder_Click(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormCreateOrder>().Show();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {

//>>>>>>> main
    }

    private void CustomerList_Click(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormCustomerList>().Show();
    }
}