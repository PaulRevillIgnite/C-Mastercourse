

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "An animal that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of a fish is: {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1] = "Paul Revill";
employees[2] = "Coral Murphy";

Console.WriteLine($"The employee with ID number 2 is {employees[2]}");

Dictionary<string, int> daysOfTheWeek = new Dictionary<string, int>();

daysOfTheWeek["Monday"]  = 1;
daysOfTheWeek["Tuesday"] = 2;
daysOfTheWeek["Wednesday"] = 3;

Console.WriteLine($"Tuesday is day {daysOfTheWeek["Tuesday"]} of the week");