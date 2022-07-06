/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int tree(int num1)
{
    if (num1 > 999 || num1 < 100) //проверка, что число трёхзначное
    {
        Console.Write("Число не трёхзначное! ");
        return num1;
    }

    return (num1 / 10) % 10;
}
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sec = tree(a);
Console.WriteLine(sec);





/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// 1 вариант через string

void tree(string num1)
{
    int b = num1.Length;

    if (b <= 2)
    {
        Console.WriteLine("Третьей цифры нет(");
        return;
    }

    var c = a.ToString();
    Console.WriteLine("Третья цифра числа: " + c[2]);
}
Console.Write("Введите число: ");
var a = Console.ReadLine();
tree(a);


// 2 вариант через математику
int tree(int num1)
{
    if (num1 < 100 && num1 > -100) //проверка разрядности числа
    {
        Console.WriteLine("У введённого числа нет третьей цифры(");
        return num1; //здесь нужна остановка выполнения программы, если условие не выполняется, наверняка есть более правильный способ
    }

    if (num1 < 0) num1 = num1 * -1; //проверка на отрицательное число

    int temp = num1;
    int count = 0;

    while (temp > 0) //вычисление разрядности числа
    {
        temp = temp / 10;
        count++;
    }

    count = count - 3;
    var temp2 = Math.Pow(10, count);

    return (num1 / Convert.ToInt32(temp2)) % 10; //поиск третьей цифры
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sec = tree(a);
Console.WriteLine(sec);




/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void day(int num1)
{
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
}
Console.Write("Введите число 1-7: ");
int a = Convert.ToInt32(Console.ReadLine());
day(a);