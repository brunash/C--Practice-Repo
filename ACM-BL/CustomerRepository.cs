using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class CustomerRepository
    {
        public CustomerRepository ()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get;set;}


        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            // Code that retrieves the defined customer
            //Temp hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).
                                                ToList();
                //toList is a link method to return results as a list
            }
            return customer;
        }
        

        //Saves the current customer
        public bool Save(Customer customer)
        {
            //code that saves the passed in customer
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Call an Insert Stored Procedure

                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
