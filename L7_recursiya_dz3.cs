// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.
//  [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// using System.Data;
// using System.Runtime.InteropServices;

// int ReadInt(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void Naoborot(int [] array, int i)
// {
//     array[i] = Naoborot(int [] array, i+1);
//     if (i == array.Length)
//     {
//         return;
//     }
//     System.Console.Write(" ", str);
// }
// int size = ReadInt("Введите размер масиива");
// int[] myarray = new int[size];
// Random rand = new Random();
// for (int i = 0; i < size; i++)
// {
//     myarray[i] = rand.Next(100);
//     System.Console.Write(myarray[i] + " ");
// }


using System.Xml.Serialization;

int[] CreateArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
string PrintArray(int[] array)
{
    return string.Join(", ", array);
}

void UntiArray(int [] array, int i)
{
    if (i == array.Length)
    {
        return;
    }
    UntiArray(array, i+1);
    Console.Write(array[i]+" ");
}
int[] array = CreateArray(4, 40, 2);
System.Console.Write(PrintArray(array));
int i =array.Length;
System.Console.WriteLine();
UntiArray(array, 0);
