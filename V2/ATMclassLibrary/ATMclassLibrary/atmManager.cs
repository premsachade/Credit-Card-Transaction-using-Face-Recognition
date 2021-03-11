using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATMclassLibrary
{
    public class atmManager
    {
        public CurrentAccount currentAccounts = new CurrentAccount();
        public SavingAccounts savingAccounts = new SavingAccounts();
        public Customers customers = new Customers();
        string currentPath = (Environment.CurrentDirectory);
        public Bank bank;
        public Current currentAccount = new Current();
        public Saving savingAccount = new Saving();
        public Customer customer = new Customer();
        public bool loadBank()
        {
            bool precessSucess = false;
            string PIN;
            string acNo;
            decimal acBal;
            try
            {
                string[] entries;
                string AccountsFile = (currentPath + "\\Accounts.txt");
                StreamReader streamReader = new StreamReader(AccountsFile);
                string line;
                line = streamReader.ReadLine();
                while (line != null)
                {
                    entries = line.Split(',');
                    if (entries[0] == "B")
                    {
                        PIN = (entries[1]).ToString();
                        acNo = (entries[2]).ToString();
                        acBal = Convert.ToDecimal(entries[3]);
                        bank = new Bank(PIN, acNo, acBal);
                        precessSucess = true;
                    }
                    else if (entries[0] == "C")
                    {
                        PIN = (entries[1]).ToString();
                        acNo = (entries[2]).ToString();
                        acBal = Convert.ToDecimal(entries[3]);
                        Current checking = new Current(PIN, acNo, acBal);
                        currentAccounts.AddCurrent(checking);
                    }
                    else if (entries[0] == "S")
                    {
                        PIN = (entries[1]).ToString();
                        acNo = (entries[2]).ToString();
                        acBal = Convert.ToDecimal(entries[3]);
                        Saving saving = new Saving(PIN, acNo, acBal);
                        savingAccounts.addSavin(saving);
                    }
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
                precessSucess = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return precessSucess;
        }
        public bool loadCustomer()
        {
            string name;
            string Pin;
            string[] entries;
            string CustomerFile = (currentPath + "\\Customers.txt");
            StreamReader customerReader = new StreamReader(CustomerFile);
            string line;
            line = customerReader.ReadLine();
            bool precessSucess = false;
            try
            {
                while (line != null)
                {
                    entries = line.Split(',');
                    name = entries[0].ToString();
                    Pin = entries[1].ToString();
                    Customer cu = new Customer(name, Pin);
                    customers.addCustomer(cu);
                    line = customerReader.ReadLine();
                }
                customerReader.Close();
                precessSucess = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return precessSucess;
        }
        public bool validateUser(string name, string pin)
        {
            bool userOk = false;
            try
            {
                foreach (Customer Cust in customers)
                {
                    if (Cust.Name == name)
                    {
                        if (Cust.pinNumber == pin)
                        {
                            userOk = true;
                            customer = Cust;
                            loadsaving(Cust.pinNumber);
                            loadcurrent(Cust.pinNumber);
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return userOk;
        }
        public bool validateUserF(string name)
        {
            bool userOk = false;
            try
            {
                foreach (Customer Cust in customers)
                {
                    if (Cust.Name == name)
                    {
                        userOk = true;
                        customer = Cust;
                        loadsaving(Cust.pinNumber);
                        loadcurrent(Cust.pinNumber);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return userOk;
        }
        public bool loadsaving(string cuPin)
        {
            bool precessSucess = false;
            foreach (Saving sv in savingAccounts)
            {
                if (cuPin == sv.pinnumber)
                {
                    savingAccount = sv;
                    precessSucess = true;
                }
            }
            return precessSucess;
        }
        public bool loadcurrent(string cuPin)
        {
            bool precessSucess = false;
            foreach (Current chkacc in currentAccounts)
            {
                if (cuPin == chkacc.pinnumber)
                {
                    currentAccount = chkacc;
                    precessSucess = true;
                }
            }
            return precessSucess;
        }
        public bool CurrentWithdraw(string pin, decimal amount)
        {
            bool ProcessPermission = false;
            decimal tencondiction = amount % 100;
            if (amount <= 25000 && tencondiction == 0)
            {
                ProcessPermission = true;
                currentAccount.withdraw(amount);
            }
            return ProcessPermission;
        }
        public bool CurrentWithdrawF(decimal amount)
        {
            bool ProcessPermission = false;
            decimal tencondiction = amount % 100;
            if (amount <= 25000 && tencondiction == 0)
            {
                ProcessPermission = true;
                currentAccount.withdraw(amount);
            }
            return ProcessPermission;
        }
        public bool savingWithdraw(string pin, decimal amount)
        {
            bool ProcessPermission = false;
            decimal tencondiction = amount % 100;
            if (amount <= 25000 && tencondiction == 0)
            {
                ProcessPermission = true;
                savingAccount.withdraw(amount);
            }
            return ProcessPermission;
        }
        public bool savingWithdrawF(decimal amount)
        {
            bool ProcessPermission = false;
            decimal tencondiction = amount % 100;
            if (amount <= 25000 && tencondiction == 0)
            {
                ProcessPermission = true;
                savingAccount.withdraw(amount);
            }
            return ProcessPermission;
        }
        public decimal DisplayCurrentBalance()
        {
            decimal balance = currentAccount.acBalance;
            return balance;
        }
        public decimal DisplaySavingBalance()
        {
            decimal balance = savingAccount.acBalance;
            return balance;
        }
        public void WriteAccount()
        {
            try
            {
                string currentInfo;
                string bankInfo;
                string savingInfo;
                string AccountsFile = (currentPath + "\\Accounts.txt");
                StreamWriter streamWriter = new StreamWriter(AccountsFile);
                bankInfo = "B," + bank.pinnumber.ToString() + "," + bank.acNumber.ToString() + "," + bank.acBalance.ToString();
                streamWriter.WriteLine(bankInfo);
                foreach (Current check in currentAccounts)
                {
                    currentInfo = "C," + check.pinnumber.ToString() + "," + check.acNumber.ToString() + "," + check.acBalance.ToString();
                    streamWriter.WriteLine(currentInfo);
                }
                foreach (Saving sv in savingAccounts)
                {
                    savingInfo = "S," + sv.pinnumber.ToString() + "," + sv.acNumber.ToString() + "," + sv.acBalance.ToString();
                    streamWriter.WriteLine(savingInfo);
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}