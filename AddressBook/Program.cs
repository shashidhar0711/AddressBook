/// Including the requried assemblies in to the program
using System;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// An Array of Contacts - Each stores information for one User
        /// Number of Users Currently in AddressBook
        /// </summary>
        private static Contact[] users; 
        private static int numOfUsers; 

        /// <summary>
        /// Add a contact that's passed in as a parameter.
        /// </summary>
        /// <param name="con"></param>
        public static void AddContact(Contact con)
        {
            users[numOfUsers] = con;
            numOfUsers++;
        }

        /// <summary>
        /// Create an Empty Address Book
        /// </summary>
        public Program()
        {
            users = new Contact[10];
            numOfUsers = 0;
        }

        // Returns the number of Users currently in AddressBook
        public static int NumOfContacts()
        {
            return numOfUsers;
        }

        /// <summary>
        /// Calling a Method to Add Contact in Address Book
        /// </summary>
        static void AddingContact()
        {
            if (NumOfContacts() <= 10)
            {
                /// Taking User Information from Console
                Console.WriteLine("Enter the First Name");
                string fname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Last Name");
                string lname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Address");
                string add = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the City");
                string city = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the State");
                string state = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Phone Number");
                long phonenumber =Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the ZIP Number");
                int zip = Convert.ToInt32(Console.ReadLine());
                /// Adding a new Contact
                AddContact(new Contact(fname, lname, add, city, state, phonenumber, zip));
            }
            else
            {
                Console.WriteLine("Sorry, can not add anyone, your AddressBook is full.");
            }
        }

        // Printing Contacts in Address Book
        public static void PrintContacts()
        {
            for (int i = 0; i < numOfUsers; i++)
                users[i].PrintContact();
        }

        /// <summary>
        /// Printing Menu 
        /// To choose Menu from user to perform operation.
        /// </summary>
        /// <returns></returns>
        static int Menu()
        {
            Console.WriteLine("Welcome to AddressBook");
            Console.WriteLine("1.Add a new contact to your address book.");
            Console.WriteLine("2.Print out information of all of your contacts.");
            Console.WriteLine("3.Quit.");
            Console.WriteLine("Enter your menu choice:");
            
            /// It returns a Value ie Choice
            return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(String[] args)
        {
            /// Creating Object for Program Class
            Program program = new Program();
            int choice = Menu();
            switch (choice)
            {
                case 1:
                    AddingContact();
                    PrintContacts();
                    Menu();
                    break;
                case 2:
                    PrintContacts();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Enter a Number between 1 to 3 : ");
                    Menu();
                    break;

            }
        }
    } 
}
