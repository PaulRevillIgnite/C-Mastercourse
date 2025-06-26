

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);

    if (i == 73)
    {
        throw new Exception("You hit line 73");
    }
}

