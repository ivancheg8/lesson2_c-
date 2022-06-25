/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


Console.Write("Введите трёхзначное число: ");
var a = Console.ReadLine();
var b = a.Length;

if (b != 3)
{
    Console.WriteLine("Неправильный ввод!");
    return;
}

var c = a.ToString();
Console.WriteLine(c[1]);






/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Write("Введите число: ");
var a = Console.ReadLine();
var b = a.Length;

if (b <= 2)
{
    Console.WriteLine("Третьей цифры нет(");
    return;
}

var c = a.ToString();
Console.WriteLine(c[2]);






/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.Write("Введите число 1-7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 7)
{
    Console.WriteLine("Неправильный ввод!");
}

if (a > 0 && a < 6)
{
    Console.WriteLine("Сегодня будний день");
}

if (a > 5 && a < 8)
{
    Console.WriteLine("Сегодня выходной");
}
