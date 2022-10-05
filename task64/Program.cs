// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Например:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNto1(int n) // метод вывода чисел от N до 1
{
    if (n <= 0)
    {
        return;
    }
    else
    {
        Console.Write(n + " "); // сначала печатаем
        PrintNto1(n - 1); // потом вызываем снова метод
    }
}

int number = ReadNumber("Введите n");
PrintNto1(number);
