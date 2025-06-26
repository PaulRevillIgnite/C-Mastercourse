
string name = "";

try
{
    DifferentMethod();

    Console.Write("Type your name: ");
    name = Console.ReadLine();
    ComplexMethod(name);

    SimpleMethod();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("You should not be calling these methods");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You forgot to finished your code!");
}
catch (Exception ex) when (name.ToLower() == "paul")
{
    Console.WriteLine("You used the name Paul, didn't you");
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    Console.WriteLine("This is the most general exception");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("I always run");
}

static void SimpleMethod()
{
    throw new InvalidOperationException("You should not be calling the SimpleMethod");
}

static void ComplexMethod(string name)
{
    if (name.ToLower() == "paul")
    {
        throw new InsufficientMemoryException("Paul is too tall for this method");
    }
    else
    {
        throw new ArgumentException("This person isn't Paul");
    }
}

static void DifferentMethod()
{
    //throw new NotImplementedException();
}
