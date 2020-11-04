using System;

namespace AddressBook
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Printing Welcome Message
            Console.WriteLine("Welcome to Address Book");
            /// Creating a Reference of AddressBook
            AddressBook addressBook = new AddressBook();
            addressBook.BookManagementView();
        }
    }
}
