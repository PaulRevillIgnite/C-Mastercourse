
// Create a Console Application that asks the user for their name. Welcome Tim as professor
// or anyone else as student. Make sure that "TIM" also gets called professor.

// 1: Ask for name
Console.Write("Type your name: ");
String? name = Console.ReadLine();

// 2: Welcome any variation of tim as professor
// 3: Welcome anyone not Tim as student

switch (name)
{
    case "tim" or "TIM":
        Console.WriteLine("Hello professor (switch)");
        break;
    default:
        Console.WriteLine("Hello student");
        break;
}

if (name.ToLower() == "tim")
{
    Console.WriteLine("Hello professor (if)");
}
else
{
    Console.WriteLine("Hello student (if)");
}