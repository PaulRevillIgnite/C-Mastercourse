

// Ask the user for their first name.
// Continue asking for first names until there are no more.
// Loop through each name using foreach and tell each person hello on the Console.

Console.WriteLine("Type first names until you are done. Once done, type 'end'.");

List<string> firstNames = new List<string>();
string firstName = "";

do
{
    Console.Write($"Name {firstNames.Count + 1}: ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() != "end")
        firstNames.Add(firstName);
}
while (firstName.ToLower() != "end");

foreach (string name in firstNames)
{
    Console.WriteLine(name);
}