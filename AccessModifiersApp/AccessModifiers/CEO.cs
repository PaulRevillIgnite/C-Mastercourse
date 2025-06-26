using DemoLibrary;

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
// https://www.w3schools.com/cs/cs_access_modifiers.php

namespace AccessModifiers
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            DataAccess data = new DemoLibrary.DataAccess();
            FormerLastName = "Test";
        }
    }
}
