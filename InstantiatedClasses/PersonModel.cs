using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClasses
{
    //common practice.
    // name a class that store data primarily or solely to name it model.
    // model holds information together, connect different pieces together.
    
    // a blue print. - plan, laysout the itsura.. big etc.
    // can't live in a blue print. same way can't use a class instance, without first instatiating it.
    public class PersonModel
    {
        //does not work well with class instances.
        //data binding, reflection does not quite work as well.
        //intro to properties.
        //public string firstName;
        //public string lastName;
        //public string emailAddress;

        public string FirstName { get; set; } // get set inside curly braces indicitaes auto prop.
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public bool HasBeenGreeted { get; set; }

        // naming convention pascal case. indtury tandard convetion   
        // intenral variable woudl becamel case, so it would come outside.

        //you can put method here sometimes,
        // tend to sperated classes that have methods from classes that have data
        // since usually they do sperate things. they can be belnd , in genral seprate.

        //class instances, exclusively where we store data.
        // we can contorl how it live,s shortp eriod or long period.
        // wholds multiple pieces of data together, so you don't get mismatch, store in diferetn spot?

    }
}
