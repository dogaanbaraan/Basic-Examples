Sql sql = new Sql();
sql.Add();


class Database
{
    public virtual void Add()
    {
        Console.WriteLine("added by default");
    }
    public void Delete()
    {
        Console.WriteLine("deleted by default");
    }
}

class Sql : Database
{
    public override void Add()
    {
        Console.WriteLine("added by sqlserver");
        base.Add();
    }
}

class MySql : Database
{
}