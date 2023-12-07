using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class CreateNewAccount : Form
    {
        public Account SelectedAccount { get; private set; }
        Customer customer;

        public CreateNewAccount()
        {
            InitializeComponent();
            comboBox2.Items.Add("Everyday Account");
            comboBox2.Items.Add("Investment Account");
            comboBox2.Items.Add("Omni Account");

            CreateNewAccountButton.Click += CreateNewAccountButton_Click;
        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewAccountButton_Click(object sender, EventArgs e)
        {
            if (comboBox2 != null)
            {
                string selectedAccountType = (string)comboBox2.SelectedItem;
                if (double.TryParse(textBox2.Text, out double initialAmount))
                {
                    // Create a new account based on the selected type and initial amount
                    switch (selectedAccountType)
                    {
                        case "Everyday Account":
                            SelectedAccount = new EverydayAccount(initialAmount, customer);
                            break;
                        case "Investment Account":
                            SelectedAccount = new Investment(initialAmount, customer);
                            break;
                        case "Omni Account":
                            SelectedAccount = new Omni(initialAmount, customer);
                            break;
                        default:
                            break;
                    }

                    DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    MessageBox.Show("Please enter a valid initial amount.");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
