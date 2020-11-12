using System;

namespace AddressBook
{
    class Program
    {
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
