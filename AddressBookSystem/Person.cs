using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-4: To delete a particular contact from the given list of contact details from the given address book
    class Person
    {
        string firstName, lastName, city, state, address, email;
        int pinCode;
        long phoneNum;

        // Constructor to initialize the person details variables
        public Person(string firstName, string lastName, string city, string state, string address, string email, int pinCode, long phoneNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.state = state;
            this.address = address;
            this.email = email;
            this.pinCode = pinCode;
            this.phoneNum = phoneNum;
        }

        // Creating person details in the address book
        public static void CreatePersonDetails(List<Person> personList)
        {
            Console.Write("Enter the number of persons whose details you want to maintain in the address book: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter the name of the city: ");
                string city = Console.ReadLine();
                Console.Write("Enter the name of the state: ");
                string state = Console.ReadLine();
                Console.Write("Enter the address: ");
                string address = Console.ReadLine();
                Console.Write("Enter email ID: ");
                string email = Console.ReadLine();
                Console.Write("Enter the pincode: ");
                int pincode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the phone number: ");
                long phoneNum = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine();
                personList.Add(new Person(firstName, lastName, city, state, address, email, pincode, phoneNum));
            }
        }

        // Adding new contact details
        public static void AddNewContact(List<Person> personList)
        {
            personList.Add(new Person("ABC", "XYZ", "Bengaluru", "Karnataka", "Hoodi","abc@xyz.com", 444555, 9998887771));
        }

        // Editing a particular contact detail from the current address book
        public static void SearchName(List<Person> personList, string FName)
        {
            int index = -1;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].firstName == FName)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} is present in the list", FName);
                    Console.WriteLine();
                    index = i;

                    // Providing an option to the user as to which detail about a particluar person needs to be changed

                    Console.WriteLine("Enter any one of the following options given below:");
                    Console.WriteLine("Enter 1 to change to change the first name");
                    Console.WriteLine("Enter 2 to change to change the last name");
                    Console.WriteLine("Enter 3 to change to change the city name");
                    Console.WriteLine("Enter 4 to change to change the state name");
                    Console.WriteLine("Enter 5 to change to change the address");
                    Console.WriteLine("Enter 6 to change to change the email ID");
                    Console.WriteLine("Enter 7 to change to pincode");
                    Console.WriteLine("Enter 8 to change the phone number");
                    Console.WriteLine();
                    Console.Write("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter a new first name: ");
                            personList[index].firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter a new last name: ");
                            personList[index].lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Enter a new city name: ");
                            personList[index].city = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Enter a new state name: ");
                            personList[index].state = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Enter a new address: ");
                            personList[index].address = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("Enter a new email ID: ");
                            personList[index].email = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("Enter a new pincode: ");
                            personList[index].pinCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.Write("Enter a new phone number: ");
                            personList[index].phoneNum = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("The new list after editing is: ");
                    DisplayContactDetails(personList);
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} is not present in the list", FName);
                    Console.WriteLine();
                    Console.WriteLine("The original list is:");
                    DisplayContactDetails(personList);
                }
            }
        }

        // Deleting a particular person's contact details from the current address book
        public static void DeleteFromList(List<Person> personList,string FName) 
        {
            int index = -1;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].firstName == FName)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} is present in the list", FName);
                    Console.WriteLine();
                    index = i;
                    personList.RemoveAt(index);
                    Console.WriteLine("The new list after editing is: ");
                    DisplayContactDetails(personList);
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} is not present in the list", FName);
                    Console.WriteLine();
                    Console.WriteLine("The original list is:");
                    DisplayContactDetails(personList);
                }
            }
        }
        
            // Displaying person details
            public static void DisplayContactDetails(List<Person> personList) 
            { 
                for (int i = 0; i < personList.Count; i++)
                {
                    Console.Write("\n" + "First Name: " + personList[i].firstName + "\n");
                    Console.Write("Last Name: " + personList[i].lastName + "\n");
                    Console.Write("City: " + personList[i].city + "\n");
                    Console.Write("State: " + personList[i].state + "\n");
                    Console.Write("Address: " + personList[i].address + "\n");
                    Console.Write("Email ID: " + personList[i].email + "\n");
                    Console.Write("Pincode: " + personList[i].pinCode + "\n");
                    Console.Write("Phone No: " + personList[i].phoneNum + "\n");
                }
            }
        }
    }

