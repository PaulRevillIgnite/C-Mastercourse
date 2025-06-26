

string[] firstNames = new string[5];

firstNames[0] = "Paul";
firstNames[1] = "Coral";
firstNames[2] = "Lee";
firstNames[4] = "Joe";

Console.WriteLine($"The first names are {firstNames[0]}, {firstNames[1]}");

firstNames[0] = "Michael";

Console.WriteLine(firstNames[0]);

// Single quote identifies a char
// Double quotes identifies a string
string data = "Paul,Coral,Lee,Joe,Michael";
string[] firstNames2 = data.Split(',');

Console.WriteLine(firstNames2[1]);

Console.WriteLine(firstNames2.Length);
Console.WriteLine(firstNames2[firstNames2.Length - 1]);

string[] lastNames = new string[] { "Revill, Murphy, Burns" };

int[] ages = new int[] { 1, 2, 3 };