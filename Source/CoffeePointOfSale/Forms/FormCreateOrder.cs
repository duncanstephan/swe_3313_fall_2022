using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CoffeePointOfSale.Services.DrinkMenu;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using CheckBox = System.Windows.Forms.CheckBox;
using System.Diagnostics;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormCreateOrder : Base.FormNoCloseBase

    {
        //public static FormCreateOrder instance;
        public string OrderData;
        public decimal orderTax;
        decimal subtotal = 0;
        decimal fsubtotal = 0; 
        decimal fptax = 0;


       //1366, 768

        private IAppSettings _appSettings;
        private IDrinkMenuService _drinkMenuService;
        public static FormCreateOrder instance;
        
        public FormCreateOrder()
        {
            //InitializeComponent();
        }

        public FormCreateOrder(IAppSettings appSettings, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _drinkMenuService = drinkMenuService;

            instance = this;
        }
        

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            SetTitle("Create Order");
            ExampleOneSimpleClassObject();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
            
        {
            
           
            comboBox2.Items.Clear();

            ArrayList alist = new ArrayList();


            var drinkList = _drinkMenuService.DrinkMenu.Drinks;
            //if (comboBox1.Text == "")
            
            for(int i = 0; i<drinkList.Count;i++)
            {
                if (drinkList[i].Name == comboBox1.Text)
                {
                    Drink.Text = drinkList[i].Name + " $" + drinkList[i].BasePrice.ToString();
                }
            }
            for (int i = 0; i < drinkList.Count; i++)
            {
                if (drinkList[i].Name == comboBox1.Text)
                {
                    for(int j = 0; j < drinkList[i].Customizations.Count; j++)
                    {
                        comboBox2.Items.Add(drinkList[i].Customizations[j].Name);

                    }
                }
            }

            

            
            


            //Add this onload. 
            // groupBox1.Show();
            // if (Drink.Text.Length > 0)
            // {
            //     Cl2.Text = "1x - "+comboBox1.Text;
            // }
            /// else
            // {
            //     Drink.Text = "1x - " + comboBox1.Text;
            // }




        }

       

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void Customization_Click(object sender, EventArgs e)
        {
            
        }

        public string GetOrderDataString()
        {
            Debug.WriteLine("I reached the getter");
            Debug.WriteLine(OrderData);
            return OrderData;
        }

        private void button2_Click(object sender, EventArgs e)  //Add drink to order
        {
            Cl6.Text = Cl6.Text + Environment.NewLine + Drink.Text + Cl1.Text;
            Cl1.Text = "";
            Drink.Text = "";
            fsubtotal = fsubtotal + subtotal;
            subtotal = 0;
            osubtotal.Text = "Order Subtotal: " + fsubtotal.ToString();
            fptax = (fsubtotal * _appSettings.Tax.Rate) + fsubtotal;
            finalptax.Text = "Order Total: $" + Math.Round(fptax,2,MidpointRounding.AwayFromZero).ToString();
            //calculate final tax
            orderTax = Math.Round(_appSettings.Tax.Rate * fsubtotal, 2, MidpointRounding.AwayFromZero);
            label6.Text = "Drink Subtotal: ";
            if (Cl6.Text.Length > 0)
            {
                tax.Text = "Tax: " + (Math.Round(_appSettings.Tax.Rate*fsubtotal,2,MidpointRounding.AwayFromZero));
            }
            
        }

        private void button1_Click(object sender, EventArgs e)  //Finalize Order
        {
            //Debug.WriteLine(OrderData);
            OrderData = orderTax.ToString() + "," + fsubtotal.ToString() + "," + fptax.ToString();
            //Debug.WriteLine(OrderData + "After");
            if (Cl6.Text.Length != 0)
            {
                Hide();
                FormFactory.Get<FormPayment>().Show();
            }
            
        }

    
        
       
       

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ExampleOneSimpleClassObject()
        {
            var drinkList = _drinkMenuService.DrinkMenu.Drinks;
            for(int i = 0; i < drinkList.Count; i++)
            {
                comboBox1.Items.Add(drinkList[i].Name);
            }
            
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Drink_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


            var drinkList = _drinkMenuService.DrinkMenu.Drinks;
            if (subtotal == 0)
            {
                for (int i = 0; i < drinkList.Count; i++)
                {
                    if (drinkList[i].Name == comboBox1.Text)
                    {
                        subtotal = drinkList[i].BasePrice;
                    }
                }

            }

            for (int i = 0; i < drinkList.Count; i++)
            {
                if (drinkList[i].Name == comboBox1.Text)
                {
                    
                    for (int j = 0; j < drinkList[i].Customizations.Count; j++)
                    {
                        if (comboBox2.Text == drinkList[i].Customizations[j].Name)
                        {
                            int quantity = Int32.Parse(comboBox3.Text);
                            Cl1.Text = Cl1.Text + Environment.NewLine + comboBox3.Text + "x " + comboBox2.Text +" " +(drinkList[i].Customizations[j].Price*quantity);
                            subtotal =  subtotal + (drinkList[i].Customizations[j].Price * quantity);
                        }

                    }
                    
                }
            }
            label6.Text = "Drink Subtotal: " + subtotal.ToString();
           
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cl1.Text = "";
            Drink.Text = "";
            subtotal = 0;
            label6.Text = "Drink Subtotal: " + subtotal;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

     
        private void returntomain(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cl6.Text = "";
            fsubtotal = 0;
            osubtotal.Text = "Order Subtotal: " + fsubtotal.ToString();
            tax.Text = "Tax: ";
            fptax = 0;
            finalptax.Text = "Order Total: $" + Math.Round(fptax).ToString();

        }
    }


}
