using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable lookup = new Hashtable();

            lookup.Add("0", "Zero");
            lookup.Add("1", "One");
            lookup.Add("2", "Two");
            lookup.Add("3", "Three");
            lookup.Add("4", "Four");
            lookup.Add("5", "Five");
            lookup.Add("6", "Six");
            lookup.Add("7", "Seven");
            lookup.Add("8", "Eight");
            lookup.Add("9", "Nine");

            string number = "023453645";
            foreach (char cter in number)
            {
                string digit = cter.ToString();
                if (lookup.ContainsKey(digit))
                {
                    Console.WriteLine(lookup[digit]);
                }
            }
            Console.ReadKey();
        }
    }
}
