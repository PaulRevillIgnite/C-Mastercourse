

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"The value if i is {i}");
}

string data = "Paul,Coral,Lee,Joe";
List<string> firstNames = data.Split(',').ToList();

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine(firstNames[i]);
}

List<decimal> charges = new List<decimal>();

charges.Add(23.78M);
charges.Add(16.01M);
charges.Add(22.99M);

decimal total = 0;

for(int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Your charges total {total}");