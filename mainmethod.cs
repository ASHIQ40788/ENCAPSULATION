using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATIONprog
{
    class BankUser
    {
            public static void Main()
            {
                Bank SBI = new Bank();
                SBI.setBalance(150040788);
                Console.WriteLine(SBI.getBalance());
                Console.WriteLine("Press any key to exist.");
                Console.ReadKey();
            }
    }
    
}
