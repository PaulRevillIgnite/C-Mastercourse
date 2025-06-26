

// Create a Dictionary list of employee IDs and the name that goes with the ID.
// Fill in a few records.
// Ask the user for their ID number and return their name.

Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(1, "Paul");
employees.Add(2, "Coral");
employees.Add(3, "Joe");

Console.Write("Type your employee ID number: ");
string idNumberString = Console.ReadLine();
int.TryParse(idNumberString, out int idNumber);

Console.WriteLine($"Welcome {employees[idNumber]}");