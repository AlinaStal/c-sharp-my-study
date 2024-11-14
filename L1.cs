using System.Data;
using System.Linq.Expressions;
using System.Net.WebSockets;

// Задача 1. 
// //Напишшите прогу, которая на вход принимает число и выдает его квадрат.
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b=a*a;
// Console.Write(b);


// Задача 2.
// Напишите программу, которая на вход 
// принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 => да 
// a = 2, b = 10 => нет 
// a = 9, b = -3 => да 
// a = -3, b = 9 => нет
// Console.WriteLine("Введите 2 числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a==b*b)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Нет");
// }
 

//  Shift+Alt+f = Автовыравнивание кода


// Задача 3.
// Код, при котором при введении числа присваивается день недели
// System.Console.WriteLine("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (day==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (day==3)
// {
//     Console.WriteLine("Среда");
// }
// else if (day==4)
// {
//     Console.WriteLine("Четверг");
// }
//  else if (day==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (day==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (day==1)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Выберите другой день недели");
// }


// Задача 4.
// Напишите программу, которая на вход принимает 
// целое число N, а на выходе показывает все целые 
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
// Console.WriteLine("Введите положительное целое число: ");
// int N = Convert.ToInt32(Console.ReadLine());   
//int N = Vath.Abs(Convert.ToInt32(Console.ReadLine())) - либо так, сразу берет модуль от введенного числа
// if (N<0)
// {
//     N=-N;
// }
// int M = N*(-1);
// while (M<=N)
// {
//     Console.Write(M + " " );
//     M++;
// }


