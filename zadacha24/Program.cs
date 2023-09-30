// Демонстрация решения Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

using System.ComponentModel.DataAnnotations;

Console.WriteLine($"Введите число А: ");
int a = int.Parse(Console.ReadLine());

int Sum(int Limit)
{
    int sum = 0;
    for (int i = 1; i <= Limit; i++)
    {
        sum +=i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");