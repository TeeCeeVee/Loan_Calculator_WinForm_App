using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculatorApp
{
    public partial class Form1 : Form
    {

        // member variables to be used in calculation
        decimal loan_amount = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.00m;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //prevent user from entering non-numbers
            //values from the textbox gets assigned to the variables
            try
            {
                loan_amount = decimal.Parse(txt_loanAmount.Text);
                number_of_months = Convert.ToInt32(txt_numberOfMonths.Text);
                interest_rate = decimal.Parse(txt_interestRate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter numbers only");
            }

            // start of while loop
            // lists the loan total each mont
            int month_counter = 0;

            while (month_counter < number_of_months)
            {
                loan_amount = loan_amount + (loan_amount * interest_rate);
                listBox.Items.Add("Month " + month_counter + ": " + loan_amount.ToString("c"));
                month_counter++;
            }
            //end of loop
            // calculate final total

            txt_finalValue.Text = loan_amount.ToString("c");

            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_loanAmount.Clear();
            txt_numberOfMonths.Clear();
            txt_interestRate.Clear();
            txt_finalValue.Clear();
            listBox.Items.Clear();
  
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
