using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATIONprog
{
    public class Bank
    {
        //hiding class data by declaring the variable as private
        private double balance;
        //creating public setter and getter methods
        public double getBalance()
        {
            //add validation logic if needed
            return balance;
        }
        public void setBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }
    }
    
}