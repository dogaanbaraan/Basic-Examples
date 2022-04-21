
string[] students = new string[3];
students[0] = "baran";
students[1] = "erno";
students[2] = "yaviz";

//string[] student3 = {"barno", "erno", "furko" };

//string[] student4 = new string[3] { "erno", "barno", "furko" };

string[] students2 = new[] { "erno", "barno", "zorcu" };

foreach (var student in students2)
{
    Console.WriteLine(student);
}
Console.WriteLine("************");

//çoklu diziler

string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmir","Balıkesir" },
    { "1","2","3"} ,
    {"A","B","C"  },
    {"Batman","Spiderman","Carnage"  },
    {"FB", "BJK", "GS" }
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("************");
}

Console.ReadLine();