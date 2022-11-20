// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
string str = Console.ReadLine();
int str1 = int.Parse(str);
int str2 = Math.Abs(str1);
string num = Convert.ToString(str2);
if (num.Length > 2)
{
    Console.WriteLine("Третья цифра: " + num[2]);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}