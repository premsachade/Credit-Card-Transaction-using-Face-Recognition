using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public class Saving : Account
    {
        private const decimal interestRate = 0.365m;
        public Saving()
        {
        }
        public Saving(string PIN, string acNo, decimal acBal) : base(PIN, acNo, acBal)
        {
        }
        public decimal payinterest()
        {
            acBalance = acBalance + interestRate;
            return acBalance;
        }
    }
}
