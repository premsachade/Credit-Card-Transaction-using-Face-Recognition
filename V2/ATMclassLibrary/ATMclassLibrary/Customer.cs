using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public class Customer
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _pinNumber;
        public string pinNumber
        {
            get { return _pinNumber; }
            set { _pinNumber = value; }
        }
        public Customer()
        {
        }
        public Customer(string name, string PIN)
        {
            Name = name;
            pinNumber = PIN;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetPIN()
        {
            return pinNumber;
        }
    }
}
