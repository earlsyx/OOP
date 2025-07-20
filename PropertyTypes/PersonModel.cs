
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes
{
    public class PersonModel
    {
        // class will hold data.
        // expand get set, to allow protecting info.

        //Auto Property
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        private string _Password;

        public string Password
        {
            set { _Password = value; }
        }
         
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        //public int Age { get; set; } // negative , below zero not valid age. ,, upto what? 100?
        //Full Property
        private int _age; // private backing field, _ then camel case, don't manipualte directly,
        // only inside age prop

        public int Age
        {
            get
            { 
                return _age; //returning value
            }
            set 
            { 
                //making sure data coming in is good data.
                if(value >= 0 && value < 126)
                {
                    _age = value; //assigining value, special keyword. value.
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range");
                }
            }
        }

        //public string SSN { get; set; }
        private string _ssn;

        public string SSN 
        {
            get 
            {
                //123-45-6789 - 11 - 5 = 6
                // masking ata, limit data.
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output; 
            }
            set { _ssn = value; }
        }


        //Method overloading
        // same method name, passed in different paramters, and this will be treat as different methods.

        public PersonModel()
        {
            
        }
        // special type of method, constructor.

        public PersonModel(string lastName)
        {
            LastName = lastName;
             ///specital type of method that gets run when you build yourhouse
        }


    }
}
