// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
long M = long.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
long N = long.Parse(Console.ReadLine());

Console.WriteLine($"{PrintNumbers(M, N)} сумма данных чисел = {SumNumbers(M, N)}");

string PrintNumbers(long numberOne, long numberTwo)
{
    if (numberTwo == numberOne)
    {
        return numberTwo.ToString();
    }
    string range = PrintNumbers(numberOne, numberTwo - 1) + ' ' + numberTwo.ToString();
    return (range);
}

long SumNumbers(long numberOne, long numberTwo)
{
    long sum = 0;
    if (numberTwo == numberOne)
    {
        sum += numberTwo;
        return sum;
    }
    sum = SumNumbers(numberOne, numberTwo - 1) + numberTwo;
    return sum;
}