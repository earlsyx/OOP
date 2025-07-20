

//Create a class that has preiprties for street, address, city, state and zip code.
//Add FullAddress Property that is read-only.

using HMProperties;

//dot operator (.) .. used to access to access membemrs 
// properties, fields, methods etc. of a classs, a strucr or object.
//fullAddress is an object, AddressModel is a type of that object and .ZipCode means accessing thembmers of fullAddress object
AddressModel fullAddress = new AddressModel();
fullAddress.Street = "Cherry Dv St";
fullAddress.Address = "Blk 1 Lot 3";
fullAddress.City = "Taytay Rizal";
fullAddress.ZipCode = 1920;

Console.WriteLine(fullAddress.FullAddress);