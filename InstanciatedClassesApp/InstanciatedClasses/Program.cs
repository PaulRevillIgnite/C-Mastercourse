

using InstanciatedClasses;

// Example 1
// Building a house from the blueprint
//PersonModel person = new PersonModel();

//List<PersonModel> people = new List<PersonModel>();

//// Variable holds the street address
//PersonModel person = new PersonModel();
//person.firstName = "Paul";
//people.Add(person);

//person = new PersonModel();
//person.firstName = "Coz";
//people.Add(person);


//foreach (PersonModel p in people)
//{
//    Console.WriteLine(p.firstName);
//}

// Example 2
List<PersonModel> people = new List<PersonModel>();
string firstName = "";

do
{
    Console.Write("Type your firstname (or exit to stop): ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() == "exit")
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write("Type your lastName: ");
        string lastName = Console.ReadLine();

        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
    }    
}
while (firstName.ToLower() != "exit");

foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);
}