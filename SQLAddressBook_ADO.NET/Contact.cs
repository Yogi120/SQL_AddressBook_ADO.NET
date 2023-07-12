﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAddressBook_ADO.NET
{
    public class Contact
    {
        public string Name;
        public string PhoneNumber;
        public string Email;
        public string State;
        public string City;
        public string ZipCode;
        public int Id;

        public Contact()
        {
            
        }
        public Contact(string name, string phoneNumber, string email, string state, string city, string zipCode)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            State = state;
            City = city;
            ZipCode = zipCode;
        }
    }
}
