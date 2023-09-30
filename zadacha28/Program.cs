// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int n)
{ 
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact*= i;
    }
    return fact;
}
Console.Write($"Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Факториал числа {a} ={Factorial(a)}");