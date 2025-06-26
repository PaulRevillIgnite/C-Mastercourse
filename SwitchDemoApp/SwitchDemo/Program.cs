

string? firstname = "Paul";
int? age = 32;

switch (firstname.ToLower())
{
    case "paul":
        Console.WriteLine("Hello Mr Revill");
        break;
    case "tom":
    case "coral":
        Console.WriteLine("Hello Tom or Coral!");
        break;
    case "lee" or "ste":
        Console.WriteLine("Not you!");
        break;
    default:
        Console.WriteLine("I don't know you");
        break;
}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You are an adult");
        break;
    case >= 66:
        Console.WriteLine("You're old!");
        break;
    default:
        Console.WriteLine("Age not recognised");
        break;
}