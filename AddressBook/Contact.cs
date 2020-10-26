using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Contact
    {
        /// <summary>
        /// Variables
        /// </summary>
        private String fname;
        private String lname; 
        private String add;  
        private String city; 
        private String state; 
        private long phonenumber; 
        private int zip; 

        /// <summary>
        /// Contacts the specified details.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="add">The add.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="phonenumber">The phonenumber.</param>
        /// <param name="pin">The pin.</param>
        public Contact(String fname, String lname, String add, String city, String state, long phonenumber, int pin)
        {
            this.fname = fname;
            this.lname = lname;
            this.add = add;
            this.city = city;
            this.state = state;
            this.phonenumber = phonenumber;
            this.zip = pin;
        }
        /// Returns the first name of a Contact
        public String GetfName()
        {
            return fname;
        }

        /// Returns the last name of a Contact
        public String GetlName()
        {
            return lname;
        }

        /// Returns the address of a Contact
        public String GetAdd()
        {
            return add;
        }

        /// Returns the city of a Contact
        public String GetCity()
        {
            return city;
        }

        /// Returns the state of a Contact
        public String GetState()
        {
            return state;
        }

        /// Returns the phone number of a Contact
        public long GetNumber()
        {
            return phonenumber;
        }

        /// Returns the zip number of a Contact
        public int GetZip()
        {
            return zip;
        }

        /// <summary>
        /// Prints the contact.
        /// </summary>
        public void PrintContact()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("First Name: " +fname);
            Console.WriteLine("LastName: " +lname);
            Console.WriteLine("Address: " +add);
            Console.WriteLine("City: " +city);
            Console.WriteLine("State: " +state);
            Console.WriteLine("Phone Number: " +phonenumber);
            Console.WriteLine("Zip: " +zip);
        }
    }
}
