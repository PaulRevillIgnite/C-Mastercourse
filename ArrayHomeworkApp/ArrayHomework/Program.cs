

// Create an array of 3 names.
// Ask the user which number to select.
// When the user gives you a number, return that name.
// Make sure to check for invalid numbers.

string[] names = new string[] { "Paul", "Coral", "Joe" };

string selectionString;
int selectionInt;
do
{
    Console.Write("Type a number bwtween 1 and 3: ");
    selectionString = Console.ReadLine();

    if (!int.TryParse(selectionString, out selectionInt))
        Console.WriteLine("Enter a valid number");
    else
    {
        Console.WriteLine($"You chose the name {names[selectionInt - 1]}");
    }
}
while (!int.TryParse(selectionString, out selectionInt));