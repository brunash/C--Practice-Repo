﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class AddressRepository
    {
        // retrieve one address
        public Address Retrieve(int addressId)
        {
            // create the instance of the address class
            // pass in the requested Id
            Address address = new Address(addressId);
            

            //code that retrieves the defined address
            
            //temporary hard coded values to return a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.


            // Temporary hard-coded values to return 
            // a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        // saves the current address
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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