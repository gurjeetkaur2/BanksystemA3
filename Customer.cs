using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    [Serializable]
    public class Customer
    {
        private static int CustomerNumber = 2000;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public bool IsStaff { get; set; }
        public List<Account> Accounts { get; set; } // List to store different Accounts



        //constructor
        public Customer(string name, int contact, bool isStaff)
        {
            Id = ++CustomerNumber;
            Name = name;
            Phone = contact;
            IsStaff = isStaff;
            
        }
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public double CalculateFee(double fee = 10)
        {
            return fee = IsStaff ? fee : fee * 0.5;
        }
    }
}
