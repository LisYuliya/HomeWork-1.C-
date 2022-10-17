//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = -10;
int b = 2;

int max = a; 
int min = b;
if (a > max ) max = a; 
if (b < min ) min = b;
if (b > max ) max = b; 
if (a < min ) min = a;

Console.Write("if a = ");
Console.Write(a);
Console.Write("; b = ");
Console.Write(b);
Console.Write(", then max = ");
Console.Write(max);
Console.Write(", min = ");
Console.WriteLine(min);

