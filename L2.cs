//Задача 1.
// Напишите программу, которая принимает на 
// вход трёхзначное число и удаляет вторую 
// цифру этого числа.
// Примеры
// a = 256 => 26 
// a = 891 => 81

// Console.WriteLine("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a>=100 && a<=999)
// {
//     int firstnumber=a/100;
//     int thirdnumber=a%10;
// Console.WriteLine($"{firstnumber}{thirdnumber}");
// }
// else
// {
//     Console.WriteLine("Введено нетрехзначное число.");
// }


//Задача 2.
// Задание 3. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое число 
// кратным второму. Если первое число некратно 
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1
// Console.WriteLine("Введите 2 числа(БОльшее и мЕньшее): ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a%b==0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine($"нет, {a%b}");
// }


// Задача 3.
// Напишите программу, которая выводит третью с 
// конца цифру заданного числа или сообщает, что 
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет
// using System.Globalization;
// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (number<100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (number>1000)
//     {
//         number=number/10;
//     }
//     Console.WriteLine($"{number%10}");
// }

// Задача 4.
