using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesDemo
{
    class UserMessages
    {
        //access modifier

   
        public static void ApplicationStartMessasge(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the static classs demo app!");
            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning {firstName}");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good afternoon! {firstName}");
            }
            else
            {
                Console.WriteLine($"Good evening! {firstName}");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our app");
        }


       
    }
}
