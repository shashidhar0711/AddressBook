using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// Printing welcome message
            Console.WriteLine("Welcome to Address Book");
            /// Creating a Reference of AddressBook
            AddressBook addressBook = new AddressBook();
            addressBook.BookManagementView();
        }
    }
}
