// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30


Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите 2 число N: ");
SumFromMToN(m, n);


void SumFromMToN(int m, int n)              // вызов метода "сумма чисел от M до N"
{
    Console.Write(SumMN(m - 1, n));
}


int SumMN(int m, int n)                     // метод сумма чисел от M до N
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

