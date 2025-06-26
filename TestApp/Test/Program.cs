

int HasAgreedValueDB = 0;

string? HasAgreedValue;



HasAgreedValue = (HasAgreedValueDB != null && HasAgreedValueDB != 0) ? "Agreed Value" : "No Agreed Value";

Console.WriteLine(HasAgreedValue);