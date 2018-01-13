/*
 * Anthony Parsch
 * January 12, 2018
 * Assignment 1.2: Integer
 * 
 * Custom Features:
 * Use of Decimals instead of integers.
 * Added a checkbox to disable the use of randomized numbers being
 * used in a second use the same operation.
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

namespace Assignment_1._2
{
    public delegate decimal Operation(decimal d1, decimal d2);

    public partial class Form1 : Form
    {
        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear the output when input changes
        /// </summary>
        private void ClearOutput()
        {
            txtOutput.Text = "";
            lblRandomOperation.Text = "";
        }

        /// <summary>
        /// Runs when the user selects a new operation
        /// </summary>
        /// <param name="sender">The Radio Button that is the sender</param>
        /// <param name="e">The event arguments</param>
        private void OperationsRadioButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            ClearOutput();

            if (rb.Text == "+") lblSign.Text = "+";
            else if (rb.Text == "-") lblSign.Text = "-";
            else if (rb.Text == "x") lblSign.Text = "X";
            else if (rb.Text == "/") lblSign.Text = "/";
            else if (rb.Text == "Remainder") lblSign.Text = "%";
        }

        /// <summary>
        /// Clear output when the input numbers are changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNumberUpDown_ValueChanged(object sender, EventArgs e)
        {
            ClearOutput();
        }

        /// <summary>
        /// Calculate the value of the operation as well as the same operation
        /// with two random numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdbAdd.Checked) // Addition
            {
                txtOutput.Text = (nudNum1.Value + nudNum2.Value).ToString();
                if (chbGenerateOperation.Checked) lblRandomOperation.Text = RunOperation('+', (decimal d1, decimal d2) => { return d1 + d2; });
            }
            else if (rdbSub.Checked) // Subtraction
            {
                txtOutput.Text = (nudNum1.Value - nudNum2.Value).ToString();
                if (chbGenerateOperation.Checked) lblRandomOperation.Text = RunOperation('-', (decimal d1, decimal d2) => { return d1 - d2; });
            }
            else if (rdbMult.Checked) // Multiplication
            {
                txtOutput.Text = (nudNum1.Value * nudNum2.Value).ToString();
                if (chbGenerateOperation.Checked) lblRandomOperation.Text = RunOperation('x', (decimal d1, decimal d2) => { return d1 * d2; });
            }
            else if (rdbDiv.Checked) // Division
            {
                if (nudNum2.Value != 0)
                {
                    txtOutput.Text = (nudNum1.Value / nudNum2.Value).ToString();
                    if (chbGenerateOperation.Checked) lblRandomOperation.Text = RunOperation('/', (decimal d1, decimal d2) => { return d1 / d2; });
                }
                else
                {
                    MessageBox.Show("The second value cannot be zero for this operation", "Divided by Zero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdbRem.Checked) // Remainder
            {
                if (nudNum2.Value != 0)
                {
                    txtOutput.Text = (nudNum1.Value % nudNum2.Value).ToString();
                    if (chbGenerateOperation.Checked) lblRandomOperation.Text = RunOperation('%', (decimal d1, decimal d2) => { return d1 % d2; });
                }
                else
                {
                    MessageBox.Show("The second value cannot be zero for this operation", "Divided by Zero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Runs the given operation with two random numbers.
        /// Returns a string representation of the operation.
        /// </summary>
        /// <param name="symbol">The symbol of the operation</param>
        /// <param name="operation">The operation itself</param>
        /// <returns></returns>
        String RunOperation(char symbol, Operation operation)
        {
            StringBuilder toReturn = new StringBuilder();
            Decimal randNum1 = (Decimal)(random.NextDouble() * 200 - 100);
            Decimal randNum2 = (Decimal)(random.NextDouble() * 200 - 100);

            // Protect us against division by 0
            if (randNum2 == 0) randNum2 = (Decimal)random.NextDouble();

            toReturn.Append(randNum1.ToString("F2"));
            toReturn.Append(" " + symbol + " ");
            toReturn.Append(randNum2.ToString("F2"));
            toReturn.Append(" = ");
            toReturn.Append(operation(randNum1, randNum2).ToString("F2"));

            return toReturn.ToString();
        }

        /// <summary>
        /// Clear our output when the checkbox is changes state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbGenerateOperation_CheckedChanged(object sender, EventArgs e)
        {
            ClearOutput();
        }
    }
}
