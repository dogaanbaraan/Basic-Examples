
CustomerManager customerManager = new CustomerManager();
customerManager.logger = new SmsLogger();
customerManager.Add();
Console.ReadLine();




class CustomerManager
{
    public ILogger logger { get; set; }
    public void Add()
    {
        logger.Log();
        Console.WriteLine("Added!!");
    }
}

class DatabaseLogger : ILogger
{
    
    public void Log()
    {
      
        Console.WriteLine("Database logged");
    }
}

class SmsLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Sms logged");
    }
}

class TextLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Text logged");
    }
}

interface ILogger
{
    void Log();
}