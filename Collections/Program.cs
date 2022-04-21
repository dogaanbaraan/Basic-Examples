

using System.Collections;

//ArrayList();

//List();

Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("book", "kitap");
dictionary.Add("mask", "maske");
dictionary.Add("high", "yüksek");

Console.WriteLine(dictionary["high"]);

static void ArrayList()
{
    ArrayList cities = new ArrayList();
    cities.Add("İstanbul");
    cities.Add("Ankara");
    cities.Add("İzmir");
    cities.Add(418);
    cities.Add('A');

    foreach (var item in cities)
    {
        Console.WriteLine(item);
    }
}

static void List()
{
    List<string> cities = new List<string>();
    cities.Add("İstanbul");
    cities.Add("Ankara");
    cities.Add("İzmir");

    foreach (string city in cities)
    {
        Console.WriteLine(city);
    }

    Console.WriteLine(cities.Contains("Ankara"));
    Console.WriteLine(cities.Contains("Adana"));


    Console.WriteLine("---------------");

    List<Customer> customers = new List<Customer>();
    customers.Add(new Customer { Id = 1, FirstName = "Barno" });
    customers.Add(new Customer { Id = 2, FirstName = "Erno" });

    var count = customers.Count();
    var customer2 = new Customer { Id = 3, FirstName = "Yaviz" };

    customers.Add(customer2);
    customers.AddRange(new Customer[2]
    {
    new Customer { Id = 4, FirstName ="Zorcu"},
    new Customer { Id = 5, FirstName ="Parlak"}
    });

    Console.WriteLine("Count: {0}", customers.Count());

    Console.WriteLine("---------------");

    foreach (var item in customers)
    {
        Console.WriteLine(item.FirstName);
    }
}

class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}