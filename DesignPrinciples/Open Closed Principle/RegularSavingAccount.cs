using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    //regular saving account--->inherting the interface
    public class RegularSavingAccount : ISavingAccount
    {
        double interest, balance = 5000;
        //calculating interest
        public void CalculateInterest()
        {
            if(balance < 1000)
            { 
                interest -= balance * 0.2;
            }
            if (balance < 50000)
            {
                interest += balance * 0.4;
            }
            Console.WriteLine("Interest Amount for Regular Saving Account : {0}\n", interest);   
        }
    }
}
