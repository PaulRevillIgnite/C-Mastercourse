

using StaticClasses;

string firstName = RequestData.GetString("Type your name: ");

UserMessages.ApplicationStartMessage(firstName);

double x = RequestData.GetDouble("Type your first number: ");
double y = RequestData.GetDouble("Type your second number: ");

double result = CalculateData.Add(x, y);

UserMessages.PrintResultMessage($"{x} + {y} = {result}");