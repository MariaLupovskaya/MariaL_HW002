// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
Console.WriteLine();
string str = Console.ReadLine();
Console.WriteLine();
int A = int.Parse(str);
int B = A / 10;
int C = B % 10;
int D = Math.Abs(C);
Console.WriteLine(D);