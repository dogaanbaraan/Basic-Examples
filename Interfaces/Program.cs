//NewMethod();
//NewMethod1();
using Interfaces;

ICustomerDal[] customerDals = new ICustomerDal[]
{
    new SqlCustomerDal(),
    new OracleCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
    customerDal.Delete();
    customerDal.Update();
}

Console.ReadLine();


static void NewMethod()
{
    Customer customer = new Customer
    {
        Id = 3,
        FirstName = "Baran",
        LastName = "Dogan",
        Address = "İstanbul"
    };

    Student student = new Student
    {
        Id = 2,
        FirstName = "Erno",
        LastName = "Ozder",
        Departmant = "Stockmount"
    };

    PersonManager manager = new PersonManager();

    manager.Add(customer);
    manager.Add(student);
}

static void NewMethod1()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
    customerManager.Update(new OracleCustomerDal());
    customerManager.Delete(new OracleCustomerDal());
}

interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}


class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}


class PersonManager
{
    public void Add(IPerson Person)
    {
        Console.WriteLine(Person.FirstName);
    }
}