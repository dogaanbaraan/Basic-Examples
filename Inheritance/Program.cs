// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Person[] person = new Person[3] 
{
    new Manager{FirstName ="Barno"},
    new Student{FirstName ="Erno"},
    new Person{FirstName ="Zorcu"}
};

foreach (var item in person)
{
    Console.WriteLine(item.FirstName);
}
Console.ReadLine(); 

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Manager : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Size { get; set; }
}