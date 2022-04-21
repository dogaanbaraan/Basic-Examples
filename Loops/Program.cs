//Dongu();
//While();
//DoWhile();


string[] student = new[] { "Barno", "Erno", "Yaviz" };
foreach (var item in student)
{
    Console.WriteLine(item);
}

static void While()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is: {0}", number);
    Console.ReadLine();
}
static void DoWhile()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 0);
    Console.ReadLine();
}

static void Dongu()
{
    for (int i = 0; i <= 100; i = i + 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished:)))))");
    Console.ReadLine();
}