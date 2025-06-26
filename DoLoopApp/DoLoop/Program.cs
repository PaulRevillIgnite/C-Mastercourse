

// Do While loop runs the code at least once
// While loop runs the code 0 or more times

//do
//{
//
//}
//while (true);


//while (true)
//{
//
//}


bool isValidAge;
int age;

do
{
    Console.Write("Type your age: ");
    string? ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");
    } 
} while (isValidAge == false);

Console.WriteLine($"Your age is {age}");

int testNumber = 0;

do
{
    Console.WriteLine(testNumber);
    testNumber++;
}
while (testNumber != 10);


