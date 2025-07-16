

//static, you get one copy for the entire application
// meaning if we store data , get stored accrossed the entire application

using StaticClassesDemo;

SayHello();
static void SayHello()
{
    Console.WriteLine("Hello!");
}

UserMessages.SayGoodMorning();  