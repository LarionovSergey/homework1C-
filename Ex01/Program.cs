﻿Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine());
if(A > B)
{
    Console.WriteLine("Max: " + A);
    Console.WriteLine("Min: " + B);
} 
else
{
    Console.WriteLine("Max: " + B);
    Console.WriteLine("Min: " + A);
}