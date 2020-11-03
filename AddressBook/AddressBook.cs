using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        /// <summary>
        /// The contact list
        /// </summary>
        List<Contact> ContactList = new List<Contact>();

        /// <summary>
        /// The address book dictionary
        /// </summary>
        private Dictionary<string, AddressBook> AddressBookDictionary = new Dictionary<string, AddressBook>();

        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your city name");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enteryour zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Contact contact = new Contact(firstName, lastName, address, city, phoneNumber, zip);
            ContactList.Add(contact);
            Console.WriteLine("Contact created");
            //DisplayContact();
            //Console.WriteLine(contact.Tostring());

            CheckForDuplicateContacts(contact, firstName, lastName);
        }
        /// <summary>
        /// Checks for duplicate contacts.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        private void CheckForDuplicateContacts(Contact contact, string firstName, string lastName)
        {
            /// By Looping untill Condition Ends
            for (int index = 0; index < ContactList.Count; index++)
            {
                /// If Contact List contains First Name and Last Name ,It will prints Already Exist
                /// then Add the Contacts In AddressBook
                if (ContactList[index].GetFirstName().Equals(firstName) && ContactList[index].GetLastName().Equals(lastName))
                {
                    Console.WriteLine("Contact is already Exists in Address Book");
                }
                else
                {
                    ContactList.Add(contact);
                    Console.WriteLine("Contact Created Succesfully");
                }
            }
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact()
        {
            if(ContactList.Count == 0)
            {
                Console.WriteLine("Contact List is Currently empty!!");
            }
            else
            {
                Console.WriteLine("Enter your First Name");
                string firstName = Console.ReadLine();

                /// By Looping Untill Condtions Ends
                for (int index = 0; index < ContactList.Count; index++)
                {
                    /// Checking If Exist FirstName or not to purpose Edit
                    if (ContactList[index].GetFirstName().Equals(firstName))
                    {
                        /// It takes Choice to Edit at Particualar Position
                        int choice = UserChoiceForEdit();
                        EditContactList(ContactList[index], choice);
                    }
                    else
                    {
                        Console.WriteLine("Does not Exist");
                    }
                }
            }

        }

        /// <summary>
        /// Users the choice for edit.
        /// </summary>
        /// <returns></returns>
        public int UserChoiceForEdit()
        {
            Console.WriteLine("1 : Enter to Edit FirstName");
            Console.WriteLine("2 : Enter to Edit LastName");
            Console.WriteLine("3 : Enter to Edit Address");
            Console.WriteLine("4 : Enter to Edit City");
            Console.WriteLine("5 : Enter to Edit State");
            Console.WriteLine("6 : Enter to Edit PhoneNumber");
            Console.WriteLine("7 : Enter to Edit Zip");
            int choice = Convert.ToInt32(Console.ReadLine());

            /// It returns the Choice
            return choice;
        }

        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <param name="choice">The choice.</param>
        public void EditContactList(Contact contact, int choice)
        {

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first name");
                    string name = Console.ReadLine();
                    contact.SetFirstName(name);
                    break;
                case 2:
                    Console.WriteLine("Enter the last name");
                    string lastName = Console.ReadLine();
                    contact.SetLastName(lastName);
                    break;
                case 3:
                    Console.WriteLine("Enter address");
                    string address = Console.ReadLine();
                    contact.SetAddress(address);
                    break;
                case 4:
                    Console.WriteLine("Enter city");
                    string city = Console.ReadLine();
                    contact.SetCity(city);
                    break;
                case 5:
                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.SetState(state);
                    break;
                case 6:
                    Console.WriteLine("Enter Phone Number");
                    long phoneNumber = Convert.ToInt64(Console.ReadLine());
                    contact.SetPhoneNumber(phoneNumber);
                    break;
                case 7:
                    Console.WriteLine("Enter Zip code");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    contact.SetZip(zip);
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string lastName = Console.ReadLine();
            for (int index = 0; index < ContactList.Count; index++)
            {
                if (ContactList[index].GetFirstName().Equals(firstName) && ContactList[index].GetLastName().Equals(lastName))
                {
                    /// It Checks, if Exist Contact will be Removed or deleted
                    ContactList.Remove(ContactList[index]);
                    //ContactList.RemoveAt(index);
                    Console.WriteLine("Contact deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }
            }

        }

        /// <summary>
        /// Displays the contact.
        /// </summary>
        public void DisplayContact()
        {
            if (ContactList.Count != 0)
            {
                for (int index = 0; index < ContactList.Count; index++)
                {
                    Console.WriteLine(ContactList[index].GetFirstName());
                    Console.WriteLine(ContactList[index].GetLastName());
                    Console.WriteLine(ContactList[index].GetAddress());
                    Console.WriteLine(ContactList[index].GetCity());
                    Console.WriteLine(ContactList[index].GetState());
                    Console.WriteLine(ContactList[index].GetPhoneNumber());
                    Console.WriteLine(ContactList[index].GetZip());
                }
            }
            else
            {
                Console.WriteLine("No contact to display");
            }

        }

        /// <summary>
        /// management view to Create new address book 
        /// </summary>
        public void BookManagementView()
        {
            int choice;
            do
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("Press 1 to create New Address Book");
                Console.WriteLine("press 2 to Access Existing Adderss Book");
                Console.WriteLine("press 3 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        /// New Book Name 
                        string bookName = GetNewAddressBook();
                        if (AddressBookDictionary.ContainsKey(bookName) == true)
                        {
                            Console.WriteLine("Already exist");
                        }

                        /// Create a Refernce of AddressBook
                        /// Adding in to dictionary ie new book name
                        AddressBook addressBook = new AddressBook();
                        AddressBookDictionary.Add(bookName, addressBook);
                        Console.WriteLine("Contact created :" + bookName);
                        addressBook.UserMenu();
                        break;

                    case 2:
                        /// Old Book Name 
                        string oldBookName = GetBookNameToAccess();
                        if (AddressBookDictionary.ContainsKey(oldBookName) == true)
                        {
                            Console.WriteLine("Welcome to" + oldBookName);
                            AddressBookDictionary.GetValueOrDefault(oldBookName).UserMenu();
                        }
                        else
                        {
                            Console.WriteLine("Sorry! No such Address book exist");
                        }
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Enter Valid Choice between 1 to 3");
                        break;
                }
            } while (choice != 3);

        }

        /// <summary>
        /// Gets the book name to access.
        /// </summary>
        /// <returns></returns>
        public static string GetBookNameToAccess()
        {
            Console.WriteLine("Enter Book Name to Access");
            string contactOldBook = Console.ReadLine();
            return contactOldBook;
        }

        /// <summary>
        /// Gets the new address book.
        /// </summary>
        /// <returns></returns>
        public static string GetNewAddressBook()
        {
            Console.WriteLine("Enter the Book Name");
            string contactBook = Console.ReadLine();
            return contactBook;
        }

        /// <summary>
        /// Users the menu.
        /// </summary>
        public void UserMenu()
        {
            Console.WriteLine("Enter ur Choice:");
            Console.WriteLine("Press 1 to Add contact");
            Console.WriteLine("Press 2 to Edit contact");
            Console.WriteLine("Press 3 to Delete contact");
            Console.WriteLine("Press 4 to Display Contact");
            int choice = Convert.ToInt32(Console.ReadLine());

            /// By Using Switch Method to Perform Specified Operation
            switch (choice)
            {
                case 1:
                    AddContact();
                    DisplayContact();
                    break;
                case 2:
                    EditContact();
                    break;
                case 3:
                    DeleteContact();
                    break;
                case 4:
                    DisplayContact();
                    break;
                default:
                    Console.WriteLine("Enter a Valid Choice Try again :");
                    break;
            }
        }
    }
}