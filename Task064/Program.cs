// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(N));

string PrintNumbers(int number)
{
    if (number == 1)
    {
        // Console.WriteLine(number);
        return number.ToString();
    }
    string range = number.ToString() + ' ' + PrintNumbers(number - 1);
    // Console.WriteLine(range);
    return (range);
}