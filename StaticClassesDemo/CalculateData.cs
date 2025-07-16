using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesDemo
{
    //adding satic in class, everymethod should be static
    public static class CalculateData
    {
        public static int myAge;
        public static double Add(double x, double y)
        {
            double output = x + y;

            return output;
        }

        //SOLID , single repsonsiblity principle
        // - every method should have one responsiblity, don't do 2 3 4 5 different things
        // in one method, ,does notmean you don't have 2 3 4 or 5 methods in a class. each method does somethin different but one logical thing
    }
}
