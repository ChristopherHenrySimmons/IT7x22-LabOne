using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Array
    {
        static void Main()
        {
            int[] myInts = { 5, 10, 15 };
            bool[][] myBools = new bool[2][];
            myBools[0] = new bool[2];
            myBools[0] = new bool[1];
            string[] myStrings = new string[3];
            double[][] myDoubles = new double[2][];

            Console.WriteLine("myInts[0]: myInts[1], ,myInts[2]: {2}", myInts[0], myInts[1], myInts[2]);

            myBools[0][0] = true;
            myBools[0][1] = false;
            myBools[1][0] = true;

            Console.WriteLine("myBools[0][0]: {0}, myBools[1][0]: {1}", myBools[0][0], myBools[0][1]);

            myStrings[0] = "Joe";
            myStrings[1] = "Matt";
            myStrings[2] = "Robert";

            Console.WriteLine("myStrings[0]: {0}, myStrings[1]: {1}, myStrings[2]: {2}", myStrings[0], myStrings[1], myStrings[2]);

            myDoubles[0][0] = 1;
            myDoubles[0][1] = 2;
            myDoubles[1][0] = 3;

            Console.WriteLine("myDoubles[0][0]: {0}, myDoubles[0][1]: {1}, myDoubles[1][0]: {2}", myDoubles[0][0], myDoubles[0][1], myDoubles[1][0]);

            Console.Read();

        }
    }
}
