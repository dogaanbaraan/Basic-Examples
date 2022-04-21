//trycatch();

using Exceptions;

static void trycatch()
{
    try
    {
        string[] names = new string[3] { "Barno", "Erno", "Zorco" };
        names[4] = "Ahmet";
    }
    catch (Exception exception)
    {
        Console.WriteLine("Something is wrong!!!");
        Console.WriteLine(exception.Message);
    }
}
try
{
    Find();
}
catch (RecordNotFoundException exception)
{
    Console.WriteLine(exception.Message);
}



static void Find()
{
    List<string> student = new List<string> { "Engin", "Baran", "Ugur" };

    if (!student.Contains("Ahmet"))
    {
        throw new RecordNotFoundException("record not found");
    }
    else
        Console.WriteLine("record found");
}