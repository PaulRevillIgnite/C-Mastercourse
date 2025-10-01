using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Done processing CosmosDB");
Console.ReadLine();

void RemoveUser(string id)
{
    
}

void RemovePhoneNumberFromUser(string phoneNumber, string id)
{
    
}

void UpdateContactsFirstName(string firstName, string id)
{
    
}

void GetContactById(string id)
{
    
}

void GetAllContacts()
{
    
}

void CreateContact(ContactModel user)
{
    
}

static string GetConnectionString(string connectionStringName = "Default")
{
    string output = "";

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    var config = builder.Build();

    output = config.GetConnectionString(connectionStringName);

    return output;
}