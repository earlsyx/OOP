

//static, you get one copy for the entire application
// meaning if we store data , get stored accrossed the entire application

using StaticClassesDemo;
// we don't store data in a static class because it will leave in 
// your appliation until it closes ,storeage space, memory psace for entire life of appl.
// larger memory foot print.
// connection string, who is logged in.
string firstName = RequestData.GetAString("What is your first name: ");

UserMessages.ApplicationStartMessasge(firstName);

double x = RequestData.GetADouble("Please enter your first number: ");
double y = RequestData.GetADouble("Please enter your second number: ");

double result = CalculateData.Add(x, y);

UserMessages.PrintResultMessage($"The some of {x} and {y} is {result}");

Console.ReadLine();



//organize, DRY.
