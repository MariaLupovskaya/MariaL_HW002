// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 в соответствии с днем недели, где пн - 1");
string str = Console.ReadLine();
int A = int.Parse(str);
if (A <= 5)
{
    Console.WriteLine("Этот день недели не является выходным днем");
}
else
{
    Console.WriteLine("Это выходной день");
}