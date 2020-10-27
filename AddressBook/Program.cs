using System;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Creating a Reference of AddressBook
            AddressBook addressBook = new AddressBook();
            addressBook.UserMenu();
        }
    }
}
