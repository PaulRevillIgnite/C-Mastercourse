
// CTRL-K-D auto formats the file

bool isComplete = false;

if (isComplete)
{
    Console.WriteLine("The statement was true.");
}
else
{
    Console.WriteLine("The statment was false");
}

if (!isComplete)
{
    Console.WriteLine("The statement was false");
}
else
{
    Console.WriteLine("The statment was true");
}


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "paul")
{
    Console.WriteLine("Hello Mr Revill");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}