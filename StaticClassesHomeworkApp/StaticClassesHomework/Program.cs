
// Create a console application with a static class that handles calculations.

using StaticClassesHomework;

double x = UserMessage.GetNumber("Type your first number: ");

double y = UserMessage.GetNumber("Type your second number: ");

UserMessage.CommunicateWithUser($"{x} + {y} = {CalculateMethods.Add(x, y).ToString()}");
UserMessage.CommunicateWithUser($"{x} - {y} = {CalculateMethods.Subtract(x, y).ToString()}");
UserMessage.CommunicateWithUser($"{x} x {y} = {CalculateMethods.Multiply(x, y).ToString()}");
UserMessage.CommunicateWithUser($"{x} / {y} = {CalculateMethods.Divide(x, y).ToString()}");