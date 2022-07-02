using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author: Muhammad Faizan Abbasi      MAC109
 * This is a pizza house app*/
namespace PizzaApp
{
    public partial class Form1 : Form
    {
        public string inValue;
        public double price;
        public string order = "  ";
        public double totalcost;
        public Form1()
        {
            InitializeComponent();
        }

        private void PizzaApp_Load(object sender, EventArgs e)
        {
            this.comboSize.SelectedIndex = 1;
            this.comboCrust.SelectedIndex = 0;
            this.Soda1.Text = "0";
            this.water1.Text = "0";
            price = 0;
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double drinkCost,
            pizzaCost;
        

            order +=comboCrust.SelectedItem.ToString() + " - " + comboSize.SelectedItem.ToString() + "\n";
            if (toppings.SelectedItems.Count > 0)
            {
                order += "toppings: ";
                foreach (string s in toppings.CheckedItems)
                {
                    order += "\n" + s;
                }
                pizzaCost = CalculatePizzaCost();
                if (pizzaCost != 0)
                    order += "\nPizza Total: " +
                    pizzaCost.ToString("C");
                drinkCost = DrinkCost();
                if (drinkCost != 0)
                    order += "\nDrink Total: " +
                    drinkCost.ToString("C");
                totalcost = pizzaCost + drinkCost;
                order += "\nYour total order is:" + totalcost+"$";
                MessageBox.Show(order , "Your order");
            }
        }
          public double CalculatePizzaCost()
        {
            double cost;
            if (comboSize.SelectedIndex == 0)
                cost = 10.00;
            else if (comboSize.SelectedIndex == 1)
                cost = 13.00;
            else  
                cost = 16.00;
            return cost + (toppings.CheckedItems.Count * 1.50);

        }

        public double DrinkCost()
        {
            int sodacount,
                watercount;
              double  sodaCost = 0,
                waterCost= 0;
            totalcost = 0;
          
            if (Soda1.Text != " ")
            {
                while (int.TryParse(Soda.Text, out sodacount) == false)
                {
                    MessageBox.Show("Entery must be numeric", "error");
                    Soda1.Text = "0";
                }
                order += "\n\nDrink Selections:\n" + sodacount + " soda(s)";
                sodaCost = sodacount * 1.5;
               
            }
                if (water1.Text != " ")
                {
                    while (int.TryParse(water.Text, out watercount
                      ) == false)
                    {
                        MessageBox.Show("Entery must be numeric", "error");
                        water1.Text = "0";
                    }
                order += "\n\nDrink Selections:\n" + watercount + " water(s)\n";
               waterCost = watercount * 1.0 ;
                
            }
            totalcost = waterCost + sodaCost;
           
            return totalcost;

        }

      
    }
    }

