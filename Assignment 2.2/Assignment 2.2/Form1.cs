/*
 * Anthony Parsch
 * January 20, 2018
 * Assignment 2.2: Programming Based on Events
 * 
 * Custom Features:
 * Displays receipt with more than 1 item, instead of just price
 * Includes espresso, iced coffee, cream and milk options
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._2
{
    public partial class Form1 : Form
    {
        private Flavor[] flavors = {    new Flavor("Dark", new decimal[] { 1.00m, 1.50m, 1.75m, 2.00m, 3.75m, 9.99m }),
                                        new Flavor("Light", new decimal[] { 1.00m, 1.50m, 1.75m, 2.00m, 3.75m, 9.99m }),
                                        new Flavor("Caramel", new decimal[] { 1.50m, 2.50m, 3.25m, 4.00m, 6.75m, 13.99m }),
                                        new Flavor("Mocha", new decimal[] { 1.50m, 2.50m, 3.25m, 4.00m, 6.75m, 13.99m }),
                                        new Flavor("Vanilla", new decimal[] { 1.50m, 2.50m, 3.25m, 4.00m, 6.75m, 13.99m })
                                    };
        private string[] sizes = { "4 oz", "8 oz", "12 oz", "16 oz", "32 oz", "Party Box" };
        private decimal icedMultiplier = 0.25m;
        private decimal creamMultiplier = 0.10m;
        private decimal milkMultiplier = 0.10m;
        private decimal espressoShotCost = 0.25m;

        private const string espressoString = "Shots of Espresso";
        private const string icedString = "Iced";
        private const string creamString = "Cream";
        private const string milkString = "Real Milk";

        private Receipt receipt = new Receipt();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill the two comboboxes
            foreach (Flavor flavor in flavors)
            {
                cbxFlavor.Items.Add(flavor.getName);
            }

            cbxQuantity.Items.AddRange(sizes);

            // Set defaults
            cbxFlavor.SelectedIndex = 0;
            cbxQuantity.SelectedIndex = 0;

            txtReceipt.Text = receipt.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<Extra> extras = new List<Extra>();

            // Get the name and price of the order
            string name = sizes[cbxQuantity.SelectedIndex] + " " + flavors[cbxFlavor.SelectedIndex].getName;
            decimal price = flavors[cbxFlavor.SelectedIndex].getPrices[cbxQuantity.SelectedIndex];

            // Handle extras
            if (nudEspresso.Value > 0)
            {
                Extra espresso;
                espresso.name = nudEspresso.Value.ToString() + " " + espressoString;
                espresso.cost = espressoShotCost * nudEspresso.Value;

                extras.Add(espresso);
            }

            if (cbxIced.Checked)
            {
                Extra iced;
                iced.name = icedString;
                iced.cost = price * icedMultiplier;

                extras.Add(iced);
            }

            if (cbxCream.Checked)
            {
                Extra cream;
                cream.name = creamString;
                cream.cost = price * creamMultiplier;

                extras.Add(cream);
            }

            if (cbxMilk.Checked)
            {
                Extra milk;
                milk.name = milkString;
                milk.cost = price * milkMultiplier;

                extras.Add(milk);
            }

            receipt.GetItems.Add(new ReceiptItem(name, extras.ToArray(), price));
            txtReceipt.Text = receipt.ToString();
        }
    }
}
