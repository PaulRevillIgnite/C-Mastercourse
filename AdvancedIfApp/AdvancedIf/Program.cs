
// SHIFT-ENTER at the end of a line that will need curly braces will add them

using System.ComponentModel.Design;

Console.Write("What is your first name: ");
string? firstname = Console.ReadLine();

Console.Write("What is your last name: ");
string? lastname = Console.ReadLine();

if (firstname.ToLower() == "paul" &&
    lastname.ToLower() == "revill")
{
    Console.WriteLine("Hello Mr Revill");
}
else if (firstname.ToLower() == "paul")
{
    Console.WriteLine("Hello, you have a cool first name.");
}
else if (lastname.ToLower() == "revill")
{
    Console.WriteLine("You have a cool last name.");
}
else
{
    Console.WriteLine("Sorry you don't have a cooler name...");
}

int age = 0;

if (age > 100)
{
    Console.WriteLine("You're old!");
}
else if (age < 100)
{
    Console.WriteLine("You're young!");
}
else if (age <= 100)
{
    Console.WriteLine("You're old!");
}
else if (age >= 40 && age < 50)
{
    Console.WriteLine("You're in your 40s");
}
else if (age != 20)
{
    Console.WriteLine("You're not 20");
}


if (firstname.ToLower() == "paul" ||
    lastname.ToLower() == "revill")
{
    Console.WriteLine("You have a cool first or last name");
}
else
{
    Console.WriteLine("Shame about the name");
}

if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
{
    Console.WriteLine("You're in your 40s or 70s");
}