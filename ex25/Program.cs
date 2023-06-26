/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число В: ");
int B = int.Parse(Console.ReadLine());
if (B < 0) Console.WriteLine("В не является натуральным числом");
else
{
    int pow = A;
    for (int i = 1; i < B; i++)
    {
        pow = pow * A;
    }
    Console.WriteLine($"{A} в {B} степени -> {pow}");
}

