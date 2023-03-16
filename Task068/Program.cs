// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число m функции Аккермана: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число n функции Аккермана: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {AckermanFunctions(m, n)}");

int AckermanFunctions(int numberOne, int numberTwo)
{
    if (numberOne == 0)
    {
        return numberTwo + 1;
    }
    if (numberTwo == 0)
    {
        return AckermanFunctions(numberOne - 1, 1);
    }
    return AckermanFunctions(numberOne - 1, AckermanFunctions(numberOne, numberTwo - 1));
}