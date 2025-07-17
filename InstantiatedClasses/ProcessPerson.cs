using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClasses
{
    public static class ProcessPerson
    {
    
        //when we passed in a person model model, in person param, we are not making a copy
        // if i ask you where you lieve and you send me an address you are not sending me a copy of your entire house, only the location, if you chang something about your house paint a house 
        // we still both know about that change, both have access to same  location via address
        //so if you chnages omtinh in a particalr atddres s then evry one ho has access to address
        // will see the same change
        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            person.HasBeenGreeted = true;
        }
    }
}
