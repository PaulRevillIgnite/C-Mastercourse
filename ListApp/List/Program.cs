

List<string> firstNames = new List<string>();

firstNames.Add("Paul");
firstNames.Add("Coral");
firstNames.Add("Lee");
firstNames.Add("Joe");

Console.WriteLine(firstNames[2]);
Console.WriteLine(firstNames.Count - 1);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

// List<T> - Generic

string data = "Revill,Murphy,Burns";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Dean");