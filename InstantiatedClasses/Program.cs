

//instantiation of classes is one of the foundational principel of oop.
// do it all the time. 


//static classes - if you put data  in them then it last in the life time of the app and everyone has access to that same data.
// insitation calss is different.

//can't access since not static. need to instantitate.
using InstantiatedClasses;

////building a house from a blue print. house it at the variable name person
//// how tou build it,, - new personmodel. 
////PersonModel person = new PersonModel(); //create a new houes from this blueprint.

////person.firstName = "Tim";

////PersonModel secondPerson = new PersonModel();

////secondPerson.firstName = "Sue";

//List<PersonModel> people = new List<PersonModel>(); // list is actually a blueprint 
//// we are instantiating or creating ahouse from that blueprint(list) and puitting it in a variable
//// creating a list of type person model instaend of string type int double , we do list of person model.
//// houses acts like any other type, you can create your own type essentially.

////holds the street address for the house you've built
//PersonModel person = new PersonModel();
//person.firstName = "Tim";

//people.Add(person);

//person = new PersonModel(); // buidling an ewhouse in a different location but still calling it a person.
//// overriding the first street address won't go away. it;s alreafy built, stays there.
//// for new bnew house/
//person.firstName = "Sue";
//people.Add(person);


//foreach (PersonModel p in people)
//{
//    Console.WriteLine(p.firstName);
//}

// how do you pass this houses around, are you making copies? no , just fcopying the street address.
// now people has two diffrent street address 
// each one will open the door and look at the living room and find that value.
//storing different info in a same spot? built two different housies using the same blueprint
//doesn't mean their living room is the same for both, it is a copy of a living room. look same but each other .

//store multiple bit of data together, have multiple of them, not efficient to keep .list is better.


List<PersonModel> people = new List<PersonModel>();
string firstName = "";

do
{
    Console.Write("What is your first name (or type exit to stop): ");
    firstName = Console.ReadLine();

    Console.Write("What is your last name: ");
    string lastName = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        //whenever you create a variable , it lives in the context of the curly braces
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
    }
} while (firstName.ToLower() != "exit"); 
//created five different instances and put a value to each.
foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);
}
Console.ReadLine(); 
