//StringMethod();

string sentence = "My name is Baran Doğan";

var result = sentence.Length;
var result2 = sentence.Clone(); //klonlama işlevidir, stringin daha sonradan değiştirilmesi halinde klonlanan yapıyı tutar.
sentence = "My name is Barno Doğan";

bool result3 = sentence.EndsWith("n"); // bitiş karakterini true false olarak döndürür.
bool result4 = sentence.StartsWith("K"); //başlangıç karakterini true false olarak döndürür.

var result5 = sentence.IndexOf("is"); //girilen stringin hangi indexten başladığını belirtir.
var result6 = sentence.LastIndexOf(" "); //sondan aramaya başlar

var result7 = sentence.Insert(0, "Hello, "); //string ifade hangi indexten başlarsak oradan ekleme yapar.

var result8 = sentence.Substring(3,4); //string ifadeyi parçalara ayırmayı sağlar.

var result9 = sentence.ToLower(); //string ifadedeki tüm karakterleri küçük harfe çevirir.
var result10 = sentence.ToUpper(); //string ifadedeki tüm karakterleri büyük harfe çevirir.

var result11 = sentence.Replace(" ", "-"); //string ifadedeki karakterleri değiştirmek için kullanılır.

var result12 = sentence.Remove(2); //string ifadeden girileren indexten sonrasını atmak için kullanılır. 

Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);
Console.WriteLine(result5);
Console.WriteLine(result6);
Console.WriteLine(result7); 
Console.WriteLine(result8); 
Console.WriteLine(result9);
Console.WriteLine(result10);
Console.WriteLine(result11);
Console.WriteLine(result12);
Console.ReadLine();

static void StringMethod()
{
    string city = "Ankara";

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }
    string city2 = "İstanbul";

    Console.WriteLine(String.Format("{0} {1}", city, city2));
    Console.ReadLine();
}