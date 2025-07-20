


using PropertyTypes;

PersonModel person = new PersonModel("Correy"); // not actuall the class you are calling but the constsructor (), normally ihdden.
//use constcutor to set that value
// make sure you have atleast the minimum amount of data to start out with.
// a person has to have a firs tname last name before we declare them a person
// i know i always have them, then just passing all params i the constrcutor, 
// pass an assignemnt right away.
person.FirstName = "Tim";
//person.LastName = "Correy";
person.Age = 40;
person.SSN = "123-45-6789";

Console.WriteLine(person.FullName );
Console.WriteLine(person.SSN);
Console.ReadLine();