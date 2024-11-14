//Задача 1.
// // Задайте массив. Напишите программу, которая определяет, 
// // присутствует ли заданное число в массиве. Программа 
// // должна выдать ответ: Да/Нет.
// // Примеры
// // [1 3 4 19 3], 8 => Нет
// // [-4 3 4 1], 3 => Да 
// Console.WriteLine("Введите кошличество элементов в массиве:");
// int size = Convert.ToInt32(Console.ReadLine());
// //Заполнение ячеек случайными числами
// int [] myarray = new int [size];
// Random rand = new Random();//Введение класса

// for(int i=0; i<size; i++)
// {
//     myarray[i]= rand.Next(-10,11);//Использование класса

// }
// for(int i=0;i<size;i++)
// {
//     Console.Write(myarray[i]+" ");
// }
// System.Console.WriteLine(" ");
// Console.WriteLine("Введите искомое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i=0;i<size;i++)
// {
//     if(myarray[i]==number)
//     {
//         System.Console.WriteLine("да");
//         return;
//     }
// }
// System.Console.WriteLine("нет");



//Задача 2.
// Задайте массив из 10 элементов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные элементы на 
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]
// int [] myarray = new int [10];
// Random rand = new Random();
// for(int i=0; i<10; i++)
// {
//     myarray[i]= rand.Next(-10,11);//Заполнение рандомными цифрами
// }
// for(int i=0;i<10;i++)
// {
//     Console.Write(myarray[i]+" ");//Написать массив
// }
// System.Console.WriteLine(" ");
// for(int i=0;i<10;i++)
// {
//     myarray[i]= -myarray[i];
// }
// for(int i=0;i<10;i++)
// {
//     Console.Write(myarray[i]+" ");
// }



// Задание 3.
// Найдите произведения пар чисел в одномерном массиве. Парой 
// считаем первый и последний элемент, второй и предпоследний и 
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myarray = new int[size];
int[] array = new int[size / 2];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    myarray[i] = rand.Next(1, 11);//Заполнение рандомными цифрами
    Console.Write(myarray[i] + " ");
}
Console.WriteLine(" ");
// if (size % 2 == 0)
// {
//     size = size + 2;
//     for (int i = 0; i < size / 2; i++)
//     {
//         int[] array = new int[size / 2];
//         array[i] = myarray[i] * myarray[size - 3];
//         size = size - 1;
//         Console.Write(array[i] + " ");
//     }
// }
// else
// {
//     {
//         size = size + 1;
//         for (int i = 0; i < size / 2; i++)
//         {
//             int[] array = new int[size / 2];
//             array[i] = myarray[i] * myarray[size - 2];
//             size = size - 1;
//             Console.Write(array[i] + " ");
//         }
//         Console.Write("(элемент " + myarray[size / 2] + " не имеет пары)");
//     }
// }
// это я сама решала и с нечетноестью какие-то проблемы(что выше)
for(int i=0;i<size/2;i++)
{
    array[i]=myarray[i]*myarray[size-1-i];
Console.Write(array[i]+" ");
}