using System;
using System.Collections.Generic;
using System.Text;
using System;



namespace Investment_Calculator
{
    public class InvestmentCalculator
    {

        
        public static double GetMoney(double startMoney, double startAge, double endAge, double rateReturn)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            

            for(int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100);

            }
            return finalMoney;
        }

        public static double GetMoney(double startMoney, double startAge, double endAge, double rateReturn, double yearlyCon)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            double totalCon = 0;

            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100) + yearlyCon;
                totalCon += yearlyCon;
            }
            return finalMoney;
        }


        public static double GetMoney(double startMoney, double startAge, double endAge, double rateReturn, double yearlyCon, double yGrowth)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            double totalCon =0;

            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100) + yearlyCon;
                yearlyCon = yearlyCon * (1 + yGrowth / 100);
                totalCon += yearlyCon;
            }
            return finalMoney;
        }


        public static double GetInflationMoney(double startMoney, double startAge, double endAge, double rateReturn, double yearlyCon, double yGrowth, double inflationRate)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            double totalCon = 0;

            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + (rateReturn - inflationRate) / 100) + yearlyCon;
                yearlyCon = yearlyCon * (1 + yGrowth / 100);
                totalCon += yearlyCon;
            }
            return finalMoney;
        }

        public static double GetInflationMoney(double startMoney, double startAge, double endAge, double rateReturn,  double inflationRate)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            double totalCon = 0;

            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + (rateReturn - inflationRate) / 100);

            }
            return finalMoney;
        }

        public static double GetYearly(double startMoney, double startAge, double endAge, double rateReturn, double yearlyCon)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            double totalCon = 0;

            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100) + yearlyCon;
                totalCon += yearlyCon;
            }
            return totalCon;
        }
        public static double GetYearly(double startMoney, double startAge, double endAge, double rateReturn, double yearlyCon, double yGrowth)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;
            double totalCon = 0;

            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100) + yearlyCon;
                totalCon += yearlyCon;
                yearlyCon = yearlyCon * (1 + yGrowth / 100);
                
            }
            return totalCon;
        }

        public static double[] GetChartMoney(double startMoney, double startAge, double endAge, double rateReturn)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;

            double[] moneyTracker = new double[(int)years];


            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100);
                moneyTracker[i] = finalMoney;
            }


            return moneyTracker;
        }

        public static double[] GetChartAge(double startMoney, double startAge, double endAge, double rateReturn)
        {
            double years = endAge - startAge;
            double finalMoney = startMoney;

            double[] ageTracker = new double[(int)years];


            for (int i = 0; i < years; i++)
            {
                finalMoney = finalMoney * (1 + rateReturn / 100);
                ageTracker[i] = startAge + i;
            }


            return ageTracker;
        }

    }
}
