// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigitalMtoN(int m, int n) // метод (рекурсия) суммы чисел от M до N
{
    if(n<m)
    {
        return 0;
    }
    else
    {
        return n + SumDigitalMtoN(m, n-1);
    }
}

int numberM = ReadNumber("Введите M");
int numberN = ReadNumber("Введите N");
int sum = SumDigitalMtoN(numberM, numberN);
Console.WriteLine(sum);
