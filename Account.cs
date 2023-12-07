using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public class Account
    {
        public Customer customer { get; private set; }

        private static int currentID = 60;
        public int Id { get; private set; }

        public string AccountType { get; set; }


        public double balance;

        public override string ToString()
        {
            return AccountType;
        }

        public Account(double accountBalance, Customer customer)
        {
            Id = ++currentID;
            balance = accountBalance;
            this.customer = customer;
        }
        public void SetCustomer(Customer customer)
        {
            this.customer = customer;
        }

        //deposite method 
        public virtual void Deposite(double depositeAmount)
        {
            balance += depositeAmount;

        }

        //withdraw method
        public virtual void Withdraw(double withdrawAmount)
        {

        }

        public virtual void Interest(double interestRate)
        {

        }
        public virtual bool Transfer(Account toAccount, double transferAmount)
        {
            if (transferAmount <= 0)
            {
                MessageBox.Show("Transfer amount must be greater than zero.");
                return false;
            }

            if (this == toAccount)
            {
                MessageBox.Show("Source and destination accounts cannot be the same.");
                return false;
            }

            if (this.balance < transferAmount)
            {
                MessageBox.Show("Insufficient funds for the transfer.");
                return false;
            }

            this.Withdraw(transferAmount);
            toAccount.Deposite(transferAmount);

            return true;
        }
    



    public virtual string GetInfo()
        {
            return $"{AccountType}  ${balance}";
        }
    }


    public class EverydayAccount : Account
    {
        public EverydayAccount(double accountBalance, Customer customer) : base(accountBalance, customer)
        {
            AccountType = "Everyday Account";
            balance = accountBalance;

        }

        public override void Deposite(double depositeAmount)
        {
            balance += depositeAmount;
        }

        public override void Withdraw(double withdrawAmount)
        {
            try
            {
                if (balance <= withdrawAmount)
                {
                    throw new InvalidOperationException("No Overdraft allowed!!");
                }
                else
                {
                    balance -= withdrawAmount;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public override string GetInfo()
        {

            return $"{AccountType} {Id}  has ${balance}; No Interest, No Overdraft, No Fees  ";
        }
    }
    public class Investment : Account
    {
        public double interest = 0.02;
        public double fee = 10;

        public Investment(double accountBalance, Customer customer) : base(accountBalance, customer)
        {
            AccountType = "Investment Account";
            balance = accountBalance;

        }

        public override void Interest(double interestRate)
        {
            double interestAmount = balance * (interestRate / 100);
            balance += interestAmount;

        }
       

        public override void Deposite(double depositeAmount)
        {
            balance += depositeAmount;

        }
        public override void Withdraw(double withdrawAmount)
        {
            try
            {
                double fee = 0;
                if (customer != null && customer.IsStaff)
                {
                    fee = 10 * 0.5;
                }
                else
                {
                    fee = 10;
                }

                if (balance <= withdrawAmount)
                {
                    balance  -= fee;
                    throw new WithdrawalException(withdrawAmount, balance);
                }
                else
                {
                    balance -= withdrawAmount;
                }
            }
            catch (WithdrawalException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        public override string GetInfo()
        {
            return $"{AccountType} {Id}  has ${balance}; Interest Rate is 2%, No Overdraft, Fees $10 ";

        }

    }


    public class Omni : Account
    {

        public double minimumBalance = 1000;
        public double limit = -200;
        public double fee = 20;
        public Omni(double accountBalance, Customer customer) : base(accountBalance, customer )
        {
            AccountType = "Omni Account";
            balance = accountBalance;

        }

        public override void Interest(double interestRate)
        {
            if (balance > minimumBalance)
            {
                double interestAmount = balance * (interestRate / 100);
                balance += interestAmount;
            }
        }
        public override void Deposite(double depositeAmount)
        {
            balance += depositeAmount;

        }
        public override void Withdraw(double withdrawAmount)
        {
            try
            {
                double fee = 0;
                if (customer != null && customer.IsStaff )
                {
                    fee = 20 * 0.5;
                }
                else
                {
                    fee = 20;
                }
                if (withdrawAmount >= limit + balance)
                {
                    balance -= fee;
                    throw new WithdrawalException(withdrawAmount, balance);
                }
                else
                {
                    balance -= withdrawAmount;
                }
            }
            catch (WithdrawalException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public override string GetInfo()
        {
            return $"{AccountType} {Id}  has ${balance}; Interest Rate is 2.5%, Overdraft limit $200, Fees $20 ";

        }

    }
}

