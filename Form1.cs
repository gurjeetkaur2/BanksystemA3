namespace BankSystem
{
    public partial class Form1 : Form
    {

        //Customer class object
        /*Customer customer_1 = new Customer("Steve", 123456);

        // Creating objects from Acoounts classes
        EverydayAccount everydayAccount = new EverydayAccount(1000);
        InvestmentAccount investmentAccount = new InvestmentAccount(1000);
        OmniAccount omniAccount = new OmniAccount(1000);*/

        private Customer customer;
        private Account? account;

        private Account selectedAccount;

        private EverydayAccount everydayAccount;
        private Investment interestAccount;
        private Omni omniAccount;



        private List<Account> accounts;
        public void SetCustomer(Customer selectedCustomer)
        {
            customer = selectedCustomer;
            labelCustomer.Text = $"Welcome, {customer.Name}";

        }


        public Form1()
        {
            InitializeComponent();

            accounts = new List<Account>();


            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            //accountComboBox.SelectedIndexChanged += accountComboBox_SelectedIndexChanged;

            // Initialize instances of the child account classes
            everydayAccount = new EverydayAccount(1000, customer);
            interestAccount = new Investment(1000, customer);
            omniAccount = new Omni(1000, customer);

            listBox2.Items.Add(everydayAccount);
            listBox2.Items.Add(interestAccount);
            listBox2.Items.Add(omniAccount);

            listBox2.SelectedIndex = 0;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selectedAccount = (Account)listBox2.SelectedItem;
            if (selectedAccount != null)
            {
                UpdateInfo(selectedAccount);
                //infoLabel.Text = $"You selected an {selectedAccount.AccountType}.";
                label2.Text = string.Empty;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add child account instances to the ComboBox
            //accountComboBox.Items.Add(everydayAccount);
            //accountComboBox.Items.Add(interestAccount);
            //accountComboBox.Items.Add(omniAccount);

            // Select the first item by default
            //accountComboBox.SelectedIndex = 0;


            //labelCustomer.Text = $"Welcome, {customer.Name}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                account = (Account)listBox2.SelectedItem;

                if (amountTextBox.Text != null && double.TryParse(amountTextBox.Text, out double amount) && amount > 0)
                {
                    account.Deposite(amount);

                    label2.Text = $"Deposited {amount:C} into {account.AccountType}.";
                    amountTextBox.Clear();
                    UpdateInfo(account);
                }
                else
                {
                    MessageBox.Show("Please enter a valid deposit amount.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                account = (Account)listBox2.SelectedItem;

                //double fee  = account.customer != null && customer.IsStaff ? 20 : 20 * 0.5;

                if (amountTextBox.Text != null && double.TryParse(amountTextBox.Text, out double amount) && amount > 0)
                {
                    account.Withdraw(amount);
                    //account.balance -= fee;

                    UpdateInfo(account);
                    label2.Text = $"withdraw {amount:C} from {account.AccountType}.";
                    amountTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid withdraw amount.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                account = (Account)listBox2.SelectedItem;

                if (amountTextBox.Text != null && double.TryParse(amountTextBox.Text, out double interestRate) && interestRate > 0)
                {
                    account.Interest(interestRate);

                    UpdateInfo(account);
                    label2.Text = $"Interest calculated by using {interestRate:C} rate for {account.AccountType}.";
                    amountTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Interest amount.");
                }
            }
        }
        public void UpdateInfo(Account account)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(account.GetInfo());

        }
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transfer_money transferForm = new transfer_money(new List<Account> { everydayAccount, interestAccount, omniAccount });
            transferForm.TransferCompleted += TransferForm_TransferCompleted;
            transferForm.Show();
        }

        private void TransferForm_TransferCompleted(object sender, TransferCompletedEventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(e.TransferDetails);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateNewAccount createAccountForm = new CreateNewAccount();
            if (createAccountForm.ShowDialog() == DialogResult.OK)
            {
                Account newAccount = createAccountForm.SelectedAccount;
                if (accounts != null)
                {
                    accounts.Add(newAccount);
                    listBox2.Items.Add(newAccount);
                    listBox2.SelectedItem = newAccount;
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomerForm = new ManageCustomer();
            manageCustomerForm.Show();
            this.Close();
        }
    }
}
