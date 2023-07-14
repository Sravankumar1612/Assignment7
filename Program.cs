using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList
            {
                "apple", "banana" ,"cherry", "date", "elderberry"
            };
            //search for value
            Console.WriteLine("Enter item to search");
            string searchitem = Console.ReadLine();
            int index = arrayList.IndexOf(searchitem);
            if (index == -1)
            {
                Console.WriteLine($"No such item {searchitem} exists in list");
            }
            else
            {
                Console.WriteLine($"{searchitem} exists in the list");
                
            }
            //Insertion of element
            arrayList.Insert(2, "fig");
            Console.WriteLine("Elements in the list after adding fig");
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }
           
            //Removing value banana
            arrayList.Remove("banana");
            Console.WriteLine("Elements in the list after removing banana");
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }
            
            //Display elements
            Console.WriteLine("Finally Elements in the list are");
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
