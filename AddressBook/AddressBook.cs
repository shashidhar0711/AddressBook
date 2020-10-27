using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        /// <summary>
        /// The contact list
        /// </summary>
        List<Contact> ContactList;
        private int choice;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        public AddressBook()
        {
            ContactList = new List<Contact>();
        }

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
            Contact contact= new Contact(firstName, lastName, address, city, phoneNumber, zip);
            ContactList.Add(contact);
            Console.WriteLine(contact);
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();

            /// By Looping Untill Condtions Ends
            for(int index =0; index <= ContactList.Count; index++)
            {
                /// Checking If Exist FirstName or not to purpose Edit
                if (!ContactList[index].GetFirstName().Equals(firstName))
                {
                    Console.WriteLine("Does not Exist");
                }
                else
                {
                    do
                    {
                        /// It takes Choice to Edit at Particualar Position
                        int choice = UserChoiceForEdit();
                        EditContactList(ContactList[index], choice);
                    } while (choice != 7);
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

            switch(choice)
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
        /// Users the menu.
        /// </summary>
        public void UserMenu()
        {
            Console.WriteLine("Enter ur Choice:");
            Console.WriteLine("Press 1 to Add contact");
            Console.WriteLine("Press 2 to Edit contact");
            Console.WriteLine("Press 3 to Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                   EditContact();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}
