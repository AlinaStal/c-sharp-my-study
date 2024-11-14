// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 
//  m = 2, n = 3 -> A(m,n) = 29
int ReadInt(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    if (m>0 && n==0)
    {
        return Akkerman(m-1,1);
    }
    if (m>0 && n>0)
    {
        return Akkerman(m-1, Akkerman(m,n-1));
    }
    return Akkerman(m,n);
}
// -----------------
int m = ReadInt("Введите чесло m");
int n = ReadInt("Введите чесло n");
System.Console.WriteLine(Akkerman(m,n));
