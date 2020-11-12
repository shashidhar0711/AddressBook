using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

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
        private Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();
        Dictionary<string, string> cityDictionary = new Dictionary<string, string>();
        Dictionary<string, string> stateDictionary = new Dictionary<string, string>();

        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter First Name :");
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
            Contact contact = new Contact(firstName, lastName, address, city, state, phoneNumber, zip);
            //ContactList.Add(contact);
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
            if (ContactList.Count == 0)
            {
                ContactList.Add(contact);
                Console.WriteLine("Contact created");
            }
            else
            {
                /// By Looping untill Condition Ends
                for (int index = 0; index < ContactList.Count; index++)
                {
                    /// If Contact List contains First Name and Last Name ,It will prints Already Exist
                    /// then Add the Contacts In AddressBook
                    if (ContactList[index].GetFirstName().Equals(firstName) && ContactList[index].GetLastName().Equals(lastName))
                    {
                        Console.WriteLine("Contact is already Exists in Address Book");
                        break;
                    }
                    else
                    {
                        ContactList.Add(contact);
                        Console.WriteLine("Contact Created Succesfully");
                    }
                }
            }
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact()
        {
            if (ContactList.Count == 0)
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
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("First Name : " + ContactList[index].GetFirstName());
                    Console.WriteLine("Last Name : " + ContactList[index].GetLastName());
                    Console.WriteLine("Address : " + ContactList[index].GetAddress());
                    Console.WriteLine("City : " + ContactList[index].GetCity());
                    Console.WriteLine("State : " + ContactList[index].GetState());
                    Console.WriteLine("Phone Number : " + ContactList[index].GetPhoneNumber());
                    Console.WriteLine("Zip Code : " + ContactList[index].GetZip());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");

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
                Console.WriteLine("press 3 to Search Contact by City or state attribute");
                Console.WriteLine("Press 4 to View Person by City or State and Count");
                Console.WriteLine("press 5 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        /// New Book Name 
                        string addressBookName = GetNewAddressBook();
                        if (addressBookDictionary.ContainsKey(addressBookName) == true)
                            do
                            {
                                Console.WriteLine("Already exist");
                                addressBookName = GetNewAddressBook();
                            } while (addressBookDictionary.ContainsKey(addressBookName) != false);

                        /// Create a Refernce of AddressBook
                        /// Adding in to dictionary ie new book name
                        AddressBook addressBook = new AddressBook();
                        addressBookDictionary.Add(addressBookName, addressBook);
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Contact created :" + addressBookName);
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        addressBook.UserMenu();
                        break;

                    case 2:
                        /// Old Book Name 
                        string oldAddressBookName = GetBookNameToAccess();
                        if (addressBookDictionary.ContainsKey(oldAddressBookName) == true)
                        {
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Welcome to : " + oldAddressBookName);
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                            addressBookDictionary.GetValueOrDefault(oldAddressBookName).UserMenu();
                        }
                        else
                        {
                            Console.WriteLine("Sorry! No such Address book exist");
                        }
                        break;

                    case 3:
                        if (addressBookDictionary.Count == 0)
                        {
                            Console.WriteLine("Not Found! Unbale to search by city");
                        }
                        else
                        {
                            SearchByCity();
                        }
                        break;

                    case 4:
                        /// It checks, if dictionary is empty
                        if (addressBookDictionary.Count == 0)
                        {
                            Console.WriteLine("Not Found! Unbale to search by city");
                        }
                        else
                        {
                            ViewingPersonByGivingCityOrState();
                        }
                        break;
                    case 5:
                        break;

                    default:
                        Console.WriteLine("Enter Valid Choice between 1 to 5");
                        break;
                }

            } while (choice != 5);

        }

        /// <summary>
        /// Viewings the state of the person by giving city or state.
        /// </summary>
        public void ViewingPersonByGivingCityOrState()
        {
            foreach (var key in addressBookDictionary.Keys)
            {
                /// currentAddressBook
                string currentAddressBook = key;
                /// By looping Untill Condition ends
                for (int index = 0; index < addressBookDictionary[currentAddressBook].ContactList.Count; index++)
                {
                    string firstName = addressBookDictionary[currentAddressBook].ContactList.ToArray()[index].GetFirstName();
                    string lastName = addressBookDictionary[currentAddressBook].ContactList.ToArray()[index].GetLastName();
                    string city = addressBookDictionary[currentAddressBook].ContactList.ToArray()[index].GetCity();
                    string state = addressBookDictionary[currentAddressBook].ContactList.ToArray()[index].GetState();
                    string name = firstName + " " + lastName;

                    /// Adding details in to dictionary
                    cityDictionary.Add(name, city);
                    stateDictionary.Add(name, state);
                }
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Contact by City");
            foreach (KeyValuePair<string, string> element in cityDictionary)
            {
                Console.WriteLine(element.Key + " == " + element.Value);
            }
            Console.WriteLine("Total Count By city :" + cityDictionary.Count);

            Console.WriteLine("Contact by state");
            foreach (KeyValuePair<string, string> elementOne in stateDictionary)
            {
                Console.WriteLine(elementOne.Key, " == " + elementOne.Value);
            }
            Console.WriteLine("Total Count By state :" + stateDictionary.Count);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Search the Contact by using city.
        /// </summary>
        public void SearchByCity()
        {
            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            foreach (var key in addressBookDictionary.Keys)
            {
                string currentAddressBook = key;
                for (int index = 0; index < addressBookDictionary[currentAddressBook].ContactList.Count; index++)
                {
                    if (addressBookDictionary[currentAddressBook].ContactList.ToArray()[index].GetCity().Equals(city))
                    {
                        Console.WriteLine("Contacts with city " + city + " as city in address book" + currentAddressBook + "\n"
                            + addressBookDictionary[currentAddressBook].ContactList.ToArray()[index].Tostring());
                    }
                    else
                    {
                        //Console.WriteLine("No such contacts present in any existing address book");

                    }
                }
            }

        }

        /// <summary>
        /// Gets the book name to access.
        /// </summary>
        /// <returns></returns>
        public static string GetBookNameToAccess()
        {
            Console.WriteLine("Enter Address Book Name to Access");
            string contactOldBook = Console.ReadLine();
            return contactOldBook;
        }

        /// <summary>
        /// Gets the new address book.
        /// </summary>
        /// <returns></returns>
        public static string GetNewAddressBook()
        {
            Console.WriteLine("Enter the New Address Book Name");
            string contactBook = Console.ReadLine();
            return contactBook;
        }

        /// <summary>
        /// Sorts the contact.
        /// </summary>
        public void SortByName()
        {
            /// creating list for names
            /// traversing through contactlist
            List<string> ListByName = new List<string>();
            foreach (Contact contact in ContactList)
            {
                /// Adding first names in to list 
                ListByName.Add(contact.GetFirstName());
            }

            /// sorting by names ie alphabetical order
            ListByName.Sort();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (var sortByName in ListByName)
            {
                Console.WriteLine(sortByName);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Sorts the by city.
        /// </summary>
        public void SortByCity()
        {
            /// creating list for city
            /// traversing through contactlist
            List<string> ListByCity = new List<string>();
            foreach (Contact contact in ContactList)
            {
                /// Adding city in to list 
                ListByCity.Add(contact.GetCity());
            }

            /// sorting by citys ie alphabetical order
            ListByCity.Sort();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (var sortByCity in ListByCity)
            {
                Console.WriteLine(sortByCity);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Sorts the name of the by.
        /// </summary>
        public void SortByState()
        {
            /// creating list for state
            /// traversing through contactlist
            List<string> ListByState = new List<string>();
            foreach (Contact contact in ContactList)
            {
                /// Adding states in to list 
                ListByState.Add(contact.GetState());
            }

            /// sorting by states ie alphabetical order
            ListByState.Sort();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (var sortByState in ListByState)
            {
                Console.WriteLine(sortByState);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Sorts the by zip.
        /// </summary>
        public void SortByZip()
        {
            /// creating list for zip
            /// iterating through contactlist
            List<int> ListByZip = new List<int>();
            foreach (Contact contact in ContactList)
            {
                /// Adding zip in to list 
                ListByZip.Add(contact.GetZip());
            }

            /// sorting by zip ie numericall order
            ListByZip.Sort();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (var sortByZip in ListByZip)
            {
                Console.WriteLine(sortByZip);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Users the menu.
        /// </summary>
        public void UserMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("Enter ur Choice:");
                Console.WriteLine("Press 1 to Add contact");
                Console.WriteLine("Press 2 to Edit contact");
                Console.WriteLine("Press 3 to Delete contact");
                Console.WriteLine("Press 4 to Display contact");
                Console.WriteLine("Press 5 to Sort by name");
                Console.WriteLine("Press 6 to Sort by city");
                Console.WriteLine("Press 7 to Sort by state");
                Console.WriteLine("Press 8 to Sort by zip");
                Console.WriteLine("Press 9 to Writing contacts in to address book text file");
                Console.WriteLine("Press 10 to Reading form Csv file");
                Console.WriteLine("Press 11 to write to csv");
                Console.WriteLine("press 12 to Exit");
                choice = Convert.ToInt32(Console.ReadLine());

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
                    case 5:
                        SortByName();
                        break;
                    case 6:
                        SortByCity();
                        break;
                    case 7:
                        SortByState();
                        break;
                    case 8:
                        SortByZip();
                        break;
                    case 9:
                        WriteContactInToFile();
                        break;
                    case 10:
                        ReadFromCsvFile();
                        break;
                    case 11:
                        WriteToCsvFile(ContactList);
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Choice Try again :");
                        break;
                }
            } while (choice != 12);
        }

        /// <summary>
        /// Writes the contact in to file.
        /// </summary>
        public void WriteContactInToFile()
        {
            try
            {
                string addressBookFilePath = @"C:\Users\Theja\source\repos\AddressBook\AddressBook\AddressBook.txt";
                using (StreamWriter streamWriter = File.AppendText(addressBookFilePath))
                {
                    /// By looping untill condition ends
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        Contact contact = ContactList[i];
                        string line = contact.firstName + " " + contact.lastName + " " + contact.address + " " + contact.city + " " + contact.state + " " + contact.phoneNumber + " " + contact.zip;
                        streamWriter.WriteLine(line);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }

        /// <summary>
        /// Reads from CSV file.
        /// </summary>
        public void ReadFromCsvFile()
        {
            /// csv file path
            string csvFilePath = @"C:\Users\Theja\source\repos\AddressBook\AddressBook\AddressBook.csv";

            /// Reading from csv file
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data successfully form address data csv");
                {
                    foreach(Contact contactData in records)
                    {
                        Console.WriteLine("\t" + contactData.firstName);
                        Console.WriteLine("\t" + contactData.lastName);
                        Console.WriteLine("\t" + contactData.address);
                        Console.WriteLine("\t" + contactData.city);
                        Console.WriteLine("\t" + contactData.state);
                        Console.WriteLine("\t" + contactData.phoneNumber);
                        Console.WriteLine("\t" + contactData.zip);
                        Console.WriteLine("\n");
                    }
                }
            }
        }

        /// <summary>
        /// Writes to CSV file.
        /// </summary>
        /// <param name="records">The records.</param>
        public void WriteToCsvFile(List<Contact> records)
        {
            /// csv file path
            string csvFilePath = @"C:\Users\Theja\source\repos\AddressBook\AddressBook\AddressBook.csv";

            /// Reading from csv file
            using (var writer = new StreamWriter(csvFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
