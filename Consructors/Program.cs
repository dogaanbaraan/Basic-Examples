
CustomerManager customerManager = new CustomerManager();
customerManager.List();
Product product = new Product
{
    Id = 1,
    ProductName = "Laptop"
};
Console.WriteLine(product.ProductName);

Product product1 = new Product();

EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
employeeManager.Add();
PersonManager personManager = new PersonManager("Person");
personManager.Add();
Console.ReadLine();

class CustomerManager
{
    int _count = 15;

    public CustomerManager(int count)
    {
        _count = count;
    }

    //constructorlarda overloading olur. 
    public CustomerManager()
    {

    }

    public void List()
    {
        Console.WriteLine("Listed {0} items!!", _count);
    }

    public void Add()
    {
        Console.WriteLine("Added!!");
    }

}

class Product
{
    public Product()
    {

    }

    int _id;
    string _name;
    public Product(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public int Id { get; set; }
    public string ProductName { get; set; }

}

interface ILogger
{
    void Log();
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("logged database");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("logged file");
    }
}
class EmployeeManager
{
    private ILogger _logger;

    public EmployeeManager(ILogger logger)
    {
        _logger = logger;
    }
    public void Add()
    {
        _logger.Log();
        Console.WriteLine("Added!");
    }

}

class BaseClass
{
    string _entity;
    public BaseClass(string entity)
    {
        _entity = entity;
    }
    public void Message()
    {
        Console.WriteLine("{0} message", _entity);
    }

}

class PersonManager : BaseClass
{
    public PersonManager(string entity) : base(entity)
    {

    }
    public void Add()
    {
        Message();
        Console.WriteLine("Added!!");
    }
    
}