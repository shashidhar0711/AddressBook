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
        /// Sets the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        /// <summary>
        /// Sets the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        /// <summary>
        /// Sets the address.
        /// </summary>
        /// <param name="address">The address.</param>
        public void SetAddress(string address)
        {
            this.address = address;
        }

        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <param name="city">The city.</param>
        public void SetCity(string city)
        {
            this.city = city;
        }

        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void SetState(string state)
        {
            this.state = state;
        }

        /// <summary>
        /// Sets the zip.
        /// </summary>
        /// <param name="zip">The zip.</param>
        public void SetZip(int zip)
        {
            this.zip = zip;
        }

        /// <summary>
        /// Sets the phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        public void SetPhoneNumber(long phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string Tostring()
        {
            return "FirstName : " + firstName + " LastName : " + lastName + " Address : " + address + " City : " + city + "State : " + state +
                " Zip Code :" + zip + " Phone Number : " + phoneNumber;
        }
    }
}

