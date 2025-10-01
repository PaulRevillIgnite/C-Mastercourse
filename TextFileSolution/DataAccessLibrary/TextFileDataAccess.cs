using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<ContactModel> ReadAllRecords(string textFile)
        {

            if (File.Exists(textFile) == false)
            {
                return new List<ContactModel>();
            }

            var lines = File.ReadAllLines(textFile);

            List<ContactModel> output = new List<ContactModel>();

            foreach (var line in lines)
            {
                ContactModel c = new ContactModel();
                var values = line.Split(',');

                if (values.Length > 4)
                {
                    throw new Exception($"Invalid row of data: {line}");
                }

                c.FirstName = values[0];
                c.LastName = values[1];
                c.EmailAddresses = values[2].Split(';').ToList();
                c.PhoneNumbers = values[3].Split(';').ToList();

                output.Add(c);
            }

            return output;
        }

        public void WriteAllRecords(List<ContactModel> conmtacts, string textFile)
        {
            List<string> lines = new List<string>();

            foreach (var c in conmtacts)
            {
                lines.Add($"{c.FirstName},{c.LastName},{String.Join(';', c.EmailAddresses)},{String.Join(';', c.PhoneNumbers)}");
            }

            File.WriteAllLines(textFile, lines);
        }
    }
}
