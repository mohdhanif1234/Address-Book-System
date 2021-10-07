using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system");
            List<Person> personList = new List<Person>();
            Person.CreatePersonDetails(personList); // Method calling to create a person's contact list
            Person.AddNewContact(personList); // Method calling to enter a new contact in the address book
            Person.DisplayContactDetails(personList); // Method calling to display the address book contact details
            Console.WriteLine();
            Console.Write("Enter the first name of the person in the current list, the details of which you want to delete: ");
            string FName = Console.ReadLine();
            //Person.SearchName(personList, FName); // Method calling to search a person name in the list and edit the contact details accordingly
            Person.DeleteFromList(personList, FName); // Method calling to delete a person's details from the current address book
            Console.ReadLine();
        }
    }
}
