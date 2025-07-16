using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesDemo
{
    public static class RequestData
    {
        //action getting information, does nto firin usermessage class

        public static string GetAString(string message)
        {
            Console.Write("What is your firs name: ");
            string output = Console.ReadLine();

            return output;
        }
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string nubmerText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(nubmerText, out output);
            while (!isDouble)
            {
                Console.WriteLine("That's not a valid number: Try again: ");
                Console.Write(message);
                nubmerText = Console.ReadLine();

                isDouble = double.TryParse(nubmerText, out output);
            }

            return output;
        }
    }
}
