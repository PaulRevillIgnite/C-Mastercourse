using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SQLiteCrud
    {
        private readonly string connectionSting;
        private SQLliteDataAccess db = new SQLliteDataAccess();

        public SQLiteCrud(string connectionSting)
        {
            this.connectionSting = connectionSting;
        }

        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "select Id, FirstName, LastName from Contacts";

            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, connectionSting);
        }

        public FullContactModel GetFullContactById(int id)
        {
            string sql = "select Id, FirstName, LastName from Contacts where Id = @Id";

            FullContactModel output = new FullContactModel();

            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, connectionSting).FirstOrDefault();

            if (output.BasicInfo == null)
            {
                //Do something to tell the user that the record was not found
                //throw new Exception("User not found");
                return null;
            }

            sql = @"select e.*
                    from EmailAddresses e
                        inner join ContactEmails ce on ce.EmailAddressID = e.Id
                    where ce.ContactID = @Id";

            output.EmailAddesses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, connectionSting);

            sql = @"select p.*
                    from PhoneNumbers p
                        inner join ContactPhoneNumbers cp on cp.PhoneNumberID = p.Id
                    where cp.ContactID = @Id";

            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, connectionSting);

            return output;
        }

        public void CreateContact(FullContactModel contact)
        {
            // Save the basic contact
            string sql = "insert into Contacts (FirstName, LastName) values (@FirstName, @LastName);";

            db.SaveData(sql,
                        new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                        connectionSting);

            // Get the ID number of the contact
            sql = "select Id from Contacts where FirstName = @FirstName and LastName = @LastName";

            int contactId = db.LoadData<IdLookupModel, dynamic>(
                sql,
                new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                connectionSting).First().Id;

            foreach (var phoneNumber in contact.PhoneNumbers)
            {
                if (phoneNumber.Id == 0)
                {
                    sql = "insert into PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                    db.SaveData(sql, new { phoneNumber.PhoneNumber }, connectionSting);

                    sql = "select Id from PhoneNumbers where PhoneNumber = @PhoneNumber";
                    phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(
                        sql,
                        new { phoneNumber.PhoneNumber },
                        connectionSting).First().Id;
                }

                sql = "insert into ContactPhoneNumbers (ContactId, PhoneNumberId) values (@ContactId, @PhoneNumberId);";
                db.SaveData(sql, new { ContactId = contactId, PhoneNumberId = phoneNumber.Id }, connectionSting);
            }

            foreach (var email in contact.EmailAddesses)
            {
                if (email.Id == 0)
                {
                    sql = "insert into EmailAddresses (EmailAddress) values (@EmailAddress);";
                    db.SaveData(sql, new { email.EmailAddress }, connectionSting);

                    sql = "select Id from EmailAddresses where EmailAddress = @EmailAddress;";
                    email.Id = db.LoadData<IdLookupModel, dynamic>(
                        sql,
                        new { email.EmailAddress },
                        connectionSting).First().Id;
                }

                sql = "insert into ContactEmails (ContactId, EmailAddressId) values (@ContactId, @EmailAddressId);";
                db.SaveData(sql, new { ContactId = contactId, EmailAddressId = email.Id }, connectionSting);
            }

        }

        public void UpdateContactName(BasicContactModel contact)
        {
            string sql = "update Contacts set FirstName = @FirstName, LastName = @LastName where Id = @Id;";
            db.SaveData(sql, contact, connectionSting);
        }

        public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
        {
            // Find all of the useages of the phone number id
            // If 1, then delete link and phone number
            // If > 1, then delete link for contact

            string sql = "select Id, ContactId, PhoneNumberId from ContactPhoneNumbers where PhoneNumberId = @PhoneNumberId;";
            var links = db.LoadData<ContactPhoneNumberModel, dynamic>(
                sql,
                new { PhoneNumberId = phoneNumberId },
                connectionSting);

            sql = "delete from ContactPhoneNumbers where PhoneNumberId = @PhoneNumberId and ContactId = @ContactId";
            db.SaveData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, connectionSting);

            if (links.Count == 1)
            {
                sql = "delect from PhoneNumbers where Id = @PhoneNumberId;";
                db.SaveData(sql, new { PhoneNumberId = phoneNumberId }, connectionSting);
            }
        }
    }
}
