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
    
    public partial class FormError : Form
    {
        public static FormError instance;
        public string msg;
        public FormError(string errorMessage)
        {
            InitializeComponent();
            instance = this;
            msg = errorMessage;
            txtError.Text = msg;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
