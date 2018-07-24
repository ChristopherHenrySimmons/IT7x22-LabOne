using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class SortString
    {
        static void Main(string[] args)
        {
            //String.Split method to separate the sting into an array of words
            string s = "Microsoft .Net Framework 6.0 Application Development ";
            string[] sa = s.Split(' ');

            //Calling the ArraySort method to sort arrays or words
            Array.Sort(sa);

            //Call the String.Join method to convert the array of words back into a single string, then write the string to the console
            s = string.Join(" ", sa);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
