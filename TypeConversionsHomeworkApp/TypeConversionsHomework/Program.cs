
// Capture a user's age from the Console and then identify how old they will be in 25 years,
// as well as how old they were 25 years ago.
// Print that information to the Console in natural language.

// 1: Capture a user's age from the Console
Console.Write("How old are you: ");
string? ageString = Console.ReadLine();

int age = int.Parse(ageString);

// 2: Calculate their age in 25 years
int agePlus25 = age + 25;

// 3: Caluclate their age 25 years ago
int ageMinus25 = age - 25;

// Output the 2 answers in natural language
Console.WriteLine($"You are currently {ageString}");
Console.WriteLine($"In 25 years, you will be {agePlus25}");
Console.WriteLine($"25 years ago, you were {ageMinus25}");
Console.ReadLine();