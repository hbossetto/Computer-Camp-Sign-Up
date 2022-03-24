using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            // Declare Variables
            double languageFee = 0.0;
            double optionsFee = 0.0;
            double eSpending;
            double totalCost;

            // Input Data
            // Radio Buttons
            if(cSharpRadioButton.Checked)
            {
                languageFee = 1000.0;
            }
            else if (javaRadioButton.Checked)
            {
                languageFee = 2000.0;
            }
            // Checkboxes
            if (mealsCheckBox.Checked)
            {
                optionsFee += 100.0;
            }
            if (cabinCheckBox.Checked)
            {
                optionsFee += 200.0;
            }
            // E-Spending Money Textbox
            if(double.TryParse(eSpendingTextBox.Text, out eSpending))
            {
                if (eSpending >= 30.0 && eSpending <= 60.0)
                {
                    //Process Data into Info
                    totalCost = languageFee + optionsFee + eSpending;

                    //Output Information
                    languageLabel.Text = languageFee.ToString("c");
                    optionsLabel.Text = optionsFee.ToString("c");
                    eSpendingLabel.Text = eSpending.ToString("c");
                    totalCostLabel.Text = totalCost.ToString("c");
                }
                else
                {
                    MessageBox.Show("Please enter E-Spending amount between $30 and $60.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid E-Spending amount");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Radio Buttons
            cSharpRadioButton.Checked = true;
            // Clear Check Boxes
            mealsCheckBox.Checked = false;
            cabinCheckBox.Checked = false;
            // Clear Textbox
            eSpendingTextBox.Text = "";
            // Clear Labels
            languageLabel.Text = "";
            optionsLabel.Text = "";
            eSpendingLabel.Text = "";
            totalCostLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
