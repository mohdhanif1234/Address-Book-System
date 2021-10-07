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
            Console.Write("How many persons do you want to add in your address book?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Person.CreatePersonDetails(personList);// Method calling to create a person's contact list
            }
            Person.DisplayContactDetails(personList); // Method calling to display the address book contact details
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
