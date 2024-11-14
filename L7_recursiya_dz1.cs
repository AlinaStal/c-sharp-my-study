//  Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (N<M) return;
    PrintNumbers(M, N-1);
    System.Console.Write(N+" ");
}
//-----------------------
int M = ReadInt("Введите минимальное числшо");
int N = ReadInt("Введите максимальное число");
PrintNumbers(M,N);