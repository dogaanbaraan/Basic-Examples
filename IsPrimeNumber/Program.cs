static bool İsPrimeNumber(int number)
{
    bool result = true;

    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }

    return result;
}

if (İsPrimeNumber(6))
{
    Console.WriteLine("Number is prime number");
}
else
    Console.WriteLine("Number is not prime number");

Console.ReadLine();