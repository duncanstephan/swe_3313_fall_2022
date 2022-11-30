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

namespace CoffeePointOfSale.Forms
{
    public partial class FormAddCustomer : FormBase
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
