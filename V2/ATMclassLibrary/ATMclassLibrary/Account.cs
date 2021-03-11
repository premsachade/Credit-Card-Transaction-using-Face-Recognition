using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public abstract class Account
    {
        private string _pinnumber;
        public string pinnumber
        {
            get { return _pinnumber; }
            set { _pinnumber = value; }
        }
        private string _acNumber;
        public string acNumber
        {
            get { return _acNumber; }
            set { _acNumber = value; }
        }
        private decimal _acBalance;
        public decimal acBalance
        {
            get { return _acBalance; }
            set { _acBalance = value; }
        }
        private decimal _maxWithdraw;
        public decimal maxWithdraw
        {
            get { return _maxWithdraw; }
            set { _maxWithdraw = value; }
        }
        public Account()
        {
        }
        public Account(string PIN, string acNo, decimal acBal, decimal acMaxdraw)
        {
            pinnumber = PIN;
            acNumber = acNo;
            acBalance = acBal;
            maxWithdraw = acMaxdraw;
        }
        public Account(string PIN, string acNo, decimal acBal)
        {
            pinnumber = PIN;
            acNumber = acNo;
            acBalance = acBal;
            maxWithdraw = 100000;
        }
        public decimal withdraw(decimal wdAmount)
        {
            try
            {
                acBalance -= wdAmount;
            }
            catch (Exception e)
            { throw new Exception(e.Message); }
            return acBalance;
        }
        public string GetPin()
        {
            return pinnumber;
        }
        public string GetAcNumber()
        {
            return acNumber;
        }
        public decimal GetBalance()
        {
            return acBalance;
        }
    }
}
