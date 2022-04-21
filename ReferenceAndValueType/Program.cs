int sayi1 = 10;
int sayi2 = 20;

sayi2 = sayi1;
sayi1 = 1;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

string[] citys = new string[] {"İstanbul","Ankara", "İzmir" };
string[] citys2 = new string[] {"Balıkesir","Amasya", "İzmit" };
citys2 = citys;
citys[0] = "Edirne";
Console.WriteLine(citys[0]);
Console.WriteLine(citys2[2]);