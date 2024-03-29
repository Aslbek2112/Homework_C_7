﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, 0.0, 10.0);
PrintArray(array);


double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
        
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:F2} ");
        }
        Console.WriteLine();
    }
}