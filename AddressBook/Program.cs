/// Including the requried assemblies in to the program
using System;

namespace AddressBook
{
    class Program
    {
        public String fname; // Stores first name of Contact
        public String lname; // Stores last name of Contact
        public String add;  // Stores address of Contact
        public String city; // Stores city of Contact
        public String state; // Stores state of Contact
        public int phonenumber; // Stores phone number of contact
        public int zip;  // Stores zip of Contact int 

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(String[] args)
        {
            /// Creating Object for Program Class
            Program program = new Program();
        }

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
        public void Contact(String fname, String lname, String add, String city, String state, int phonenumber, int pin)
        {
            this.fname = fname;
            this.lname = lname;
            this.add = add;
            this.city = city;
            this.state = state;
            this.phonenumber = phonenumber;
            this.zip = pin;
        }
        // Returns the first name of a Contact
        public String getfName()
        {
            return fname;
        }

        // Returns the last name of a Contact
        public String getlName()
        {
            return lname;
        }

        // Returns the address of a Contact
        public String getAdd()
        {
            return add;
        }

        // Returns the city of a Contact
        public String getCity()
        {
            return city;
        }

        // Returns the state of a Contact
        public String getState()
        {
            return state;
        }

        // Returns the phone number of a Contact
        public int getNumber()
        {
            return phonenumber;
        }

        // Returns the zip number of a Contact
        public int getZip()
        {
            return zip;
        }

        /// <summary>
        /// Prints the contact.
        /// </summary>
        public void printContact()
        {
            Console.WriteLine("Name: " + fname + " " + lname + ", Address: " + add + ", City: " + city + ", State: " + state);
            Console.WriteLine(", Phone#: " + phonenumber + ", Pin Code: " + zip + ".");
        }
    }
}
