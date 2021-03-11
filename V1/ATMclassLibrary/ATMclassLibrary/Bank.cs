using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public class Bank : Account
    {
        public const decimal maximumTopUp = 4000000;
        public const decimal refillamount = 1500000;
        public Bank()
        {
        }
        public Bank(string PIN, string acNo, decimal acBal) : base(PIN, acNo, acBal)
        {
        }
        public void refillATM()
        {
            try
            {
                while (acBalance + refillamount <= maximumTopUp)
                {
                    acBalance += refillamount;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
