

// Create a colsole application that asks the user for their name.
// Welcome Tim as professor and anyone else as student.
// Do this until the use types "exit".

using System.ComponentModel.Design;

bool exitApp = true;

do
{
    Console.Write("Type your name: ");
    string? firstName = Console.ReadLine();

    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome professor {firstName}");
    }
    else
    {
        Console.WriteLine($"Welcome {firstName}");
    }

    Console.Write("Do you want enter a new user (Y/N)? ");
    if (Console.ReadLine().ToLower() == "n")
    {
        exitApp = false;
    }
}
while (exitApp == true);
