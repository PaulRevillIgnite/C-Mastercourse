

using System.Runtime.CompilerServices;

// If you change the name of a variable, use CTRL-. to change it in the rest of the file
string firstName = string.Empty;
string middleName = "Stephen";
string lastName = "";
string filePath = string.Empty;
string filePath2 = string.Empty;

firstName = "Paul";
lastName = "Revill";

// Escape character
filePath = "C:\\";

// String literal character
filePath2 = @"C:\";

//Console.WriteLine(firstName + " " + lastName);

// String interpolation and string literal
string testString = $@"The file for {firstName} is at C:\SampleFiles";
Console.WriteLine(testString);

// String interpolation
Console.WriteLine($"Hello {firstName} {middleName} {lastName}");
Console.WriteLine(filePath);