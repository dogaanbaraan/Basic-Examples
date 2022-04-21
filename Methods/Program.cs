//Add();
//Add();
//Add();
//Add();
//var result = Add2(30, 42);
//int sayi1 = 20;
//int sayi2 = 30;
//var result2 = Add3(sayi1, sayi2);



Console.WriteLine(Multiply(8, 2));
Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

//Console.WriteLine(result2);
//Console.WriteLine(sayi1);
//Console.WriteLine(result);
Console.ReadLine();

static void Add()
{
    Console.WriteLine("Added!!");
}

static int Add2(int sayi1, int sayi2)
{
    var result = sayi1 + sayi2;
    return result;
}

static int Add3(int sayi1, int sayi2)
{
    sayi1 = 30;
    return sayi1 + sayi2;
}

static int Multiply(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}

static int Add4(params int[] numbers)
{
    return numbers.Sum();
}


