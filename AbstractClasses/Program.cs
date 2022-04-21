
Database database = new SqlServer();
database.Add();
database.Delete();

Database database2 = new MySql();
database2.Add();
database2.Delete();

Console.ReadLine();

abstract class Database
{
    public void Add()
    {
        Console.WriteLine("added by default");
    }

    public abstract void Delete();

}

class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("deleted by SqlServer");
    }
}

class MySql : Database
{
    public override void Delete()
    {
        Console.WriteLine("deleted by MySql");
    }
}
