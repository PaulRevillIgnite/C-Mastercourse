// See https://aka.ms/new-console-template for more information
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using DataAccessLibrary.Models;

SqlCrud sql = new SqlCrud(GetConnectionString());

//ReadAllContacts(sql);

//ReadContact(sql, 1);

//CreateNewContact(sql);

//UpdateContact(sql);

//RemovePhoneNumberFromContact(sql, 15, 1);

Console.WriteLine("Finished");

Console.ReadLine();

static void RemovePhoneNumberFromContact(SqlCrud sql, int contactId, int phoneNumberId)
{
    sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
}

static void UpdateContact(SqlCrud sql)
{
    BasicContactModel contact = new BasicContactModel
    {
        Id = 1,
        FirstName = "Joe",
        LastName = "Burns"
    };

    sql.UpdateContactName(contact);
}

static void CreateNewContact(SqlCrud sql)
{
    FullContactModel user = new FullContactModel()
    {
        BasicInfo = new BasicContactModel
        {
            FirstName = "Coral",
            LastName = "Murphy"
        }
    };

    user.EmailAddesses.Add(new EmailAddressModel { EmailAddress = "coral_murphy@hotmail.co.uk" });
    user.EmailAddesses.Add(new EmailAddressModel { Id = 2, EmailAddress = "paulrevswow@gmail.com" });

    user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "07123456789" });
    user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "07899887023" });

    sql.CreateContact(user);
}

static void ReadAllContacts(SqlCrud sql)
{
    var rows = sql.GetAllContacts();

    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
    }
}

static void ReadContact(SqlCrud sql, int contactId)
{
    var contact = sql.GetFullContactById(contactId);

    Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
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