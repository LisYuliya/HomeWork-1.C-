//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a = 44;
int b = 2;
int c = 7;

int max = a; 

if (a > max ) max = a; 
if (b > max ) max = b; 
if (c > max ) max = c; 

Console.Write("if a = ");
Console.Write(a);
Console.Write("; b = ");
Console.Write(b);
Console.Write("; c = ");
Console.Write(c);
Console.Write(", then max = ");
Console.WriteLine(max);


