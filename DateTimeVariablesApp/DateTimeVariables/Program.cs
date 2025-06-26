

using System.Globalization;

DateTime today = DateTime.Now;

Console.WriteLine(today);
Console.WriteLine(today.ToString("d"));
Console.WriteLine(today.ToString("t"));
Console.WriteLine(today.ToString("T"));

DateTime birthday = DateTime.Parse("03/12/1992");
Console.WriteLine(birthday);

DateTime date1 = DateTime.ParseExact("15/4/1992", "d/M/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(date1);

Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm:ss tt zzz"));

DateTime UTCDateTime = DateTime.UtcNow;
Console.WriteLine(UTCDateTime);