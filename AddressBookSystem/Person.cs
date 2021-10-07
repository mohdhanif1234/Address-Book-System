using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-5: To add multiple contacts in the address book
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

