using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorpTask
{
    public partial class frmInvest : Form
    {
        public frmInvest()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstPayments.Items.Clear();
            var PERCENTAGE_RATE_ANNUAL = Convert.ToDouble(txtInterestRate.Text);
            var MONTHLY_RATE = PERCENTAGE_RATE_ANNUAL / 12 / 100;
            
            var TERM_CREDIT_MONTHS = 12 * Convert.ToInt32(txtYears.Text); 
            var COMMON_RATE = Math.Pow((1 + MONTHLY_RATE), TERM_CREDIT_MONTHS);
            var MONTHLY_PAYMENT = Convert.ToDouble(txtInvestSum.Text) * MONTHLY_RATE * COMMON_RATE / (COMMON_RATE - 1);
            double BALANCE_OWED = Convert.ToDouble(txtInvestSum.Text);
            double PERCENT_PART = 0;
            double BODY_PART = 0;
              
            
            for (int i = 1; i<= TERM_CREDIT_MONTHS; i++)
            {
                BALANCE_OWED = Convert.ToDouble(BALANCE_OWED) - Convert.ToDouble(PERCENT_PART) - Convert.ToDouble(BODY_PART);
                PERCENT_PART = BALANCE_OWED * MONTHLY_RATE;
                BODY_PART = MONTHLY_PAYMENT - PERCENT_PART;
                if (PERCENT_PART< 0)
                {
                    lstPayments.Items.Add(Convert.ToInt32(i) + "." + " Percent:" + MONTHLY_PAYMENT + " Main part: " + 0.00);
                }
                else
                    lstPayments.Items.Add(Convert.ToInt32(i)+"." + " Percent:" + PERCENT_PART + " Main part: " + BODY_PART);
            }
            var OVERPAYMENT = MONTHLY_PAYMENT * TERM_CREDIT_MONTHS - Convert.ToDouble(txtInvestSum.Text);
            txtExtra.Text = Convert.ToString(OVERPAYMENT);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lstPayments.Items.Clear();
                string year1 = DateTime.Parse(dateTimePicker1.Value.ToString()).Year.ToString();
                string year2 = DateTime.Parse(dateTimePicker2.Value.ToString()).Year.ToString();
                int year = Convert.ToInt32(year2) - Convert.ToInt32(year1);
                txtYears.Text = Convert.ToString(year);
                if (dateTimePicker1.Value > dateTimePicker2.Value) { ShowDialog("Calculation date should be greater than ageement date"); }
            }
            catch
            { throw new NotImplementedException(); }
            }

        private void ShowDialog(string v)
        {
            MessageBox.Show("Error in dates!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lstPayments.Items.Clear();
                string year1 = DateTime.Parse(dateTimePicker1.Value.ToString()).Year.ToString();
                string year2 = DateTime.Parse(dateTimePicker2.Value.ToString()).Year.ToString();
                int year = Convert.ToInt32(year2) - Convert.ToInt32(year1);
                txtYears.Text = Convert.ToString(year);
                if (dateTimePicker1.Value > dateTimePicker2.Value) { ShowDialog("Calculation date should be greater than ageement date"); }
            }
            catch
            { throw new NotImplementedException(); }
        }

    }
}


