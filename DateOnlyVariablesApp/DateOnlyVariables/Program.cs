
// DateOnly is only in .Net 6 and greater

DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("3/8/1992");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");