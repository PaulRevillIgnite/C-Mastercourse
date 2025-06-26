

// Ask the user for a comma-seperated list of first names (no spaces).
// Split the string into a string list.
// Loop through the list and print "Hello <name>" to the Console for each person.

Console.Write("Type a comma-seperated list of first names with no spaces: ");
string firstNamesUnformatted  = Console.ReadLine();

List<string> names = firstNamesUnformatted.Split(',').ToList();

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}