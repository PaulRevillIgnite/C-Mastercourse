

// Add students to a class roster List until there are no more students.
// Print out the count of the students to the Console.

Console.WriteLine("Add students to the class roster.");
Console.WriteLine("To add a student, type their name and hit enter.");
Console.WriteLine("Once you've added the final student, type 'end' and hit enter.");

List<String> classList = new List<String>();
bool finish = false;

do
{
    Console.Write($"Student {classList.Count + 1}: ");
    string student = Console.ReadLine();

    if (student.ToLower() == "end")
    {
        finish = true;
    }
    else
    {
        classList.Add(student);
    }
}
while (finish != true);

Console.WriteLine($"The total number of students is: {classList.Count}");