/*
 * Anthony Parsch
 * January 14, 2018
 * Assignment 1.3: Text Boxes
 * 
 * Custom Features:
 * Output Textbox is read only
 * Program updates on exit of the input textbox as well as when enter is pressed
 * Form title updates when output textbox is updated
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

namespace Assignment_1._3
{
    public partial class Form1 : Form
    {
        private const string outputStart = "Hello, ";
        private const string outputEnd = "! Welcome to C#!!";
        private const string titleStart = "Hello ";
        private const string titleEnd = "!";
        private const string titleDefault = "Hello User!";
        private string userName = null;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the form's title.
        /// </summary>
        private void UpdateTitle()
        {
            if (userName != null)
            {
                Text = titleStart + userName + titleEnd;
            }
            else
            {
                Text = titleDefault;
            }
        }

        /// <summary>
        /// Update the output textbox.
        /// </summary>
        private void UpdateOutputTextbox()
        {
            if (userName != null)
            {
                txtOutput.Text = outputStart + userName + outputEnd;
            }
            else
            {
                txtOutput.Text = "";
            }
        }

        /// <summary>
        /// Updates the username.
        /// </summary>
        private void UpdateUserName()
        {
            UpdateUserName(txtInput);
        }

        /// <summary>
        /// Updates the username based off of the given textbox.
        /// </summary>
        /// <param name="textBox">The textbox containing the username.</param>
        private void UpdateUserName(TextBox textBox)
        {
            userName = textBox.Text;
        }

        /// <summary>
        /// Updates the username, title, and ouput textbox.
        /// </summary>
        private void FullUpdate()
        {
            UpdateUserName();
            UpdateTitle();
            UpdateOutputTextbox();
        }

        /// <summary>
        /// Update the title at the start of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTitle();
        }

        /// <summary>
        /// When we leave the input textbox, run a full update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_Leave(object sender, EventArgs e)
        {
            FullUpdate();
        }

        /// <summary>
        /// When a user presses enter inside of the input textbox, run a full update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_CheckKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                FullUpdate();
            }
        }
    }
}
