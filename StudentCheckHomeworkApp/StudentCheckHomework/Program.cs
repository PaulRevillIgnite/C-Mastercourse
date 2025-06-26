
// Plan and build a Console application that asks a user for their name and their age.
// If their name is Bob or Sue, address them as Professor.
// If the person is under 21, reccomend they wait X years to start this class.

// 1: Build a console app


// 2: Ask for user's name and age
Console.Write("Type your name: ");
string? name = Console.ReadLine();

Console.Write("Type your age: ");
string? ageText = Console.ReadLine();

// 3: If name = Bob or Sue, call them Professor
string? formattedName;

if (name.ToLower() == "bob" || name.ToLower() == "sue")
{
    formattedName = $"Professor {name}";
}
else
{
    formattedName = name;
}

// 4: If age < 21, reccomend they wait X years to start the class

if (int.TryParse(ageText, out int age) == false)
{
    Console.WriteLine("The age entered is not valid");
    return;
}
else if ((age < 21) &&
        name.ToLower() != "bob" &&
        name.ToLower() != "sue")
{
    int ageGap = 21 - age;
    Console.WriteLine($"{formattedName}, wait {ageGap} years to start the class");
}
else
{
    Console.WriteLine($"You're ready to start the class {formattedName}");
}
