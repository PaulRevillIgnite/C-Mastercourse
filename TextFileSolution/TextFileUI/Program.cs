using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

IConfiguration _config = InitaliseConfiguration();
string textFile = _config.GetValue<string>("TextFile");
TextFileDataAccess db = new TextFileDataAccess();

ContactModel user1 = new ContactModel();
user1.FirstName = "John";
user1.LastName = "Smith";
user1.EmailAddresses.Add("t.t@t.com");
user1.EmailAddresses.Add("s.s@s.com");
user1.PhoneNumbers.Add("1234567890");
user1.PhoneNumbers.Add("0987654321");

ContactModel user2 = new ContactModel();
user2.FirstName = "Jane";
user2.LastName = "Doe";
user2.EmailAddresses.Add("a.a@a.com");
user2.EmailAddresses.Add("b.b@b.com");
user2.PhoneNumbers.Add("1111111111");
user2.PhoneNumbers.Add("2222222222");

List<ContactModel> contacts = new List<ContactModel>
{
    user1,
    user2
};

//CreateContact(user1);
//CreateContact(user2);
//GetAllContacts();

//UpdateContactsFirstName("Tim");
//GetAllContacts();
//Console.WriteLine();

//RemovePhoneNumberFromUser("0987654321");
//GetAllContacts();
//Console.WriteLine();

//RemoveUser();
//GetAllContacts();
//Console.WriteLine();

//Console.WriteLine("Finished processing text file");

//Console.ReadLine();

static IConfiguration InitaliseConfiguration()
{
    IConfiguration _config;

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    _config = builder.Build();

    return _config;
}

void RemoveUser()
{
    var contacts = db.ReadAllRecords(textFile);
    contacts.RemoveAt(0);
    db.WriteAllRecords(contacts, textFile);
}

void RemovePhoneNumberFromUser(string phoneNumber)
{
    var contacts = db.ReadAllRecords(textFile);
    contacts[0].PhoneNumbers.Remove(phoneNumber);
    db.WriteAllRecords(contacts, textFile);


}

void UpdateContactsFirstName(string firstName)
{
    var contacts = db.ReadAllRecords(textFile);
    contacts[0].FirstName = firstName;
    db.WriteAllRecords(contacts, textFile);
}

void GetAllContacts()
{
    var contacts = db.ReadAllRecords(textFile);

    foreach (var contact in contacts)
    {
        Console.WriteLine($"{contact.FirstName} {contact.LastName}");
    }
}

void CreateContact(ContactModel contact)
{
    var contacts = db.ReadAllRecords(textFile);

    contacts.Add(contact);

    db.WriteAllRecords(contacts, textFile);
}