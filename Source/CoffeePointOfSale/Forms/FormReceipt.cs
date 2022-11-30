﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Forms.Base;
using System;

namespace CoffeePointOfSale.Forms
{
    public partial class FormReceipt : FormNoCloseBase
    {
        FormPayment form = new FormPayment();
        public static FormReceipt instance;
        string ptr;
        string rTpay;
        string rTsubp;
        string rTFpTax;
        public FormReceipt()
        {
            InitializeComponent();
            ptr = FormPayment.instance.paytorec;
            rTpay = FormPayment.instance.Tsubp;
            rTsubp = FormPayment.instance.Tpay;
            rTFpTax = FormPayment.instance.TFpTax;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            label1.Text = ptr;
            rototal.Text ="Order Subtotal: " + rTpay;
            rTax.Text = "Tax: " + rTsubp;
            rTotal.Text ="Order Total: " +rTFpTax;
            //Math.Round(_appSettings.Tax.Rate * fsubtotal, 2, MidpointRounding.AwayFromZero)

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
