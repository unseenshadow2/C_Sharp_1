using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    public struct Extra
    {
        public string name;
        public decimal cost;
    }

    public class ReceiptItem
    {
        public const int ReceiptWidth = Receipt.ReceiptWidth;
        public const int IndentWidth = 4;
        public const char filler = '.';
        public const char extrasFiller = ' ';
        private string _name = "";
        private Extra[] _extras = { };
        private decimal _cost = 0.00m;
        private decimal _subtotal = 0m;

        private ReceiptItem() { }
        public ReceiptItem(string name, Extra[] extras, decimal cost)
        {
            _name = name;
            _extras = extras;
            _cost = cost;

            _subtotal += cost;
            for (int i = 0; i < extras.Length; i++)
            {
                _subtotal += extras[i].cost;
            }
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();
            string price = "";

            // Product Cost
            toReturn.Append(_name);
            price = _cost.ToString("C", CultureInfo.CurrentCulture);
            toReturn.Append(filler, ReceiptWidth - _name.Length - price.Length);
            toReturn.AppendLine(price);

            // All the extras
            for (int i = 0; i < _extras.Length; i++)
            {
                toReturn.Append(' ', IndentWidth);
                toReturn.Append(_extras[i].name);
                price = _extras[i].cost.ToString("C", CultureInfo.CurrentCulture);
                toReturn.Append(extrasFiller, ReceiptWidth - IndentWidth - price.Length - _extras[i].name.Length);
                toReturn.AppendLine(price);
            }

            return toReturn.ToString();
        }

        public static string GenerateString(string name, Extra[] extras, decimal cost)
        {
            return new ReceiptItem(name, extras, cost).ToString();
        }

        public decimal GetSubtotal { get { return _subtotal; } }
    }
}
