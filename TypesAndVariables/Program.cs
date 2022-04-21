// See https://aka.ms/new-console-template for more information
int number1 = 2147483647;
long number2 = 9223372036854775807;
short number3 = 32767;
byte number4 = 255;
double number5 = 21.4;
decimal number6 = 21.4M;
bool condition = true;
char character = 'A';
var number7 = 10;
number7 = 'A';

Console.WriteLine("Number 1 is: {0}", number1);
Console.WriteLine("Number 2 is: {0}", number2);
Console.WriteLine("Number 3 is: {0}", number3);
Console.WriteLine("Number 4 is: {0}", number4);
Console.WriteLine("Number 5 is: {0}", number5);
Console.WriteLine("Number 6 is: {0}", number6);
Console.WriteLine("Number 7 is: {0}", number7);
Console.WriteLine("Character is: {0}", character);
Console.WriteLine("Character int is: {0}",(int) character);
Console.WriteLine((int)Days.Friday);
Console.WriteLine(Days.Friday);

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}