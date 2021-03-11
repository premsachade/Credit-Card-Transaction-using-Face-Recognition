using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public class Current : Account
    {
        public Current()
        {
        }
        public Current(string PIN, string acNo, decimal acBal) : base(PIN, acNo, acBal)
        {
        }
    }
}