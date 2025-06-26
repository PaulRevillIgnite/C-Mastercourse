//using FrameworkLibrary;

using CoreLibrary;

Generators generators = new Generators();
PersonModel person = new PersonModel
{
    Title = "Ms",
    FirstName = "Coral",
    LastName = "Murphy"
};

string message = generators.WelcomeMessage("Mr", "Revill");
string message2 = generators.WelcomeMessage(person.Title, person.LastName);

Console.WriteLine(message);
Console.WriteLine(message2);

Console.ReadLine();