using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    class Receipt
    {
        private List<ReceiptItem> items = new List<ReceiptItem>();
        public const Decimal taxPercentage = 0.07m; // 7%
        private const char spacerString = ' ';
        private const String noItems = "No receipt items entered";
        private const String subtotalString = "Subtotal: ";
        private const String taxString = "Tax (7%): ";
        private const String totalString = "Total: ";
        public const int ReceiptWidth = 35;

        public override string ToString()
        {
            if (items.Count > 0)
            {
                StringBuilder toReturn = new StringBuilder();
                Decimal subtotal = 0m;

                // Add all the items
                foreach (ReceiptItem item in items)
                {
                    toReturn.AppendLine(item.ToString());
                    toReturn.AppendLine();

                    subtotal += item.GetSubtotal;
                }

                // Add the subtotal, tax and total.
                // Subtotal
                string price = subtotal.ToString("C", CultureInfo.CurrentCulture);
                toReturn.Append(subtotalString);
                toReturn.Append(spacerString, ReceiptWidth - price.Length - subtotalString.Length);
                toReturn.AppendLine(price);
                // Tax
                price = (subtotal * taxPercentage).ToString("C", CultureInfo.CurrentCulture);
                toReturn.Append(taxString);
                toReturn.Append(spacerString, ReceiptWidth - price.Length - taxString.Length);
                toReturn.AppendLine(price);
                // Total
                price = (subtotal * (taxPercentage + 1m)).ToString("C", CultureInfo.CurrentCulture);
                toReturn.Append(totalString);
                toReturn.Append(spacerString, ReceiptWidth - price.Length - totalString.Length);
                toReturn.AppendLine(price);

                return toReturn.ToString();
            }
            else return noItems;
        }

        // Getters and Setters
        public List<ReceiptItem> GetItems { get { return items; } }
    }
}
