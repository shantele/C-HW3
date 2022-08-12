﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int start = 1; start <=N; start++)
{
    Console.Write($"{(Math.Pow(start,3))} ");
}