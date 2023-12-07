using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace BankSystem

    /// <summary>
    /// Controller class managing the bank's customer information.
    /// </summary>
{
    [Serializable]
    internal class Controller
    {

        /// <summary>
        /// List containing all bank customers.
        /// </summary> 
        
        public List<Customer> AllCustomer = new List<Customer>();
        private int selectedCustomerIndex;


        /// <summary>
        /// Adds a new customer to the bank system.
        /// </summary>
        /// <param name="name">Name of the customer.</param>
        /// <param name="contact">Contact information of the customer.</param>
        /// <param name="isStaff">Determines if the customer is staff or not.</param>
        public void AddCustomer(string name, int contact, bool isStaff)

        {
            AllCustomer.Add(new Customer(name, contact, isStaff));
        }


        /// <summary>
        /// Retrieves a specific customer from the bank system based on the index.
        /// </summary>
        /// <param name="customerIndex">Index of the customer to retrieve.</param>
        /// <returns>The Customer object if found, otherwise null.</returns>
        public Customer GetCustomer(int customerIndex)
        {
            if (customerIndex >= 0 && customerIndex < AllCustomer.Count)
            {
                return AllCustomer[customerIndex];
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Updates the details of a customer in the bank system.
        /// </summary>
        /// <param name="newName">New name for the customer.</param>
        /// <param name="newContact">New contact information for the customer.</param>
        /// <param name="newStaff">New staff status for the customer.</param>
        public void UpdateCustomer(string newName, int newContact, bool newStaff)
        {
            if (selectedCustomerIndex >= 0 && selectedCustomerIndex < AllCustomer.Count)
            {
                Customer customerToUpdate = AllCustomer[selectedCustomerIndex];
                customerToUpdate.Name = newName;
                customerToUpdate.Phone = newContact;
                customerToUpdate.IsStaff = newStaff;
            }
            else
            {
                MessageBox.Show("please select a valid index");


            }
        }

        /// <summary>
        /// Deletes a customer from the bank system based on the selected index.
        /// </summary>
        /// <param name="selectedCustomerIndex">Index of the customer to delete.</param>
        public void DeleteCustomer(int selectedCustomerIndex)
        {
            if (selectedCustomerIndex >= 0 && selectedCustomerIndex < AllCustomer.Count)
            {
                AllCustomer.RemoveAt(selectedCustomerIndex);
            }
        }

        /// <summary>
        /// Retrieves a list of all customers in the bank system.
        /// </summary>
        /// <returns>List of Customer objects.</returns>
        public List<Customer> GetCustomers()
        {
            return AllCustomer;
        }
    }
        
}
