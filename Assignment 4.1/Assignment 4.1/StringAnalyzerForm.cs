using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1
{
    public partial class StringAnalyzerForm : Form
    {
        public StringAnalyzerForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            bool doBothStrings = !string.IsNullOrEmpty(txtString2.Text);

            if (string.IsNullOrEmpty(txtString1.Text))
            {
                MessageBox.Show("String 1 is empty.", "Missing input detected");
                return;
            }
            else if ((cbxConcatenate.Checked || cbxSubstring.Checked) && (!doBothStrings))
            {
                MessageBox.Show("If you select Concatenate or Substring, String 2 can't be empty.", "Missing input detected");
                return;
            }

            StringBuilder toDisplay = new StringBuilder();
            string string1 = txtString1.Text.ToLower();
            string string2 = txtString2.Text.ToLower();

            // Reverse
            toDisplay.Append(Reverse(1, string1));
            if (doBothStrings)
            {
                toDisplay.Append(Reverse(2, string2));
                toDisplay.Append(Environment.NewLine);
            }

            // Palindrome
            toDisplay.Append(IsPalindrome(1, string1));
            if (doBothStrings)
            {
                toDisplay.Append(IsPalindrome(2, string2));
                toDisplay.Append(Environment.NewLine);
            }

            // First three characters
            toDisplay.Append(FirstThree(1, string1));
            if (doBothStrings)
            {
                toDisplay.Append(FirstThree(2, string2));
                toDisplay.Append(Environment.NewLine);
            }

            // The concatenation
            if (cbxConcatenate.Checked)
            {
                toDisplay.Append("String 1 concatenated with String 2: ");
                toDisplay.Append(string1); toDisplay.Append(string2);
                toDisplay.Append(Environment.NewLine);
            }

            // The search
            if (cbxSubstring.Checked)
            {
                bool containsString2 = string1.Contains(string2);

                if (containsString2) toDisplay.Append("String 1 contains String 2.");
                else toDisplay.Append("String1 does not contain String 2.");
            }

            lblOutput.Visible = true;
            lblOutput.Text = toDisplay.ToString();
        }

        private string Reverse(int stringNumber, string toReverse)
        {
            StringBuilder toReturn = new StringBuilder();
            string reversed = "";

            toReturn.Append("String "); toReturn.Append(stringNumber);
            toReturn.Append(" Reverse: ");

            foreach (char x in toReverse.Reverse())
            {
                reversed += x;
            }

            toReturn.Append(reversed);
            toReturn.Append(Environment.NewLine);

            return toReturn.ToString();
        }

        private string IsPalindrome(int stringNumber, string toCheck)
        {
            StringBuilder toReturn = new StringBuilder();
            IEnumerable<char> reverse = toCheck.Reverse();
            bool isPalindrome = true;

            toReturn.Append("Is String "); toReturn.Append(stringNumber);
            toReturn.Append(" a Palindrome: ");

            for (int i = 0; (i < toCheck.Length) && isPalindrome; i++)
            {
                isPalindrome = (reverse.ElementAt(i) == toCheck[i]);
            }

            toReturn.Append(isPalindrome ? "True" : "False");
            toReturn.Append(Environment.NewLine);

            return toReturn.ToString();
        }

        private string FirstThree(int stringNumber, string toSplit)
        {
            StringBuilder toReturn = new StringBuilder();

            toReturn.Append("The first three characters of String "); toReturn.Append(stringNumber);
            toReturn.Append(": ");

            toReturn.Append(toSplit.Substring(0, 3));
            toReturn.Append(Environment.NewLine);

            return toReturn.ToString();
        }
    }
}
