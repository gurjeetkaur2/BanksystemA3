using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankSystem
{
    public partial class ManageCustomer : Form
    {
        Controller controller = new Controller();
        private int selectedCustomerIndex = -1;

        public ManageCustomer()
        {
            InitializeComponent();
            LoadCustomerData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string contact = textBox3.Text;
            bool isStaff = checkBox1.Checked;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }
            if (int.TryParse(contact, out int contactDetail))
            {
                controller.AddCustomer(name, contactDetail, isStaff);
                string customerInfo = $" Name: {name}, Contact: {contactDetail}, IsStaff: {(isStaff ? "Yes" : "No")}";
                listBox1.Items.Add(customerInfo);
                SaveControllerData();
            }

            // Clear the input fields
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;


            selectedCustomerIndex = -1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomerIndex = listBox1.SelectedIndex;

            if (selectedCustomerIndex >= 0)
            {
                Customer selectedCustomer = controller.GetCustomer(selectedCustomerIndex);
                textBox2.Text = selectedCustomer.Name;
                textBox3.Text = selectedCustomer.Phone.ToString();
                checkBox1.Checked = selectedCustomer.IsStaff;

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                checkBox1.Enabled = true;
            }
            else
            {
                textBox2.Clear();
                textBox3.Clear();
                checkBox1.Checked = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                checkBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedCustomerIndex >= 0)
            {
                string newName = textBox2.Text;
                string contact = textBox3.Text;
                bool newStaff = checkBox1.Checked;

                if (int.TryParse(contact, out int newContact))
                {
                    controller.UpdateCustomer(newName, newContact, newStaff);
                    string updatedCustomerInfo = $"Name: {newName}, Contact: {newContact}, IsStaff: {(newStaff ? "Yes" : "No")}";
                    listBox1.Items[selectedCustomerIndex] = updatedCustomerInfo;
                    SaveControllerData();

                }
                else
                {
                    MessageBox.Show("please enter a valid contact number..");
                }

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (selectedCustomerIndex >= 0 && selectedCustomerIndex < listBox1.Items.Count)
            {
                controller.DeleteCustomer(selectedCustomerIndex);
                listBox1.Items.RemoveAt(selectedCustomerIndex);


            }

            selectedCustomerIndex = -1;

            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            checkBox1.Enabled = true;
            SaveControllerData();
        }

        private void LoadCustomerData()
        {
            BinaryFormatter bf = new BinaryFormatter();
            // Deserialization
            try
            {
                using (FileStream fsin = new FileStream("customers.binary", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    controller = (Controller)bf.Deserialize(fsin);
                }

                // Update the ListBox with the loaded data
                UpdateListBox();
                //MessageBox.Show("Object deserialized.");
            }
            catch
            {
                MessageBox.Show("Something went wrong during deserialization.");
            }
        }
        private void UpdateListBox()
        {
            // Clear the ListBox
            listBox1.Items.Clear();

            // Add items from the controller's data
            foreach (var customer in controller.GetCustomers())
            {
                string customerInfo = $"Name: {customer.Name}, Contact: {customer.Phone}, IsStaff: {(customer.IsStaff ? "Yes" : "No")}";
                listBox1.Items.Add(customerInfo);
            }
        }

        private void SaveControllerData()
        {
            BinaryFormatter bf = new BinaryFormatter();

            // Serialization
            try
            {
                using (FileStream fsout = new FileStream("customers.binary", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    bf.Serialize(fsout, controller);
                }
                MessageBox.Show("Object serialized.");
            }
            catch
            {
                MessageBox.Show("An error occurred during serialization.");
            }
        }


        private void ManageCustomer_Load(object sender, EventArgs e)
        {

        }

        private void manage_Customer_Click(object sender, EventArgs e)
        {
            if (selectedCustomerIndex >= 0 && listBox1.Items[selectedCustomerIndex] is string customerInfo)
            {
                string[] customerDetails = customerInfo.Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string name = customerDetails[1].Trim();
                int contact = int.Parse(customerDetails[3].Trim());
                bool isStaff = customerDetails[5].Trim() == "Yes";

                Form1 form1 = new Form1();
                form1.SetCustomer(new Customer(name, contact, isStaff));

                form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a customer before managing.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogInChoices logInChoices = new LogInChoices();
            logInChoices.Show();
            this.Close();

        }
    }
}