using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class transfer_money : Form
    {
        private List<Account> accounts;

        public transfer_money(List<Account> accounts)
        {

            InitializeComponent();
            this.accounts = accounts;

            comboBoxFrom.SelectedIndexChanged += comboBoxFrom_SelectedIndexChanged;
            comboBoxTo.SelectedIndexChanged += comboBoxTo_SelectedIndexChanged;

            comboBoxFrom.DataSource = accounts;
            comboBoxTo.DataSource = accounts.Except(new List<Account> { (Account)comboBoxFrom.SelectedItem }).ToList();
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selectedAccount = (Account)comboBoxFrom.SelectedItem;
            if (selectedAccount != null)
            {
                label1.Text = $"You selected an {selectedAccount.AccountType}.";
                comboBoxTo.DataSource = accounts.Except(new List<Account> { selectedAccount }).ToList();
            }
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selectedAccount = (Account)comboBoxTo.SelectedItem;
            if (selectedAccount != null)
            {
                label3.Text = $"You selected an {selectedAccount.AccountType}.";
            }
        }

        public event EventHandler<TransferCompletedEventArgs> TransferCompleted;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void transferAmountButton_Click(object sender, EventArgs e)
        {
            Account fromAccount = (Account)comboBoxFrom.SelectedItem;
            Account toAccount = (Account)comboBoxTo.SelectedItem;

            if (fromAccount != null && toAccount != null)
            {
                if (double.TryParse(amountTextBox.Text, out double amount) && amount > 0)
                {
                    if (amount < fromAccount.balance)
                    {
                        if (fromAccount.Transfer(toAccount, amount))
                        {
                            MessageBox.Show($"Success");
                            TransferCompleted?.Invoke(this, new TransferCompletedEventArgs($"transferred {amount:C} from {fromAccount.AccountType} to {toAccount.AccountType}"));
                            //this.Close();
                            //amountTextBox.Text = '';
                            
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid amount.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Withdrawal of the entire amount or overdrawn is not Allowed ");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive amount");
                }
            }
            else
            {
                MessageBox.Show("please select both the from and to account.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}



