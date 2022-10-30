using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class BankAccount
    {
        public int GetBalance(string AccountNumber)
        {
            //Fetching Account Balance
            Random r = new Random();
            int Balance = r.Next(100000);
            return Balance;
        }
    }
}
