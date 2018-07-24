using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeapYearLoop
{
    class LeapYearLoop
    {
        public static int Main(string[] args) { 

            Inputwrapper iw = new Inputwrapper();
            Console.WriteLine("Enter -1 to terminate the program");
                int year = iw.getInt("Enter year: ");

            string currentYear = DateTime.Now.Year.ToString();

                while (year != -1)
                {
                    //currentYear();
                    Console.WriteLine("Not a leap Year");
                    year = Convert.ToInt32(Console.ReadLine());


                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                        Console.WriteLine("{0} is Leap Year",year);
                    else
                        Console.WriteLine("{0} is not a Leap Year",year);
 
 
                    Console.ReadLine();
                }
                return 0;
            }
        }
    }

