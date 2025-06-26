

using Methods;

// DRY - Don't Repeat Yourself
// SRP - Single Responsibility Principle

string name = SampleMethods.GetUsersName();
SampleMethods.SayHi(name);

SampleMethods.SayGoodbye();

MathShortcuts.Add(3, 6);

double[] numbers = new double[] { 1, 2, 3, 4, 5 };
double result = MathShortcuts.AddAll(numbers);
Console.WriteLine($"The total is {result}");

//(string firstName, string lastName) = SampleMethods.GetFullName();
//Console.WriteLine($"First Name: {firstName}");
//Console.WriteLine($"Last Name: {lastName}");
//Console.ReadLine();

// _ is a discard character
//(string firstName, _) = SampleMethods.GetFullName();
//Console.WriteLine($"First Name: {firstName}");
//Console.ReadLine();

var fullName = SampleMethods.GetFullName();
Console.WriteLine($"First Name: {fullName.firstName}");
Console.WriteLine($"Last Name: {fullName.lastName}");
Console.ReadLine();