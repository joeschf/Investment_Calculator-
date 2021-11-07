using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace Investment_Calculator
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double startMoney;
            bool success = double.TryParse(uxStartText.Text, out startMoney);

            if (success)
            {
                startMoney = double.Parse(uxStartText.Text);
            }
            else
            {
                MessageBox.Show("Enter Numbers Only in Start Money Box");
                return;
            }

            double startAge;
            success = double.TryParse(uxStartAge.Text, out startAge);
            if (success)
            {
                startAge = double.Parse(uxStartAge.Text);

            }
            else
            {
                MessageBox.Show("Enter Numbers Only in Start Age Box");
                return;
            }


            double endAge;
            success = double.TryParse(uxEndAge.Text, out endAge);
            if (success)
            {
                endAge = double.Parse(uxEndAge.Text);
                if (endAge < startAge)
                {
                    MessageBox.Show("End Age must be greater than Start Age");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter Numbers Only in End Age Box");
                return;
            }

            double returnRate;
            success = double.TryParse(uxReturnRate.Text, out returnRate);
            if (success)
            {
                returnRate = double.Parse(uxReturnRate.Text);
            }
            else
            {
                MessageBox.Show("Enter Numbers Only in Return Rate Box ");
                return;
            }


            if (uxYearlyContribution.Text == "")
            {
                if (uxInflationRate.Text == "")
                {
                    double money = InvestmentCalculator.GetMoney(startMoney, startAge, endAge, returnRate);
                    uxEndingMoney.Text = String.Format("{0:n}", money);
                    uxTotalContributions.Text = "";
                    uxInflationMoney.Text = "";
                }
                else
                {

                    double inflationRate;
                    success = double.TryParse(uxInflationRate.Text, out inflationRate);
                    if (success)
                    {
                        inflationRate = double.Parse(uxInflationRate.Text);
                    }
                    else
                    {
                        MessageBox.Show("Enter Numbers Only in Inflation Rate Box ");
                        return;
                    }

                    double money = Math.Round(InvestmentCalculator.GetMoney(startMoney, startAge, endAge, returnRate), 2);

                    double inflationMoney = Math.Round(InvestmentCalculator.GetInflationMoney(startMoney, startAge, endAge, returnRate, inflationRate), 2);

                    uxEndingMoney.Text = String.Format("{0:n}", money);
                    uxTotalContributions.Text = "";
                    uxInflationMoney.Text = String.Format("{0:n}", inflationMoney);
                }

            }

            else if (uxYGrowth.Text == "")
            {
                double yearlyCon;
                success = double.TryParse(uxYearlyContribution.Text, out yearlyCon);
                if (success)
                {
                    yearlyCon = double.Parse(uxYearlyContribution.Text);
                }
                else
                {
                    MessageBox.Show("Enter Numbers Only in Return Rate Box ");
                    return;
                }

                double money = InvestmentCalculator.GetMoney(startMoney, startAge, endAge, returnRate, yearlyCon);
                double totalCon = InvestmentCalculator.GetYearly(startMoney, startAge, endAge, returnRate, yearlyCon);
                uxEndingMoney.Text = String.Format("{0:n}", money);
                uxTotalContributions.Text = String.Format("{0:n}", totalCon);
            }

            else if (uxInflationRate.Text == "")
            {
                double yearlyCon;
                success = double.TryParse(uxYearlyContribution.Text, out yearlyCon);
                if (success)
                {
                    yearlyCon = double.Parse(uxYearlyContribution.Text);
                }
                else
                {
                    MessageBox.Show("Enter Numbers Only in Yearly Contribution Box ");
                    return;
                }

                double yGrowth;
                success = double.TryParse(uxYGrowth.Text, out yGrowth);
                if (success)
                {
                    yGrowth = double.Parse(uxYGrowth.Text);
                }
                else
                {
                    MessageBox.Show("Enter Numbers Only in Yearly Growth Box ");
                    return;
                }


                double money = Math.Round(InvestmentCalculator.GetMoney(startMoney, startAge, endAge, returnRate, yearlyCon, yGrowth), 2);
                double totalCon = Math.Round(InvestmentCalculator.GetYearly(startMoney, startAge, endAge, returnRate, yearlyCon, yGrowth), 2);
                uxEndingMoney.Text = String.Format("{0:n}", money);
                uxTotalContributions.Text = String.Format("{0:n}", totalCon);
                uxInflationMoney.Text = "";
            }
            else
            {


                double yearlyCon;
                success = double.TryParse(uxYearlyContribution.Text, out yearlyCon);
                if (success)
                {
                    yearlyCon = double.Parse(uxYearlyContribution.Text);
                }
                else
                {
                    MessageBox.Show("Enter Numbers Only in Yearly Contribution Box ");
                    return;
                }

                double yGrowth;
                success = double.TryParse(uxYGrowth.Text, out yGrowth);
                if (success)
                {
                    yGrowth = double.Parse(uxYGrowth.Text);
                }
                else
                {
                    MessageBox.Show("Enter Numbers Only in Yearly Growth Box ");
                    return;
                }
                double inflationRate;
                success = double.TryParse(uxYGrowth.Text, out inflationRate);
                if (success)
                {
                    inflationRate = double.Parse(uxInflationRate.Text);
                }
                else
                {
                    MessageBox.Show("Enter Numbers Only in Inflation Rate Box ");
                    return;
                }


                double money = Math.Round(InvestmentCalculator.GetMoney(startMoney, startAge, endAge, returnRate, yearlyCon, yGrowth), 2);
                double totalCon = Math.Round(InvestmentCalculator.GetYearly(startMoney, startAge, endAge, returnRate, yearlyCon, yGrowth), 2);
                double inflationMoney = Math.Round(InvestmentCalculator.GetInflationMoney(startMoney, startAge, endAge, returnRate, yearlyCon, yGrowth, inflationRate), 2);

                uxEndingMoney.Text = String.Format("{0:n}", money);
                uxTotalContributions.Text = String.Format("{0:n}", totalCon);
                uxInflationMoney.Text = String.Format("{0:n}", inflationMoney);

            }

        }

            
       
            
            
        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void uxGraphButton_Click(object sender, EventArgs e)
        {
            Form graph = new Graph();
            graph.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
