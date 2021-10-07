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
            Person.CreatePersonDetails(personList);
            Console.ReadLine();
        }
    }
}
