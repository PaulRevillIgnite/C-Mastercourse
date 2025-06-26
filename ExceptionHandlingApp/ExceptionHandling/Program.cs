

using System.Runtime.CompilerServices;

try
{
    BadCall();
}
catch (Exception ex)
{
    Console.WriteLine("There was an exception thrown");
    Console.WriteLine(ex.Message);
}

static void BadCall()
{
    int[] ages = new int[] { 1, 3, 5 };

    for (int i = 0; i <= ages.Length; i++)
    {
        try
        {
            Console.WriteLine(ages[i]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("We had an error");
            Console.WriteLine(ex.Message);

            // This will make it so the exception is still thrown
            throw new Exception("There was an error handling the array", ex);
        }
    }
}


