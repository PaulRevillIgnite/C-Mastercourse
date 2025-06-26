// Create a Console Application that has variables to hold a person's name, age, if they are alive, and their phone number.
// You do not need to capture these values from the user.

// 1 - Create a Console Application
// 2 - Variable to hold a name
// 3 - Variable to hold an age
// 4 - Variable if they are alive
// 5 - Variable to hold their phone number

// 1 - Create a Console Application

// 2 - Variable to hold a name
string? firstName = null;
string? lastName = null;

firstName = "Paul";
lastName = "Revill";

// 3 - Variable to hold an age
int? age = null;

age = 32;

// 4 - Variable if they are alive
bool? alive = null;

alive = true;

// 5 - Variable to hold their phone number
string? phoneNumber = null;
phoneNumber = "+44 712345678";

Console.WriteLine($"This person is called {firstName} {lastName}");
Console.WriteLine($"Are they alive? {alive}");
Console.WriteLine($"They are {age} years old");
Console.WriteLine($"Their number is {phoneNumber}");