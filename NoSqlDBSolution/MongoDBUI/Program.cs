using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;

MongoDBDataAccess db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString());

string tableName = "Contacts";

ContactModel user = new ContactModel
{
    FirstName = "Paul",
    LastName = "Revill"
};

user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "paul_revs@hotmail.com" });
user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "paulrevswow@gmail.com" });
user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "07123456789" });
user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "07111111111" });

CreateContact(user);

//GetAllContacts();

//GetContactById("");

//UpdateContactsFirstName("Coral", "");

//RemovePhoneNumberFromUser("07123456789", "");

//RemoveUser("");

Console.WriteLine("Done processing MongoDB");
Console.ReadLine();

void RemoveUser(string id)
{
    Guid guid = new Guid(id);
    db.DeleteRecord<ContactModel>(tableName, guid);
}

void RemovePhoneNumberFromUser(string phoneNumber, string id)
{
    Guid guid = new Guid(id);
    var contact = db.LoadRecordById<ContactModel>(tableName, guid);

    contact.PhoneNumbers = contact.PhoneNumbers.Where(x  => x.PhoneNumber != phoneNumber).ToList();

    db.UpsertRecord(tableName, contact.Id, contact);
}

void UpdateContactsFirstName(string firstName, string id)
{
    Guid guid = new Guid(id);
    var contact = db.LoadRecordById<ContactModel>(tableName, guid);

    contact.FirstName = firstName;

    db.UpsertRecord(tableName, contact.Id, contact);
}

void GetContactById(string id)
{
    Guid guid = new Guid(id);
    var contact = db.LoadRecordById<ContactModel>(tableName, guid);

    Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
}

void GetAllContacts()
{
    var contacts = db.LoadRecord<ContactModel>(tableName);

    foreach (var contact in contacts)
    {
        Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
    }
}

void CreateContact(ContactModel user)
{
    db.InsertRecord(tableName, user);
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