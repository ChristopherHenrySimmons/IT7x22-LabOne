using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            Inputwrapper get = new Inputwrapper();
            //Calculate area of Triangle
            /*double Base = 15;
            double Height = 5;*/
            


            /*Console.WriteLine("Base: ");
            String StringBase = Console.ReadLine();*/

            double Base = get.getInt("Base: ");
            double Height = get.getInt("Height: ");
            double area = Base * Height / 2;

            Console.WriteLine("Area = {0}", area);
            Console.Read();
        }



    }
    
}
