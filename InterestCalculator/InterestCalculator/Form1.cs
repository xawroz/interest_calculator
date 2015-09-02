using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxPrinciple_Click(object sender, EventArgs e)
        {
            textBoxPrinciple.Text = "";
        }

        private void textBoxTime_Click(object sender, EventArgs e)
        {
            textBoxTime.Text = "";
        }

        private void textBoxRate_Click(object sender, EventArgs e)
        {
            textBoxRate.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double interest = validateAndOperate();
            if (interest == (-1))
            {
                labelResult.Text = "The data you entered in not valid";
            }
            else
            {
                {
                    labelResult.Text = "The total interest is Rs:" + interest;
                }
            }
        }

        double validateAndOperate()
        {
            Interest_calc calc=new Interest_calc();
            decimal number;
            double principle, rate, time,interest_temp;
            if((Decimal.TryParse(textBoxPrinciple.Text,out number))&&(Decimal.TryParse(textBoxRate.Text, out number))&& (Decimal.TryParse(textBoxTime.Text, out number)))
            {
                principle = Convert.ToDouble(textBoxPrinciple.Text);
                rate = Convert.ToDouble(textBoxRate.Text);
                time = Convert.ToDouble(textBoxTime.Text);
                calc.Principle = principle;
                calc.Rate = rate;
                calc.Time = time;
                interest_temp = calc.interest_amount_calc();
               
             }
            else
            {

                {
                    interest_temp = -1;
                }
       
            }
            return interest_temp;
        }
    }
}
