using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

CosmoDBDataAccess db;

var c = GetCosmosInfo();

db = new CosmoDBDataAccess(c.endpointUrl, c.primaryKey, c.databaseName, c.containerName);

ContactModel user = new ContactModel
{
    FirstName = "Paul",
    LastName = "Revill"
};

user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "paul_revs@hotmail.com" });
user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "paulrevswow@gmail.com" });
user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "07123456789" });
user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "07111111111" });

await CreateContact(user);

await GetAllContacts();

//await GetContactById(""); // Put in a valid Guid here

//await UpdateContactsFirstName("Bob", ""); // Put in a valid Guid here

//await RemovePhoneNumberFromUser("071234567", ""); // Put in a valid Guid here

//await RemoveUser("", "Revill"); // Put in a valid Guid here

Console.WriteLine("Done processing CosmosDB");
Console.ReadLine();

async Task RemoveUser(string id, string lastName)
{
    await db.DeleteRecordAsync<ContactModel>(id, lastName);
}

async Task RemovePhoneNumberFromUser(string phoneNumber, string id)
{
    var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

    contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

    await db.UpsertRecordAsync(contact);
}

async Task UpdateContactsFirstName(string firstName, string id)
{
    var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

    contact.FirstName = firstName;

    await db.UpsertRecordAsync(contact);
}

async Task GetContactById(string id)
{
    var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

    Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
}

async Task GetAllContacts()
{
    var contacts = await db.LoadRecordAsync<ContactModel>();

    foreach (var contact in contacts)
    {
        Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
    }
}

async Task CreateContact(ContactModel contact)
{
    await db.UpsertRecordAsync(contact);
}

static (string endpointUrl, string primaryKey, string databaseName, string containerName) GetCosmosInfo()
{
    (string endpointUrl, string primaryKey, string databaseName, string containerName) output;

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    var config = builder.Build();

    output.endpointUrl = config.GetValue<string>("CosmosDB:EndpointUrl");
    output.primaryKey = config.GetValue<string>("CosmosDB:PrimaryKey");
    output.databaseName = config.GetValue<string>("CosmosDB:DatabaseName");
    output.containerName = config.GetValue<string>("CosmosDB:ContainerName");

    return output;
}