// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


IWork[] work = new IWork[3]
{
    new Workers(),
    new Managers(),
    new Robots()
};

foreach (var item in work)
{
    item.Work();
}

IEat[] eat = new IEat[2]
{
    new Workers(),
    new Managers()
};

interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface IGetSalary
{
    void GetSalary();
}

class Managers : IGetSalary, IEat, IWork
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Workers : IWork, IEat, IGetSalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robots : IWork
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}