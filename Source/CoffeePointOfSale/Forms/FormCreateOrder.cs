using CoffeePointOfSale.Configuration;
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
    public partial class FormCreateOrder : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        public FormCreateOrder(IAppSettings appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            
        }
        private void ComputerTotal()
        {
            //??? use
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            SetTitle("Create Order Form");
        }
    }
}
