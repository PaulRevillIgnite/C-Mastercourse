

string data = "Paul,Coral,Joe";
List<string> firstNames = data.Split(',').ToList();

foreach (string name in firstNames)
{
    Console.WriteLine(name);
}