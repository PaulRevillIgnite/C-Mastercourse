using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using Microsoft.EntityFrameworkCore;

//CreatePaul();
//CreateCoral();
//ReadById(1);
//UpdateFirstName(1, "Willow");
//RemovePhoneNumber(1, "07111111111");
//RemoveUser(1);
//ReadAll();

Console.WriteLine("Done Processing");
Console.ReadLine();

static void RemoveUser(int id)
{
    using (var db = new ContactContext())
    {
        var user = db.Contacts
            .Include(e => e.EmailAddresses)
            .Include(e => e.PhoneNumbers)
            .Where(c => c.Id == id).FirstOrDefault();

        db.Contacts.Remove(user);
        db.SaveChanges();
    }
}

static void RemovePhoneNumber(int id, string phoneNumber)
{
    using (var db = new ContactContext())
    {
        var user = db.Contacts
            .Include(p => p.PhoneNumbers)
            .Where(c => c.Id == id).FirstOrDefault();

        user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);

        db.SaveChanges();
    }
}

static void UpdateFirstName(int  id, string firstName)
{
    using (var db = new ContactContext())
    {
        var user = db.Contacts.Where(c => c.Id == id).FirstOrDefault();

        user.FirstName = firstName;

        db.SaveChanges();
    }
}

static void CreatePaul()
{
    var c = new Contact
    {
        FirstName = "Paul",
        LastName = "Revill"
    };

    c.EmailAddresses.Add(new Email { EmailAddress = "p.p@p.com" });
    c.EmailAddresses.Add(new Email { EmailAddress = "t.t@t.com" });
    c.PhoneNumbers.Add(new Phone { PhoneNumber = "07111111111" });
    c.PhoneNumbers.Add(new Phone { PhoneNumber = "07222222222" });

    using (var db = new ContactContext())
    {
        db.Contacts.Add(c);
        db.SaveChanges();
    }
}

static void CreateCoral()
{
    var c = new Contact
    {
        FirstName = "Coral",
        LastName = "Murphy"
    };

    c.EmailAddresses.Add(new Email { EmailAddress = "c.c@c.com" });
    c.EmailAddresses.Add(new Email { EmailAddress = "t.t@t.com" });
    c.PhoneNumbers.Add(new Phone { PhoneNumber = "07333333333" });
    c.PhoneNumbers.Add(new Phone { PhoneNumber = "07444444444" });

    using (var db = new ContactContext())
    {
        db.Contacts.Add(c);
        db.SaveChanges();
    }
}

static void ReadAll()
{
    using (var db = new ContactContext())
    {
        var records = db.Contacts
            .Include(e => e.EmailAddresses)
            .Include(p => p.PhoneNumbers)
            .ToList();

        foreach (var c in records)
        {
            Console.WriteLine($"{c.FirstName} {c.LastName}");
        }
    }
}

static void ReadById(int id)
{
    using (var db = new ContactContext())
    {
        var user = db.Contacts.Where(c => c.Id == id).FirstOrDefault();

        Console.WriteLine($"{user.FirstName} {user.LastName}");
    }
}