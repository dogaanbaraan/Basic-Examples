// See https://aka.ms/new-console-template for more information
var number = 300;

//Console.WriteLine(number == 10 ? "Sayi 10'a esittir" : "Sayi 10'a esit degildir.");

//if (number == 10)
//{
//    Console.WriteLine("Sayi 10'a esittir.");
//}
//else if (number > 10)
//{
//    Console.WriteLine("Sayi 10'dan buyuktur");
//}
//else
//    Console.WriteLine("Sayi 10'dan kucuktur");

//switch(number)
//{
//    case 10:
//        Console.WriteLine("Sayı 10'dur.");
//        break;
//    case 20:
//        Console.WriteLine("Sayı 20'dir.");
//        break;

//    default:
//        Console.WriteLine("Sayı 10 veya 20 degildir");
//        break;
//}

if (number >=0 && number <=100)
{
    Console.WriteLine("Number is between 0-100");
}

else if (number >100 && number <=200)
{
    Console.WriteLine( "Number is between 101-200");
}

else if(number <0 || number >200)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}